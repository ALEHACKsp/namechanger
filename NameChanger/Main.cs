﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace NameChanger
{
    public partial class Main : Form
    {
        public static byte[] TargetBytes = null;
        public static byte[] NewBytes = null;

        private Process gta = null;

        public Main()
        {
            InitializeComponent();
        }

        private byte[] GetNameBytes(string name, bool terminate = false)
        {
            var bytes = new List<byte>(Encoding.ASCII.GetBytes(name));

            if (terminate) bytes.Add(0); // terminate string

            return bytes.ToArray();
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            var procs = Process.GetProcessesByName("GTA5");
            if (procs == null || procs.Length == 0)
            {
                MessageBox.Show("GTA5.exe not found!", "Name Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.gta = procs[0];
            var handle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.All, false, this.gta.Id);
            if (handle != IntPtr.Zero)
            {
                txtCurrentName.Enabled = false;
                txtNewName.Enabled = false;
                btnChangeName.Enabled = false;

                Main.TargetBytes = GetNameBytes(txtCurrentName.Text);
                Main.NewBytes = GetNameBytes(txtNewName.Text, true);

                var scan = new Scan(handle);

                scan.Process(Main.TargetBytes, () =>
                {
                    var res = scan.GetResults();

                    if (res.Count > 0)
                    {
                        foreach (var result in res)
                        {
                            if (NativeMethods.VirtualProtectEx(scan.processHandle, new IntPtr(result), NewBytes.Length, NativeMethods.AllocationProtect.PAGE_EXECUTE_READWRITE, out NativeMethods.AllocationProtect originalProtection))
                            {
                                NativeMethods.WriteProcessMemory(scan.processHandle, new IntPtr(result), Main.NewBytes, Main.NewBytes.Length, out var bytesWritten);
                                NativeMethods.VirtualProtectEx(scan.processHandle, new IntPtr(result), Main.NewBytes.Length, originalProtection, out var newold);
                            }
                        }

                        NativeMethods.CloseHandle(scan.processHandle);

                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("Name Changed: " + res.Count + " Occurences", "Name Changer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("Didn't Find Current Name", "Name Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }

                    Invoke(new Action(() =>
                    {
                        txtCurrentName.Enabled = true;
                        txtCurrentName.Text = txtNewName.Text;
                        txtNewName.Enabled = true;
                        txtNewName.Text = "";
                        btnChangeName.Enabled = true;
                    }));
                });
            }
            else
            {
                MessageBox.Show("OpenProcess Failed", "Name Changer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sudo-bob/namechanger");
        }
    }
}