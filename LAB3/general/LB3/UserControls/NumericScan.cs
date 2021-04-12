using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3.StudName
{
    public partial class NumericScan : ArrowButton
    {
        // Объявили базовые закрытые поля для открытых свойств
        int iDecimalPlaces = 0; // Количество знаков после запятой
        decimal mValue = 0;	// Значение текстового поля
        decimal mIncrement = 1; // Шаг изменения
        decimal mMinimum = 0;   // Минимальное вещественное значение
        decimal mMaximum = 100; // Максимальное вещественное значение

        // Свойства доступа к полям
        public int DecimalPlaces
        {
            get { return iDecimalPlaces; }
            set { iDecimalPlaces = value; }
        }
        public decimal Value
        {
            get { return mValue; }
            set { txtBox.Text = (mValue = value).ToString(); }
        }
        public decimal Increment
        {
            get { return mIncrement; }
            set { mIncrement = value; }
        }
        public decimal Minimum
        {
            get { return mMinimum; }
            set
            {
                // Контроль нижней границы диапазона
                if (Value < (mMinimum = value)) 
                    Value = mMinimum;
            }
        }
        public decimal Maximum
        {
            get { return mMaximum; }
            set
            {
                // Контроль верхней границы диапазона
                if (Value > (mMaximum = value)) Value = mMaximum;
            }
        }

        public NumericScan()
        {
            InitializeComponent();
        }
        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(4 * this.Font.Height,	// Ширина
          txtBox.PreferredHeight +
          SystemInformation.HorizontalScrollBarHeight);
        }
         protected override void OnResize(EventArgs e)
         {
            base.OnResize(e);

            txtBox.Location = new Point(0, 0); // В левом верхнем углу
            txtBox.Size = new Size(this.Width, txtBox.PreferredHeight);// По всей ширине
            btnLeft.Location = new Point(0, txtBox.Height); // Позиция
            btnRight.Location = new Point(this.Width / 2, txtBox.Height);// Позиция
            btnLeft.Size = btnRight.Size = new Size(this.Width / 2,
            this.Height - txtBox.Height); // Одинаковый размер
         }
        public event EventHandler ValueChanged;

        // Ввели свою функцию диспетчеризации события ValueChanged
        // изменения величины прямым вводом в текстовое поле
        protected virtual void OnValueChanged(EventArgs args)
        {
            // Последовательно проверяем выход величины за левую и правую
            // границы, и если выходит за границу, то обрезаем по границе
            Value = Math.Min(mMaximum, mValue); Value = Math.Max(mMinimum, mValue);
            // Округляет вещественный денежный тип до заданного
            // количества значащих цифр после запятой
            Value = Decimal.Round(mValue, iDecimalPlaces);

            // Генерируем событие
            if (ValueChanged != null) ValueChanged(this, args);
        }

        public NumericScan(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            // Вычисляем и устанавливаем размеры компонента
            // Четыре высоты текущего шрифта
            this.Width = 4 * this.Font.Height;
            // Предпочтительная высота текстового поля +
            // высота горизонтальных линеек прокрутки
            this.Height = txtBox.PreferredHeight + SystemInformation.HorizontalScrollBarHeight;

        }
        private void TextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0) return;
        // При неудачной попытке преобразования восстанавливаем старое
            decimal tmpValue;
         if (!Decimal.TryParse(txtBox.Text, out tmpValue)) txtBox.Text = mValue.ToString();
         else        
            mValue = tmpValue;
        }

    private void TextBoxOnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: OnValueChanged(EventArgs.Empty); break;
            }
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            // Повышаем полномочия ссылки на объект скролирующей кнопки
            ArrowButton btn = (ArrowButton)sender;
            // Создаем пробную переменную
            decimal tmpValue = mValue;
            // Идентифицируем кнопку и меняем значение поля
            if (btn == btnLeft)
            {
                if ((tmpValue -= mIncrement) < mMinimum) return;
            }
            else // Других кнопок нет
            {
                if ((tmpValue += mIncrement) > mMaximum) return;
            }
            // Обновляем внутреннее и текстовое поля
            this.Value = tmpValue;
            // Генерируем событие, извещающее подписавшегося
            // клиента о произошедшем изменении значения счетчика
            OnValueChanged(EventArgs.Empty);
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            // Возбуждаем событие и обновление состояния компонента
            OnValueChanged(EventArgs.Empty);
        }

    }
}
