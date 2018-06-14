namespace QuickStart
{
    partial class FormLogin
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
            this.lable_name = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textbox_user = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable_name
            // 
            this.lable_name.AutoSize = true;
            this.lable_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lable_name.Location = new System.Drawing.Point(56, 38);
            this.lable_name.Name = "lable_name";
            this.lable_name.Size = new System.Drawing.Size(73, 17);
            this.lable_name.TabIndex = 0;
            this.lable_name.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_password.Location = new System.Drawing.Point(56, 78);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(69, 17);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // textbox_user
            // 
            this.textbox_user.Location = new System.Drawing.Point(154, 38);
            this.textbox_user.Name = "textbox_user";
            this.textbox_user.Size = new System.Drawing.Size(150, 20);
            this.textbox_user.TabIndex = 2;
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(154, 77);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(150, 20);
            this.textbox_password.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(154, 115);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(150, 30);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "SING IN";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(372, 182);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_user);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.lable_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Quick Start Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_name;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textbox_user;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_login;
    }
}

