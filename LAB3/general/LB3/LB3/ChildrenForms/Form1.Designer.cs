
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
            this.clickmaticButton1 = new LB3.StudName.ClickmaticButton(this.components);
            this.SuspendLayout();
            // 
            // clickmaticButton1
            // 
            this.clickmaticButton1.Location = new System.Drawing.Point(96, 44);
            this.clickmaticButton1.Name = "clickmaticButton1";
            this.clickmaticButton1.Size = new System.Drawing.Size(75, 23);
            this.clickmaticButton1.TabIndex = 0;
            this.clickmaticButton1.Text = "clickmaticButton1";
            this.clickmaticButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickmaticButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ClickmaticButton clickmaticButton1;
    }
}