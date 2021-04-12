
namespace LB3.StudName
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClickGen = new LB3.StudName.ClickmaticButton(this.components);
            this.lblTickCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickGen
            // 
            this.btnClickGen.Location = new System.Drawing.Point(144, 97);
            this.btnClickGen.Name = "btnClickGen";
            this.btnClickGen.Size = new System.Drawing.Size(72, 31);
            this.btnClickGen.TabIndex = 0;
            this.btnClickGen.Text = "ClickGen";
            this.btnClickGen.UseVisualStyleBackColor = true;
            this.btnClickGen.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // lblTickCount
            // 
            this.lblTickCount.AutoSize = true;
            this.lblTickCount.Location = new System.Drawing.Point(124, 64);
            this.lblTickCount.Name = "lblTickCount";
            this.lblTickCount.Size = new System.Drawing.Size(35, 13);
            this.lblTickCount.TabIndex = 1;
            this.lblTickCount.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTickCount);
            this.Controls.Add(this.btnClickGen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ClickmaticButton btnClickGen;
        private System.Windows.Forms.Label lblTickCount;
        private System.Windows.Forms.Button button1;
    }
}