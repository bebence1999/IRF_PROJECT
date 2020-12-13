using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Kórházi_betegkezelő_XAICMP
{
    class RandomTipp:Button
    {
        
        private int _value;
        public RandomTipp()

        {
            
            Value = 0;
            MouseDown += RandomTipp_MouseDown;
        }

        private void RandomTipp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Value++;
           
        }
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (_value < 0)
                    _value = 9;
                else if (_value > 9)
                    _value = 0;
                if (_value == 0)
                    Text = "";
                else
                    Text = _value.ToString();

            }
        }
    }

    
    
}
