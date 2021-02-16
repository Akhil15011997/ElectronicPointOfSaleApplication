
namespace Srinivas_Akhil_Assignment4_MS806
{
    partial class StockAvailability
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
            this.StockAvailabilityListBox = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockAvailabilityListBox
            // 
            this.StockAvailabilityListBox.FormattingEnabled = true;
            this.StockAvailabilityListBox.ItemHeight = 20;
            this.StockAvailabilityListBox.Location = new System.Drawing.Point(9, 25);
            this.StockAvailabilityListBox.Name = "StockAvailabilityListBox";
            this.StockAvailabilityListBox.Size = new System.Drawing.Size(739, 364);
            this.StockAvailabilityListBox.TabIndex = 0;
           // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(596, 434);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(543, 402);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(184, 36);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "&Back";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // StockAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 446);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.StockAvailabilityListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockAvailability";
            this.Text = "StockAvailability";
            this.Load += new System.EventHandler(this.StockAvailability_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StockAvailabilityListBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Exitbutton;
    }
}