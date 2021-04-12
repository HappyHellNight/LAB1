using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3.StudName
{
    public partial class NumericScan : Component
    {
        public NumericScan()
        {
            InitializeComponent();
        }

        public NumericScan(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void TextBoxOnTextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxOnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void ButtonOnClick(object sender, EventArgs e)
        {

        }
    }
}
