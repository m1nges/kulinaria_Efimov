namespace kulinaria_Efimov.Forms
{
    partial class ChangePassword
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
            this.confirmPassTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oldPassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmPassTb
            // 
            this.confirmPassTb.Location = new System.Drawing.Point(406, 243);
            this.confirmPassTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPassTb.Name = "confirmPassTb";
            this.confirmPassTb.Size = new System.Drawing.Size(216, 22);
            this.confirmPassTb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(187, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подтверждение пароля";
            // 
            // newPassTb
            // 
            this.newPassTb.Location = new System.Drawing.Point(406, 215);
            this.newPassTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(216, 22);
            this.newPassTb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(271, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Новый пароль";
            // 
            // oldPassTb
            // 
            this.oldPassTb.Location = new System.Drawing.Point(406, 189);
            this.oldPassTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPassTb.Name = "oldPassTb";
            this.oldPassTb.Size = new System.Drawing.Size(216, 22);
            this.oldPassTb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Старый пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldPassTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPassTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newPassTb);
            this.Controls.Add(this.label5);
            this.Name = "ChangePassword";
            this.Text = "m1nge\'s Restaurant Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirmPassTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldPassTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}