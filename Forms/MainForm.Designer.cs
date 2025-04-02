namespace kulinaria_Efimov
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрРецептовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDish_label = new System.Windows.Forms.Label();
            this.chooseCat_label = new System.Windows.Forms.Label();
            this.searchDish_tb = new System.Windows.Forms.TextBox();
            this.chooseCat_comboB = new System.Windows.Forms.ComboBox();
            this.sostBluda_label = new System.Windows.Forms.Label();
            this.lblNameOfBludo = new System.Windows.Forms.Label();
            this.listBoxSostavBluda = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem,
            this.продуктToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.fIOToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрБлюдToolStripMenuItem,
            this.добавитьБлюдаToolStripMenuItem,
            this.удалитьБлюдоToolStripMenuItem,
            this.поискПоКритериямToolStripMenuItem});
            this.блюдаToolStripMenuItem.Image = global::kulinaria_Efimov.Properties.Resources.dish;
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            // 
            // просмотрБлюдToolStripMenuItem
            // 
            this.просмотрБлюдToolStripMenuItem.Name = "просмотрБлюдToolStripMenuItem";
            this.просмотрБлюдToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.просмотрБлюдToolStripMenuItem.Text = "Просмотр блюд";
            // 
            // добавитьБлюдаToolStripMenuItem
            // 
            this.добавитьБлюдаToolStripMenuItem.Name = "добавитьБлюдаToolStripMenuItem";
            this.добавитьБлюдаToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.добавитьБлюдаToolStripMenuItem.Text = "Добавить блюдо";
            this.добавитьБлюдаToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлюдаToolStripMenuItem_Click);
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            this.удалитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.удалитьБлюдоToolStripMenuItem_Click);
            // 
            // поискПоКритериямToolStripMenuItem
            // 
            this.поискПоКритериямToolStripMenuItem.Name = "поискПоКритериямToolStripMenuItem";
            this.поискПоКритериямToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.поискПоКритериямToolStripMenuItem.Text = "Поиск по критериям";
            this.поискПоКритериямToolStripMenuItem.Click += new System.EventHandler(this.поискПоКритериямToolStripMenuItem_Click);
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПродуктToolStripMenuItem,
            this.просмотрПродуктовToolStripMenuItem,
            this.удалитьПродуктToolStripMenuItem});
            this.продуктToolStripMenuItem.Image = global::kulinaria_Efimov.Properties.Resources.diet;
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // добавитьПродуктToolStripMenuItem
            // 
            this.добавитьПродуктToolStripMenuItem.Name = "добавитьПродуктToolStripMenuItem";
            this.добавитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьПродуктToolStripMenuItem.Text = "Добавить продукт";
            this.добавитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.добавитьПродуктToolStripMenuItem_Click);
            // 
            // просмотрПродуктовToolStripMenuItem
            // 
            this.просмотрПродуктовToolStripMenuItem.Name = "просмотрПродуктовToolStripMenuItem";
            this.просмотрПродуктовToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.просмотрПродуктовToolStripMenuItem.Text = "Просмотр продуктов";
            this.просмотрПродуктовToolStripMenuItem.Click += new System.EventHandler(this.просмотрПродуктовToolStripMenuItem_Click);
            // 
            // удалитьПродуктToolStripMenuItem
            // 
            this.удалитьПродуктToolStripMenuItem.Name = "удалитьПродуктToolStripMenuItem";
            this.удалитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.удалитьПродуктToolStripMenuItem.Text = "Удалить продукт";
            this.удалитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.удалитьПродуктToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрРецептовToolStripMenuItem});
            this.рецептToolStripMenuItem.Image = global::kulinaria_Efimov.Properties.Resources.recipe;
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            // 
            // просмотрРецептовToolStripMenuItem
            // 
            this.просмотрРецептовToolStripMenuItem.Name = "просмотрРецептовToolStripMenuItem";
            this.просмотрРецептовToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.просмотрРецептовToolStripMenuItem.Text = "Просмотр рецептов";
            this.просмотрРецептовToolStripMenuItem.Click += new System.EventHandler(this.просмотрРецептовToolStripMenuItem_Click);
            // 
            // fIOToolStripMenuItem
            // 
            this.fIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПрофильToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fIOToolStripMenuItem.Image = global::kulinaria_Efimov.Properties.Resources.profil;
            this.fIOToolStripMenuItem.Name = "fIOToolStripMenuItem";
            this.fIOToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fIOToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fIOToolStripMenuItem.Text = "FIO";
            this.fIOToolStripMenuItem.Click += new System.EventHandler(this.fIOToolStripMenuItem_Click);
            // 
            // редактироватьПрофильToolStripMenuItem
            // 
            this.редактироватьПрофильToolStripMenuItem.Name = "редактироватьПрофильToolStripMenuItem";
            this.редактироватьПрофильToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.редактироватьПрофильToolStripMenuItem.Text = "Редактировать профиль";
            this.редактироватьПрофильToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПрофильToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Visible = false;
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню";
            // 
            // searchDish_label
            // 
            this.searchDish_label.AutoSize = true;
            this.searchDish_label.Location = new System.Drawing.Point(42, 58);
            this.searchDish_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchDish_label.Name = "searchDish_label";
            this.searchDish_label.Size = new System.Drawing.Size(74, 13);
            this.searchDish_label.TabIndex = 2;
            this.searchDish_label.Text = "Поиск блюда";
            // 
            // chooseCat_label
            // 
            this.chooseCat_label.AutoSize = true;
            this.chooseCat_label.Location = new System.Drawing.Point(236, 58);
            this.chooseCat_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseCat_label.Name = "chooseCat_label";
            this.chooseCat_label.Size = new System.Drawing.Size(60, 13);
            this.chooseCat_label.TabIndex = 3;
            this.chooseCat_label.Text = "Категория";
            // 
            // searchDish_tb
            // 
            this.searchDish_tb.Location = new System.Drawing.Point(120, 57);
            this.searchDish_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchDish_tb.Name = "searchDish_tb";
            this.searchDish_tb.Size = new System.Drawing.Size(104, 20);
            this.searchDish_tb.TabIndex = 4;
            this.searchDish_tb.TextChanged += new System.EventHandler(this.searchDish_tb_TextChanged);
            // 
            // chooseCat_comboB
            // 
            this.chooseCat_comboB.FormattingEnabled = true;
            this.chooseCat_comboB.Location = new System.Drawing.Point(321, 55);
            this.chooseCat_comboB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseCat_comboB.Name = "chooseCat_comboB";
            this.chooseCat_comboB.Size = new System.Drawing.Size(92, 21);
            this.chooseCat_comboB.TabIndex = 5;
            this.chooseCat_comboB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sostBluda_label
            // 
            this.sostBluda_label.AutoSize = true;
            this.sostBluda_label.Location = new System.Drawing.Point(750, 101);
            this.sostBluda_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sostBluda_label.Name = "sostBluda_label";
            this.sostBluda_label.Size = new System.Drawing.Size(78, 13);
            this.sostBluda_label.TabIndex = 7;
            this.sostBluda_label.Text = "Состав блюда";
            // 
            // lblNameOfBludo
            // 
            this.lblNameOfBludo.AutoSize = true;
            this.lblNameOfBludo.Location = new System.Drawing.Point(848, 101);
            this.lblNameOfBludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameOfBludo.Name = "lblNameOfBludo";
            this.lblNameOfBludo.Size = new System.Drawing.Size(83, 13);
            this.lblNameOfBludo.TabIndex = 8;
            this.lblNameOfBludo.Text = "lblNameOfBludo";
            // 
            // listBoxSostavBluda
            // 
            this.listBoxSostavBluda.FormattingEnabled = true;
            this.listBoxSostavBluda.Location = new System.Drawing.Point(752, 127);
            this.listBoxSostavBluda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSostavBluda.Name = "listBoxSostavBluda";
            this.listBoxSostavBluda.Size = new System.Drawing.Size(155, 199);
            this.listBoxSostavBluda.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(9, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 274);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Картинка";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Название";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Категория";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Основа";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Вес";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Location = new System.Drawing.Point(662, 60);
            this.counterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(75, 13);
            this.counterLbl.TabIndex = 10;
            this.counterLbl.Text = "вывод кол-ва";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 364);
            this.Controls.Add(this.counterLbl);
            this.Controls.Add(this.listBoxSostavBluda);
            this.Controls.Add(this.lblNameOfBludo);
            this.Controls.Add(this.sostBluda_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chooseCat_comboB);
            this.Controls.Add(this.searchDish_tb);
            this.Controls.Add(this.chooseCat_label);
            this.Controls.Add(this.searchDish_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "m1nge\'s Restaurant Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchDish_label;
        private System.Windows.Forms.Label chooseCat_label;
        private System.Windows.Forms.TextBox searchDish_tb;
        private System.Windows.Forms.ToolStripMenuItem просмотрБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ComboBox chooseCat_comboB;
        private System.Windows.Forms.Label sostBluda_label;
        private System.Windows.Forms.Label lblNameOfBludo;
        private System.Windows.Forms.ListBox listBoxSostavBluda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрРецептовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоКритериямToolStripMenuItem;
        private System.Windows.Forms.Label counterLbl;
    }
}

