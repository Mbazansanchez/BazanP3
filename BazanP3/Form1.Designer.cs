
using System;

namespace BazanP3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNumItems = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.TxbPrint = new System.Windows.Forms.TextBox();
            this.CBLogo = new System.Windows.Forms.CheckBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.TxbNumColor = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxbOrderSummary = new System.Windows.Forms.TextBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.GBItemType = new System.Windows.Forms.GroupBox();
            this.RadPen = new System.Windows.Forms.RadioButton();
            this.RadMug = new System.Windows.Forms.RadioButton();
            this.RadUSBStick = new System.Windows.Forms.RadioButton();
            this.GBItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumItems
            // 
            this.lblNumItems.AutoSize = true;
            this.lblNumItems.Location = new System.Drawing.Point(26, 40);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(97, 15);
            this.lblNumItems.TabIndex = 0;
            this.lblNumItems.Text = "Number of Items";
            this.lblNumItems.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-865, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // TxbNumItems
            // 
            this.TxbNumItems.Location = new System.Drawing.Point(130, 40);
            this.TxbNumItems.Name = "TxbNumItems";
            this.TxbNumItems.Size = new System.Drawing.Size(100, 23);
            this.TxbNumItems.TabIndex = 2;
            this.TxbNumItems.TextChanged += new System.EventHandler(this.TxbNumItems_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(26, 198);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(117, 15);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Text to engrave/print";
            // 
            // TxbPrint
            // 
            this.TxbPrint.Location = new System.Drawing.Point(26, 217);
            this.TxbPrint.Multiline = true;
            this.TxbPrint.Name = "TxbPrint";
            this.TxbPrint.Size = new System.Drawing.Size(263, 23);
            this.TxbPrint.TabIndex = 8;
            this.TxbPrint.TextChanged += new System.EventHandler(this.TxbPrint_TextChanged);
            // 
            // CBLogo
            // 
            this.CBLogo.AutoSize = true;
            this.CBLogo.Location = new System.Drawing.Point(26, 247);
            this.CBLogo.Name = "CBLogo";
            this.CBLogo.Size = new System.Drawing.Size(146, 19);
            this.CBLogo.TabIndex = 9;
            this.CBLogo.Text = "Would you like a logo?";
            this.CBLogo.UseVisualStyleBackColor = true;
            this.CBLogo.CheckedChanged += new System.EventHandler(this.CBLogo_CheckedChanged);
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(26, 273);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(170, 15);
            this.lblNumColors.TabIndex = 10;
            this.lblNumColors.Text = "How many colors for the logo?";
            this.lblNumColors.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxbNumColor
            // 
            this.TxbNumColor.Enabled = false;
            this.TxbNumColor.Location = new System.Drawing.Point(202, 270);
            this.TxbNumColor.Name = "TxbNumColor";
            this.TxbNumColor.Size = new System.Drawing.Size(100, 23);
            this.TxbNumColor.TabIndex = 11;
            this.TxbNumColor.TextChanged += new System.EventHandler(this.TxbNumColor_TextChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(26, 380);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 12;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(239, 380);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxbOrderSummary
            // 
            this.TxbOrderSummary.Location = new System.Drawing.Point(26, 333);
            this.TxbOrderSummary.Multiline = true;
            this.TxbOrderSummary.Name = "TxbOrderSummary";
            this.TxbOrderSummary.ReadOnly = true;
            this.TxbOrderSummary.Size = new System.Drawing.Size(288, 41);
            this.TxbOrderSummary.TabIndex = 14;
            this.TxbOrderSummary.TextChanged += new System.EventHandler(this.TxbOrderSummary_TextChanged);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(128, 315);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(91, 15);
            this.lblOrderSummary.TabIndex = 15;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // GBItemType
            // 
            this.GBItemType.Controls.Add(this.RadPen);
            this.GBItemType.Controls.Add(this.RadMug);
            this.GBItemType.Controls.Add(this.RadUSBStick);
            this.GBItemType.Location = new System.Drawing.Point(130, 69);
            this.GBItemType.Name = "GBItemType";
            this.GBItemType.Size = new System.Drawing.Size(200, 100);
            this.GBItemType.TabIndex = 16;
            this.GBItemType.TabStop = false;
            this.GBItemType.Text = "Item Type";
            // 
            // RadPen
            // 
            this.RadPen.AutoSize = true;
            this.RadPen.Location = new System.Drawing.Point(7, 75);
            this.RadPen.Name = "RadPen";
            this.RadPen.Size = new System.Drawing.Size(45, 19);
            this.RadPen.TabIndex = 2;
            this.RadPen.TabStop = true;
            this.RadPen.Text = "Pen";
            this.RadPen.UseVisualStyleBackColor = true;
            this.RadPen.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RadMug
            // 
            this.RadMug.AutoSize = true;
            this.RadMug.Location = new System.Drawing.Point(7, 49);
            this.RadMug.Name = "RadMug";
            this.RadMug.Size = new System.Drawing.Size(50, 19);
            this.RadMug.TabIndex = 1;
            this.RadMug.TabStop = true;
            this.RadMug.Text = "Mug";
            this.RadMug.UseVisualStyleBackColor = true;
            this.RadMug.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadUSBStick
            // 
            this.RadUSBStick.AutoSize = true;
            this.RadUSBStick.Location = new System.Drawing.Point(7, 23);
            this.RadUSBStick.Name = "RadUSBStick";
            this.RadUSBStick.Size = new System.Drawing.Size(46, 19);
            this.RadUSBStick.TabIndex = 0;
            this.RadUSBStick.TabStop = true;
            this.RadUSBStick.Text = "USB";
            this.RadUSBStick.UseVisualStyleBackColor = true;
            this.RadUSBStick.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.GBItemType);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.TxbOrderSummary);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxbNumColor);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.CBLogo);
            this.Controls.Add(this.TxbPrint);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.TxbNumItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBItemType.ResumeLayout(false);
            this.GBItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNumItems;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox TxbPrint;
        private System.Windows.Forms.CheckBox CBLogo;
        private System.Windows.Forms.Label lblNumColors;
        private System.Windows.Forms.TextBox TxbNumColor;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxbOrderSummary;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.GroupBox GBItemType;
        private System.Windows.Forms.RadioButton RadPen;
        private System.Windows.Forms.RadioButton RadMug;
        private System.Windows.Forms.RadioButton RadUSBStick;
    }


  
}

