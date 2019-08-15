namespace NameChanger
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentName = new System.Windows.Forms.Label();
            this.txtCurrentName = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.AutoSize = true;
            this.lblCurrentName.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(87, 15);
            this.lblCurrentName.TabIndex = 0;
            this.lblCurrentName.Text = "Current Name:";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Location = new System.Drawing.Point(15, 27);
            this.txtCurrentName.MaxLength = 20;
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(188, 21);
            this.txtCurrentName.TabIndex = 1;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(15, 69);
            this.txtNewName.MaxLength = 20;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(188, 21);
            this.txtNewName.TabIndex = 3;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(12, 51);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(72, 15);
            this.lblNewName.TabIndex = 2;
            this.lblNewName.Text = "New Name:";
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(15, 96);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(188, 23);
            this.btnChangeName.TabIndex = 4;
            this.btnChangeName.Text = "Change";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.BtnChangeName_Click);
            // 
            // lblGitHub
            // 
            this.lblGitHub.Location = new System.Drawing.Point(15, 123);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(188, 15);
            this.lblGitHub.TabIndex = 6;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "GitHub";
            this.lblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblGitHub_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 142);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtCurrentName);
            this.Controls.Add(this.lblCurrentName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Name Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentName;
        private System.Windows.Forms.TextBox txtCurrentName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.LinkLabel lblGitHub;
    }
}

