﻿
namespace LB3.StudName.ChildrenForms
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericScan2 = new LB3.StudName.NumericScan(this.components);
            this.numericScan1 = new LB3.StudName.NumericScan(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.TextChanged += new System.EventHandler(this.NumericScanOnValueChanged);
            // 
            // numericScan2
            // 
            this.numericScan2.DecimalPlaces = 0;
            this.numericScan2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericScan2.Location = new System.Drawing.Point(288, 121);
            this.numericScan2.Margin = new System.Windows.Forms.Padding(5);
            this.numericScan2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericScan2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan2.Name = "numericScan2";
            this.numericScan2.Size = new System.Drawing.Size(216, 55);
            this.numericScan2.TabIndex = 1;
            this.numericScan2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan2.ValueChanged += new System.EventHandler(this.NumericScanOnValueChanged);
            this.numericScan2.Load += new System.EventHandler(this.numericScan2_Load);
            // 
            // numericScan1
            // 
            this.numericScan1.DecimalPlaces = 0;
            this.numericScan1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericScan1.Location = new System.Drawing.Point(51, 121);
            this.numericScan1.Margin = new System.Windows.Forms.Padding(5);
            this.numericScan1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericScan1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan1.Name = "numericScan1";
            this.numericScan1.Size = new System.Drawing.Size(192, 55);
            this.numericScan1.TabIndex = 0;
            this.numericScan1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericScan1.ValueChanged += new System.EventHandler(this.NumericScanOnValueChanged);
            this.numericScan1.Load += new System.EventHandler(this.numericScan1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сложение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вычитание";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericScan2);
            this.Controls.Add(this.numericScan1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericScan numericScan1;
        private NumericScan numericScan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}