
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
            this.btnLeft = new LB3.StudName.ArrowButton(this.components);
            this.btnRight = new LB3.StudName.ArrowButton(this.components);
            this.txtBox = new System.Windows.Forms.TextBox();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ScrollButton = System.Windows.Forms.ScrollButton.Left;
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "arrowButton1";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(0, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.ScrollButton = System.Windows.Forms.ScrollButton.Right;
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "arrowButton2";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(0, 0);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextChanged += new System.EventHandler(this.TextBoxOnTextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxOnKeyDown);

        }

        #endregion

        private ArrowButton btnLeft;
        private ArrowButton btnRight;
        private System.Windows.Forms.TextBox txtBox;
    }
}
