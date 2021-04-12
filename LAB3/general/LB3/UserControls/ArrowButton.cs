using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LB3.StudName
{
    public partial class ArrowButton : ClickmaticButton
    {
        public ArrowButton()
        {
            InitializeComponent();
            // Отключение фокуса ввода
            this.SetStyle(ControlStyles.Selectable, false);
        }

        public ArrowButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            // Отключение фокуса ввода
            this.SetStyle(ControlStyles.Selectable, false);
        }
        System.Windows.Forms.ScrollButton scrollButton = System.Windows.Forms.ScrollButton.Right;
        public System.Windows.Forms.ScrollButton ScrollButton
        {
            set
            {
                scrollButton = value;
                this.Invalidate(); // Перерисовать
            }
            get { return scrollButton; }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);   // Отправляем к базовому методу
            Graphics gr = pevent.Graphics;
            bool mouseInButton = this.Capture &&
            this.ClientRectangle.Contains(this.PointToClient(MousePosition));
            System.Windows.Forms.ButtonState buttonState =
                !this.Enabled ? ButtonState.Inactive
                : (mouseInButton ? ButtonState.Pushed
                : ButtonState.Normal);
            ControlPaint.DrawScrollButton(gr, this.ClientRectangle,
                scrollButton, // В какую сторону рисовать стрелку
                buttonState); // Каким стилем рисовать
        }
        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            this.Invalidate(); // Инициировать перерисовку
        }
    }    
}
