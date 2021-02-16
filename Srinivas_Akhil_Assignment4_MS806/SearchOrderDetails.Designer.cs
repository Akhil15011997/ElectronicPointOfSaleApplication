
namespace Srinivas_Akhil_Assignment4_MS806
{
    partial class SearchOrderDetails
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OrderDetailsListBox = new System.Windows.Forms.ListBox();
            this.SearchOrderDetailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(6, 17);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(192, 26);
            this.InputTextBox.TabIndex = 0;
            // 
            // OrderDetailsListBox
            // 
            this.OrderDetailsListBox.FormattingEnabled = true;
            this.OrderDetailsListBox.ItemHeight = 20;
            this.OrderDetailsListBox.Location = new System.Drawing.Point(6, 67);
            this.OrderDetailsListBox.Name = "OrderDetailsListBox";
            this.OrderDetailsListBox.Size = new System.Drawing.Size(377, 164);
            this.OrderDetailsListBox.TabIndex = 1;
            // 
            // SearchOrderDetailsButton
            // 
            this.SearchOrderDetailsButton.Location = new System.Drawing.Point(215, 12);
            this.SearchOrderDetailsButton.Name = "SearchOrderDetailsButton";
            this.SearchOrderDetailsButton.Size = new System.Drawing.Size(168, 36);
            this.SearchOrderDetailsButton.TabIndex = 5;
            this.SearchOrderDetailsButton.Text = "Search Order Details";
            this.SearchOrderDetailsButton.UseVisualStyleBackColor = true;
            this.SearchOrderDetailsButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(215, 250);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(168, 36);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "&Back";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 310);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchOrderDetailsButton);
            this.Controls.Add(this.OrderDetailsListBox);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchOrderDetails";
            this.Text = "SearchOrderDetails";
            this.Load += new System.EventHandler(this.SearchOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchOrderDetailsButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox InputTextBox;
        public System.Windows.Forms.ListBox OrderDetailsListBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}