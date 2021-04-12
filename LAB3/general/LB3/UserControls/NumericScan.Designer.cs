
namespace LB3.StudName
{
    partial class NumericScan
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnRight = new LB3.StudName.ArrowButton(this.components);
            this.btnLeft = new LB3.StudName.ArrowButton(this.components);
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(67, 38);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(112, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextChanged += new System.EventHandler(this.TextBoxOnTextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxOnKeyDown);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(156, 84);
            this.btnRight.Name = "btnRight";
            this.btnRight.ScrollButton = System.Windows.Forms.ScrollButton.Right;
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "arrowButton2";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(22, 84);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ScrollButton = System.Windows.Forms.ScrollButton.Left;
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "arrowButton1";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // NumericScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Name = "NumericScan";
            this.Size = new System.Drawing.Size(263, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArrowButton btnLeft;
        private ArrowButton btnRight;
        private System.Windows.Forms.TextBox txtBox;
    }
}
