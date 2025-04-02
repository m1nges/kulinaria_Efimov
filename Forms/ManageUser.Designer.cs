namespace kulinaria_Efimov.Forms
{
    partial class ManageUser
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
            this.userInfoDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeDateOfBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.changeAddressTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeNumTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.changeLastNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changePatronymicTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInfoDGV
            // 
            this.userInfoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoDGV.Location = new System.Drawing.Point(13, 13);
            this.userInfoDGV.Name = "userInfoDGV";
            this.userInfoDGV.RowHeadersWidth = 51;
            this.userInfoDGV.RowTemplate.Height = 24;
            this.userInfoDGV.Size = new System.Drawing.Size(507, 257);
            this.userInfoDGV.TabIndex = 0;
            this.userInfoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userInfoDGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.changeDateOfBirthDtp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changeAddressTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.changeNumTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.changeLastNameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.changePatronymicTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.changeNameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(557, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пользователя";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Шеф-Повар"});
            this.comboBox1.Location = new System.Drawing.Point(131, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(66, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Роль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сменить роль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // changeDateOfBirthDtp
            // 
            this.changeDateOfBirthDtp.Enabled = false;
            this.changeDateOfBirthDtp.Location = new System.Drawing.Point(131, 113);
            this.changeDateOfBirthDtp.Margin = new System.Windows.Forms.Padding(4);
            this.changeDateOfBirthDtp.Name = "changeDateOfBirthDtp";
            this.changeDateOfBirthDtp.Size = new System.Drawing.Size(150, 22);
            this.changeDateOfBirthDtp.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата рождения";
            // 
            // changeAddressTb
            // 
            this.changeAddressTb.Enabled = false;
            this.changeAddressTb.Location = new System.Drawing.Point(131, 172);
            this.changeAddressTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeAddressTb.Name = "changeAddressTb";
            this.changeAddressTb.Size = new System.Drawing.Size(149, 22);
            this.changeAddressTb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(66, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Адрес";
            // 
            // changeNumTb
            // 
            this.changeNumTb.Enabled = false;
            this.changeNumTb.Location = new System.Drawing.Point(131, 144);
            this.changeNumTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeNumTb.Name = "changeNumTb";
            this.changeNumTb.Size = new System.Drawing.Size(149, 22);
            this.changeNumTb.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Телефон";
            // 
            // changeLastNameTb
            // 
            this.changeLastNameTb.Enabled = false;
            this.changeLastNameTb.Location = new System.Drawing.Point(131, 82);
            this.changeLastNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLastNameTb.Name = "changeLastNameTb";
            this.changeLastNameTb.Size = new System.Drawing.Size(149, 22);
            this.changeLastNameTb.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Фамилия*";
            // 
            // changePatronymicTb
            // 
            this.changePatronymicTb.Enabled = false;
            this.changePatronymicTb.Location = new System.Drawing.Point(131, 54);
            this.changePatronymicTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePatronymicTb.Name = "changePatronymicTb";
            this.changePatronymicTb.Size = new System.Drawing.Size(149, 22);
            this.changePatronymicTb.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Отчество";
            // 
            // changeNameTb
            // 
            this.changeNameTb.Enabled = false;
            this.changeNameTb.Location = new System.Drawing.Point(131, 27);
            this.changeNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeNameTb.Name = "changeNameTb";
            this.changeNameTb.Size = new System.Drawing.Size(149, 22);
            this.changeNameTb.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Имя*";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 39;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 40;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 378);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userInfoDGV);
            this.Name = "ManageUser";
            this.Text = "m1nge\'s Restaurant Manage Users";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userInfoDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker changeDateOfBirthDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changeAddressTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changeNumTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox changeLastNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox changePatronymicTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}