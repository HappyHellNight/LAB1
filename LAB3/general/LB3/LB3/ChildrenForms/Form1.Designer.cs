
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
            this.btnClickGen.AutoSize = true;
            this.btnClickGen.Location = new System.Drawing.Point(122, 126);
            this.btnClickGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClickGen.Name = "btnClickGen";
            this.btnClickGen.Size = new System.Drawing.Size(60, 23);
            this.btnClickGen.TabIndex = 0;
            this.btnClickGen.Text = "ClickGen";
            this.btnClickGen.UseVisualStyleBackColor = true;
            this.btnClickGen.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // lblTickCount
            // 
            this.lblTickCount.AutoSize = true;
            this.lblTickCount.Location = new System.Drawing.Point(93, 66);
            this.lblTickCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTickCount.Name = "lblTickCount";
            this.lblTickCount.Size = new System.Drawing.Size(35, 13);
            this.lblTickCount.TabIndex = 1;
            this.lblTickCount.Text = "label1";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(36, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClickGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTickCount);
            this.Controls.Add(this.btnClickGen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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