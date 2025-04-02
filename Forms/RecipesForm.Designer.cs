namespace kulinaria_Efimov.Forms
{
    partial class RecipesForm
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
            this.butBack = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.txbRecept = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxSostav = new System.Windows.Forms.ListBox();
            this.lblBlName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(38, 369);
            this.butBack.Margin = new System.Windows.Forms.Padding(2);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(68, 34);
            this.butBack.TabIndex = 17;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(492, 78);
            this.butDel.Margin = new System.Windows.Forms.Padding(2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(56, 33);
            this.butDel.TabIndex = 16;
            this.butDel.Text = "Del";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(431, 78);
            this.butEdit.Margin = new System.Windows.Forms.Padding(2);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(56, 33);
            this.butEdit.TabIndex = 15;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(370, 78);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(56, 33);
            this.butAdd.TabIndex = 14;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRight);
            this.groupBox2.Controls.Add(this.butLeft);
            this.groupBox2.Controls.Add(this.txbRecept);
            this.groupBox2.Location = new System.Drawing.Point(215, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 238);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Способ приготовления";
            // 
            // butRight
            // 
            this.butRight.Location = new System.Drawing.Point(304, 80);
            this.butRight.Margin = new System.Windows.Forms.Padding(2);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(29, 63);
            this.butRight.TabIndex = 2;
            this.butRight.Text = ">";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.Location = new System.Drawing.Point(16, 80);
            this.butLeft.Margin = new System.Windows.Forms.Padding(2);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(29, 63);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "<";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Visible = false;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // txbRecept
            // 
            this.txbRecept.Enabled = false;
            this.txbRecept.Location = new System.Drawing.Point(75, 47);
            this.txbRecept.Margin = new System.Windows.Forms.Padding(2);
            this.txbRecept.Multiline = true;
            this.txbRecept.Name = "txbRecept";
            this.txbRecept.Size = new System.Drawing.Size(211, 147);
            this.txbRecept.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxSostav);
            this.groupBox1.Location = new System.Drawing.Point(25, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингридиенты";
            // 
            // lbxSostav
            // 
            this.lbxSostav.FormattingEnabled = true;
            this.lbxSostav.Location = new System.Drawing.Point(13, 37);
            this.lbxSostav.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSostav.Name = "lbxSostav";
            this.lbxSostav.Size = new System.Drawing.Size(114, 173);
            this.lbxSostav.TabIndex = 0;
            // 
            // lblBlName
            // 
            this.lblBlName.AutoSize = true;
            this.lblBlName.Location = new System.Drawing.Point(75, 84);
            this.lblBlName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlName.Name = "lblBlName";
            this.lblBlName.Size = new System.Drawing.Size(35, 13);
            this.lblBlName.TabIndex = 11;
            this.lblBlName.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Блюдо:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Рецепты";
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 437);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBlName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipesForm";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.TextBox txbRecept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxSostav;
        private System.Windows.Forms.Label lblBlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}