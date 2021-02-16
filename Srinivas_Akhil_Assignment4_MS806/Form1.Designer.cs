
namespace Srinivas_Akhil_Assignment4_MS806
{
    partial class Primaryform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primaryform));
            this.BrandsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TwoYearsWarrantyRadioButton = new System.Windows.Forms.RadioButton();
            this.OneYearWarrantyRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoThanksRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RatePanel = new System.Windows.Forms.Panel();
            this.AddToBasketButton = new System.Windows.Forms.Button();
            this.PriceDisplayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewBasketLabel = new System.Windows.Forms.Label();
            this.BasketPanel = new System.Windows.Forms.Panel();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.WatchBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warrantie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchOrderButton = new System.Windows.Forms.Button();
            this.OrderingPanel = new System.Windows.Forms.Panel();
            this.StockAvailableButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsNumericUpDown)).BeginInit();
            this.BasketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.OrderingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrandsListBox
            // 
            this.BrandsListBox.FormattingEnabled = true;
            this.BrandsListBox.ItemHeight = 20;
            this.BrandsListBox.Items.AddRange(new object[] {
            "Cartier\t\t€100\t",
            "Benson\t\t€97",
            "Tudor\t\t€90",
            "Omega\t\t€67",
            "Rolex\t\t€78",
            "Titan\t\t€65",
            "Gusto\t\t€85",
            "Timex\t\t€40",
            "Casio\t\t€34",
            "Fossil\t\t€55",
            "Sonata\t\t€48",
            "Tommy\t\t€60",
            "Diesel\t\t€53"});
            this.BrandsListBox.Location = new System.Drawing.Point(15, 24);
            this.BrandsListBox.Name = "BrandsListBox";
            this.BrandsListBox.Size = new System.Drawing.Size(195, 264);
            this.BrandsListBox.TabIndex = 0;
            this.BrandsListBox.SelectedIndexChanged += new System.EventHandler(this.BrandsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 20;
            this.CategoryListBox.Items.AddRange(new object[] {
            "Digital\t€15",
            "Analog\t€8",
            "Sporty\t€10",
            "Leather\t€13",
            "Hybrid\t€15"});
            this.CategoryListBox.Location = new System.Drawing.Point(12, 24);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(119, 104);
            this.CategoryListBox.TabIndex = 3;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Warranty";
            // 
            // TwoYearsWarrantyRadioButton
            // 
            this.TwoYearsWarrantyRadioButton.AutoSize = true;
            this.TwoYearsWarrantyRadioButton.Location = new System.Drawing.Point(18, 24);
            this.TwoYearsWarrantyRadioButton.Name = "TwoYearsWarrantyRadioButton";
            this.TwoYearsWarrantyRadioButton.Size = new System.Drawing.Size(130, 24);
            this.TwoYearsWarrantyRadioButton.TabIndex = 5;
            this.TwoYearsWarrantyRadioButton.Text = "2 Years (€20)";
            this.TwoYearsWarrantyRadioButton.UseVisualStyleBackColor = true;
            this.TwoYearsWarrantyRadioButton.CheckedChanged += new System.EventHandler(this.TwoYearsWarrantyRadioButton_CheckedChanged);
            // 
            // OneYearWarrantyRadioButton
            // 
            this.OneYearWarrantyRadioButton.AutoSize = true;
            this.OneYearWarrantyRadioButton.Checked = true;
            this.OneYearWarrantyRadioButton.Location = new System.Drawing.Point(18, 54);
            this.OneYearWarrantyRadioButton.Name = "OneYearWarrantyRadioButton";
            this.OneYearWarrantyRadioButton.Size = new System.Drawing.Size(122, 24);
            this.OneYearWarrantyRadioButton.TabIndex = 6;
            this.OneYearWarrantyRadioButton.TabStop = true;
            this.OneYearWarrantyRadioButton.Text = "1 Year (€12)";
            this.OneYearWarrantyRadioButton.UseVisualStyleBackColor = true;
            this.OneYearWarrantyRadioButton.CheckedChanged += new System.EventHandler(this.OneYearWarrantyRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NoThanksRadioButton);
            this.panel1.Controls.Add(this.TwoYearsWarrantyRadioButton);
            this.panel1.Controls.Add(this.OneYearWarrantyRadioButton);
            this.panel1.Location = new System.Drawing.Point(270, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 127);
            this.panel1.TabIndex = 7;
            // 
            // NoThanksRadioButton
            // 
            this.NoThanksRadioButton.AutoSize = true;
            this.NoThanksRadioButton.Location = new System.Drawing.Point(18, 84);
            this.NoThanksRadioButton.Name = "NoThanksRadioButton";
            this.NoThanksRadioButton.Size = new System.Drawing.Size(110, 24);
            this.NoThanksRadioButton.TabIndex = 20;
            this.NoThanksRadioButton.Text = "No Thanks";
            this.NoThanksRadioButton.UseVisualStyleBackColor = true;
            this.NoThanksRadioButton.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CategoryListBox);
            this.panel2.Location = new System.Drawing.Point(270, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 148);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Watch Brands";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BrandsListBox);
            this.panel4.Location = new System.Drawing.Point(16, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 310);
            this.panel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price";
            // 
            // RatePanel
            // 
            this.RatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RatePanel.Controls.Add(this.AddToBasketButton);
            this.RatePanel.Controls.Add(this.PriceDisplayLabel);
            this.RatePanel.Controls.Add(this.label6);
            this.RatePanel.Enabled = false;
            this.RatePanel.Location = new System.Drawing.Point(471, 86);
            this.RatePanel.Name = "RatePanel";
            this.RatePanel.Size = new System.Drawing.Size(236, 143);
            this.RatePanel.TabIndex = 13;
            // 
            // AddToBasketButton
            // 
            this.AddToBasketButton.Location = new System.Drawing.Point(28, 83);
            this.AddToBasketButton.Name = "AddToBasketButton";
            this.AddToBasketButton.Size = new System.Drawing.Size(148, 36);
            this.AddToBasketButton.TabIndex = 4;
            this.AddToBasketButton.Text = "&Add to Basket";
            this.AddToBasketButton.UseVisualStyleBackColor = true;
            this.AddToBasketButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // PriceDisplayLabel
            // 
            this.PriceDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceDisplayLabel.Location = new System.Drawing.Point(113, 18);
            this.PriceDisplayLabel.Name = "PriceDisplayLabel";
            this.PriceDisplayLabel.Size = new System.Drawing.Size(100, 32);
            this.PriceDisplayLabel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // UnitsNumericUpDown
            // 
            this.UnitsNumericUpDown.Location = new System.Drawing.Point(114, 9);
            this.UnitsNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.UnitsNumericUpDown.Name = "UnitsNumericUpDown";
            this.UnitsNumericUpDown.Size = new System.Drawing.Size(99, 26);
            this.UnitsNumericUpDown.TabIndex = 3;
            this.UnitsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnitsNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "No of Units:";
            // 
            // ViewBasketLabel
            // 
            this.ViewBasketLabel.AutoSize = true;
            this.ViewBasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBasketLabel.Location = new System.Drawing.Point(36, 358);
            this.ViewBasketLabel.Name = "ViewBasketLabel";
            this.ViewBasketLabel.Size = new System.Drawing.Size(120, 22);
            this.ViewBasketLabel.TabIndex = 14;
            this.ViewBasketLabel.Text = "View Basket";
            // 
            // BasketPanel
            // 
            this.BasketPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BasketPanel.Controls.Add(this.PlaceOrderButton);
            this.BasketPanel.Controls.Add(this.OrderIDLabel);
            this.BasketPanel.Controls.Add(this.label9);
            this.BasketPanel.Controls.Add(this.RemoveButton);
            this.BasketPanel.Controls.Add(this.OrderDataGridView);
            this.BasketPanel.Location = new System.Drawing.Point(26, 369);
            this.BasketPanel.Name = "BasketPanel";
            this.BasketPanel.Size = new System.Drawing.Size(789, 248);
            this.BasketPanel.TabIndex = 15;
            this.BasketPanel.Visible = false;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(607, 20);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(148, 36);
            this.PlaceOrderButton.TabIndex = 8;
            this.PlaceOrderButton.Text = "&Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderIDLabel.Location = new System.Drawing.Point(123, 20);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(116, 20);
            this.OrderIDLabel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Order ID:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(424, 20);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(148, 36);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "&Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WatchBrand,
            this.Category,
            this.Warrantie,
            this.Units,
            this.Price});
            this.OrderDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderDataGridView.Location = new System.Drawing.Point(15, 70);
            this.OrderDataGridView.MultiSelect = false;
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowHeadersWidth = 62;
            this.OrderDataGridView.RowTemplate.Height = 28;
            this.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGridView.Size = new System.Drawing.Size(767, 159);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // WatchBrand
            // 
            this.WatchBrand.Frozen = true;
            this.WatchBrand.HeaderText = "Watch Brand";
            this.WatchBrand.MinimumWidth = 8;
            this.WatchBrand.Name = "WatchBrand";
            this.WatchBrand.ReadOnly = true;
            this.WatchBrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WatchBrand.Width = 115;
            // 
            // Category
            // 
            this.Category.Frozen = true;
            this.Category.HeaderText = "Watch Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.Width = 115;
            // 
            // Warrantie
            // 
            this.Warrantie.Frozen = true;
            this.Warrantie.HeaderText = "Warranty";
            this.Warrantie.MinimumWidth = 8;
            this.Warrantie.Name = "Warrantie";
            this.Warrantie.Width = 90;
            // 
            // Units
            // 
            this.Units.Frozen = true;
            this.Units.HeaderText = "No of Units";
            this.Units.MinimumWidth = 8;
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Units.Width = 70;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 75;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(736, 304);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(148, 36);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(736, 100);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(148, 60);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "E&xit and Generate Sales Report";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.UnitsNumericUpDown);
            this.panel3.Location = new System.Drawing.Point(471, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 41);
            this.panel3.TabIndex = 19;
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.Location = new System.Drawing.Point(736, 29);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(148, 57);
            this.SearchOrderButton.TabIndex = 20;
            this.SearchOrderButton.Text = "Search &Order Details";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // OrderingPanel
            // 
            this.OrderingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderingPanel.Controls.Add(this.panel3);
            this.OrderingPanel.Controls.Add(this.label1);
            this.OrderingPanel.Controls.Add(this.RatePanel);
            this.OrderingPanel.Controls.Add(this.label4);
            this.OrderingPanel.Controls.Add(this.panel4);
            this.OrderingPanel.Controls.Add(this.label2);
            this.OrderingPanel.Controls.Add(this.panel2);
            this.OrderingPanel.Controls.Add(this.label3);
            this.OrderingPanel.Controls.Add(this.panel1);
            this.OrderingPanel.Location = new System.Drawing.Point(10, 13);
            this.OrderingPanel.Name = "OrderingPanel";
            this.OrderingPanel.Size = new System.Drawing.Size(717, 345);
            this.OrderingPanel.TabIndex = 21;
            // 
            // StockAvailableButton
            // 
            this.StockAvailableButton.Location = new System.Drawing.Point(736, 175);
            this.StockAvailableButton.Name = "StockAvailableButton";
            this.StockAvailableButton.Size = new System.Drawing.Size(148, 57);
            this.StockAvailableButton.TabIndex = 22;
            this.StockAvailableButton.Text = "E&xisting Stock Details";
            this.StockAvailableButton.UseVisualStyleBackColor = true;
            this.StockAvailableButton.Click += new System.EventHandler(this.StockAvailableButton_Click);
            // 
            // toolTip1
            // 
           // 
            // Primaryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 658);
            this.Controls.Add(this.StockAvailableButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OrderingPanel);
            this.Controls.Add(this.SearchOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ViewBasketLabel);
            this.Controls.Add(this.BasketPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Primaryform";
            this.Text = "Weir & Sons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.RatePanel.ResumeLayout(false);
            this.RatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsNumericUpDown)).EndInit();
            this.BasketPanel.ResumeLayout(false);
            this.BasketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.OrderingPanel.ResumeLayout(false);
            this.OrderingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BrandsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton TwoYearsWarrantyRadioButton;
        private System.Windows.Forms.RadioButton OneYearWarrantyRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RatePanel;
        private System.Windows.Forms.Button AddToBasketButton;
        private System.Windows.Forms.NumericUpDown UnitsNumericUpDown;
        private System.Windows.Forms.Label PriceDisplayLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ViewBasketLabel;
        private System.Windows.Forms.Panel BasketPanel;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton NoThanksRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn WatchBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warrantie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button SearchOrderButton;
        private System.Windows.Forms.Panel OrderingPanel;
        private System.Windows.Forms.Button StockAvailableButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

