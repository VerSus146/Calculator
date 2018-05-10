using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        Form2 frm2;

        bool DotUsed;

        float Value;

        String LastAction;

        String MemorySlot;

        float TMPValue;

        public Calculator()
        {
            InitializeComponent();

            _Text.Text = "0";
            MemorySlot = "3";

            Memorypanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "3";
                LastAction = "";
            }
            else if(_Text.Text == "0")
            {
                _Text.Text = "3";
            } else
            {
                _Text.Text += "3";
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "2";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "2";
            } else
            {
                _Text.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "1";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "1";
            }
            else
            {
                _Text.Text += "1";
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "9";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "9";
            }
            else
            {
                _Text.Text += "9";
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "4";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "4";
            }
            else
            {
                _Text.Text += "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "5";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "5";
            }
            else
            {
                _Text.Text += "5";
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "6";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "6";
            }
            else
            {
                _Text.Text += "6";
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "7";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "7";
            }
            else
            {
                _Text.Text += "7";
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "8";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "8";
            }
            else
            {
                _Text.Text += "8";
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = "0";
                LastAction = "";
            } else if (_Text.Text == "0")
            {
                _Text.Text = "0";
            }
            else
            {
                _Text.Text += "0";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {

            if (LastAction == "Plus")
            {
                if(MemorySlot == "1")
                {
                    label3.Text = Value.ToString("R") + " + " + _Text.Text;
                } else if (MemorySlot == "2")
                {
                    label2.Text = Value.ToString("R") + " + " + _Text.Text;
                } else if(MemorySlot == "3")
                {
                    label1.Text = Value.ToString("R") + " + " + _Text.Text;
                }

                Value += float.Parse(_Text.Text);  
                
            } else if(LastAction == "Minus")
            {
                if (MemorySlot == "1")
                {
                    label3.Text = Value.ToString("R") + " - " + _Text.Text;
                }
                else if (MemorySlot == "2")
                {
                    label2.Text = Value.ToString("R") + " - " + _Text.Text;
                }
                else if (MemorySlot == "3")
                {
                    label1.Text = Value.ToString("R") + " - " + _Text.Text;
                }

                Value -= float.Parse(_Text.Text);

            } else if(LastAction == "Times")
            {
                if (MemorySlot == "1")
                {
                    label3.Text = Value.ToString("R") + " * " + _Text.Text;
                }
                else if (MemorySlot == "2")
                {
                    label2.Text = Value.ToString("R") + " * " + _Text.Text;
                }
                else if (MemorySlot == "3")
                {
                    label1.Text = Value.ToString("R") + " * " + _Text.Text;
                }
  
                Value *= float.Parse(_Text.Text);
            } else if(LastAction == "Divide")
            {
                if (MemorySlot == "1")
                {
                    label3.Text = Value.ToString("R") + " / " + _Text.Text;
                }
                else if (MemorySlot == "2")
                {
                    label2.Text = Value.ToString("R") + " / " + _Text.Text;
                }
                else if (MemorySlot == "3")
                {
                    label1.Text = Value.ToString("R") + " / " + _Text.Text;
                }
                
                Value /= float.Parse(_Text.Text);
            } else
            {
                LastAction = "Equals";
                return;
            }

            _Text.Text = Value.ToString("R");
            Value = 0;
            LastAction = "";
            DotUsed = false;

            if (MemorySlot == "1")
            {
                MemorySlot = "3";
                FirstSlotEquals.Text = _Text.Text;
            }
            else if (MemorySlot == "2")
            {
                MemorySlot = "1";
                SecondSlotEquals.Text = _Text.Text;
            }
            else if (MemorySlot == "3")
            {
                MemorySlot = "2";
                ThirdSlotEquals.Text = _Text.Text;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {

            if(Value == 0)
            {
                Value = float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Plus";
            } else
            {
                Value += float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Plus";
            }

            TMPValue = Value;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(_Text.Text.Length != 0)
            {
                _Text.Text = _Text.Text.Remove(_Text.Text.Length - 1);
            } else
            {
                return;
            }
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {

            if (Value == 0)
            {
                Value = float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Minus";
            } else
            {
                Value -= float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Minus";
            }

            
        }

        private void Times_Click(object sender, EventArgs e)
        {

            if (Value == 0)
            {
                Value = float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Times";
            }
            else
            {
                Value *= float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Times";
            }

        }

        private void Divide_Click(object sender, EventArgs e)
        {

            if (Value == 0)
            {
                Value = float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Divide";
            }
            else
            {
                Value /= float.Parse(_Text.Text);
                TMPValue = Value;
                _Text.Text = "0";
                LastAction = "Times";
            }

            TMPValue = Value;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _Text.Text = "0";
            Value = 0;
        }

        private void Doy_Click(object sender, EventArgs e)
        {
            if(_Text.Text == "" && !DotUsed)
            {
                _Text.Text = "0,";
            } else if(!DotUsed)
            {
                _Text.Text += ",";
            } else
            {
                return;
            }
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            
            Memorypanel.Visible = true;
            kalkulacje.Visible = false;
            Back.Visible = true;
            _Text.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Text.Text = FirstSlotEquals.Text;
            Memorypanel.Visible = false;
            kalkulacje.Visible = true;
            Back.Visible = false;
            _Text.Visible = true;
            LastAction = "Load";
        }

        private void ThirdSlotButton_Click(object sender, EventArgs e)
        {
            _Text.Text = ThirdSlotEquals.Text;
            Memorypanel.Visible = false;
            kalkulacje.Visible = true;
            Back.Visible = false;
            _Text.Visible = true;
            LastAction = "Load";
        }

        private void SecondSaveButton_Click(object sender, EventArgs e)
        {
            _Text.Text = SecondSlotEquals.Text;
            Memorypanel.Visible = false;
            kalkulacje.Visible = true;
            Back.Visible = false;
            _Text.Visible = true;
            LastAction = "Load";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Memorypanel.Visible = false;
            kalkulacje.Visible = true;
            Back.Visible = false;
            _Text.Visible = true;
        }
    }
}
