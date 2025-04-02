namespace kulinaria_Efimov.Forms
{
    partial class FiltByProductsForm
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
            this.productFiltrDgv = new System.Windows.Forms.DataGridView();
            this.productFiltrDgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFiltrDgv_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFiltrDgv_Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productFiltDgv_Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFiltDgv_Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFiltDgv_Carbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showDishesDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.includeSearchBtn = new System.Windows.Forms.Button();
            this.notIncludeSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productFiltrDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDishesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // productFiltrDgv
            // 
            this.productFiltrDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productFiltrDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productFiltrDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productFiltrDgv_id,
            this.productFiltrDgv_ProductName,
            this.productFiltrDgv_Include,
            this.productFiltDgv_Protein,
            this.productFiltDgv_Fat,
            this.productFiltDgv_Carbs});
            this.productFiltrDgv.Location = new System.Drawing.Point(16, 67);
            this.productFiltrDgv.Name = "productFiltrDgv";
            this.productFiltrDgv.Size = new System.Drawing.Size(270, 371);
            this.productFiltrDgv.TabIndex = 0;
            // 
            // productFiltrDgv_id
            // 
            this.productFiltrDgv_id.HeaderText = "id";
            this.productFiltrDgv_id.Name = "productFiltrDgv_id";
            // 
            // productFiltrDgv_ProductName
            // 
            this.productFiltrDgv_ProductName.HeaderText = "Название";
            this.productFiltrDgv_ProductName.Name = "productFiltrDgv_ProductName";
            // 
            // productFiltrDgv_Include
            // 
            this.productFiltrDgv_Include.HeaderText = "Включить в поиск";
            this.productFiltrDgv_Include.Name = "productFiltrDgv_Include";
            // 
            // productFiltDgv_Protein
            // 
            this.productFiltDgv_Protein.HeaderText = "Белок";
            this.productFiltDgv_Protein.Name = "productFiltDgv_Protein";
            // 
            // productFiltDgv_Fat
            // 
            this.productFiltDgv_Fat.HeaderText = "Жиры";
            this.productFiltDgv_Fat.Name = "productFiltDgv_Fat";
            // 
            // productFiltDgv_Carbs
            // 
            this.productFiltDgv_Carbs.HeaderText = "Углеводы";
            this.productFiltDgv_Carbs.Name = "productFiltDgv_Carbs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продукты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поиск по критериям";
            // 
            // showDishesDgv
            // 
            this.showDishesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDishesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDishesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.showDishesDgv.Location = new System.Drawing.Point(309, 67);
            this.showDishesDgv.Margin = new System.Windows.Forms.Padding(2);
            this.showDishesDgv.Name = "showDishesDgv";
            this.showDishesDgv.RowHeadersWidth = 51;
            this.showDishesDgv.RowTemplate.Height = 24;
            this.showDishesDgv.Size = new System.Drawing.Size(652, 371);
            this.showDishesDgv.TabIndex = 7;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // includeSearchBtn
            // 
            this.includeSearchBtn.Location = new System.Drawing.Point(309, 454);
            this.includeSearchBtn.Name = "includeSearchBtn";
            this.includeSearchBtn.Size = new System.Drawing.Size(221, 55);
            this.includeSearchBtn.TabIndex = 9;
            this.includeSearchBtn.Text = "Поиск, вкл. выбранные продукты";
            this.includeSearchBtn.UseVisualStyleBackColor = true;
            this.includeSearchBtn.Click += new System.EventHandler(this.includeSearchBtn_Click);
            // 
            // notIncludeSearchBtn
            // 
            this.notIncludeSearchBtn.Location = new System.Drawing.Point(600, 454);
            this.notIncludeSearchBtn.Name = "notIncludeSearchBtn";
            this.notIncludeSearchBtn.Size = new System.Drawing.Size(221, 55);
            this.notIncludeSearchBtn.TabIndex = 10;
            this.notIncludeSearchBtn.Text = "Поиск, искл. выбранные продукты";
            this.notIncludeSearchBtn.UseVisualStyleBackColor = true;
            this.notIncludeSearchBtn.Click += new System.EventHandler(this.notIncludeSearchBtn_Click);
            // 
            // FiltByProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 584);
            this.Controls.Add(this.notIncludeSearchBtn);
            this.Controls.Add(this.includeSearchBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showDishesDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productFiltrDgv);
            this.Name = "FiltByProductsForm";
            this.Text = "FiltByProductsForm";
            this.Load += new System.EventHandler(this.FiltByProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productFiltrDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDishesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productFiltrDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView showDishesDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFiltrDgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFiltrDgv_ProductName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn productFiltrDgv_Include;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFiltDgv_Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFiltDgv_Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFiltDgv_Carbs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button includeSearchBtn;
        private System.Windows.Forms.Button notIncludeSearchBtn;
    }
}