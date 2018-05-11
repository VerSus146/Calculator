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

        bool DotUsed;

        float Value;

        String LastAction;

        String MemorySlot;

        public Calculator()
        {
            InitializeComponent();

            _Text.Text = "0";
            MemorySlot = "3";

            Memorypanel.Visible = false;
        }

        void AddNumber(float Number)
        {
            if (LastAction == "Equals" || LastAction == "Load")
            {
                _Text.Text = Number.ToString("R");
                LastAction = "";
            }
            else if (_Text.Text == "0")
            {
                _Text.Text = Number.ToString("R");
            }
            else
            {
                _Text.Text += Number.ToString("R");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if(LastAction == "Plus")
            {
                SaveMemory("+");
            } else if(LastAction == "Minus")
            {
                SaveMemory("-");
            }
            else if (LastAction == "Times")
            {
                SaveMemory("*");
            }
            else if (LastAction == "Divide")
            {
                SaveMemory("/");
            }

            Display();

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

        void Display()
        {
            _Text.Text = Value.ToString("R");
            Value = 0;
            LastAction = "";
            DotUsed = false;
        }

        void SaveMemory(String Math)
        {

                if (MemorySlot == "1")
                {
                    label3.Text = Value.ToString("R") + Math + _Text.Text;
                }
                else if (MemorySlot == "2")
                {
                    label2.Text = Value.ToString("R") + Math + _Text.Text;
                }
                else if (MemorySlot == "3")
                {
                    label1.Text = Value.ToString("R") + Math + _Text.Text;
                }

                if(Math == "+")
                {
                    Value += float.Parse(_Text.Text);
                } else if (Math == "-")
                {
                    Value -= float.Parse(_Text.Text);
                }
                else if (Math == "*")
                {
                    Value *= float.Parse(_Text.Text);
                }
                else if (Math == "/")
                {
                    if(float.Parse(_Text.Text) == 0 || Value == 0)
                    {
                        _Text.Text = "NaN";
                    }

                    Value /= float.Parse(_Text.Text);
                }

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

        private void Plus_Click(object sender, EventArgs e)
        {
            Math("Plus");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Math("Minus");
        }

        private void Times_Click(object sender, EventArgs e)
        {
            Math("Times");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Math("Divide");
        }

        void Math(String Math)
        {
            if (Value == 0)
            {
                Value = float.Parse(_Text.Text);
            }
            else if(Math == "Divide")
            {
                Value /= float.Parse(_Text.Text);
            } else if(Math == "Times")
            {
                Value *= float.Parse(_Text.Text);
            } else if(Math == "Minus")
            {
                Value -= float.Parse(_Text.Text);
            } else if(Math == "Plus")
            {
                Value += float.Parse(_Text.Text);
            }

            _Text.Text = "0";
            LastAction = Math;
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMath(FirstSlotEquals);
        }

        private void ThirdSlotButton_Click(object sender, EventArgs e)
        {
            LoadMath(ThirdSlotEquals);
        }

        private void SecondSaveButton_Click(object sender, EventArgs e)
        {
            LoadMath(SecondSlotEquals);
        }

        void LoadMath(Label slot)
        {
            _Text.Text = slot.Text;
            Memorypanel.Visible = false;
            kalkulacje.Visible = true;
            Back.Visible = false;
            _Text.Visible = true;
            LastAction = "Load";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SwapPanels(true);
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            SwapPanels(false);
        }

        void SwapPanels(bool calc)
        {
            if (!calc)
            {
                Memorypanel.Visible = true;
                kalkulacje.Visible = false;
                Back.Visible = true;
                _Text.Visible = false;
            }
            else if (calc)
            {
                Memorypanel.Visible = false;
                kalkulacje.Visible = true;
                Back.Visible = false;
                _Text.Visible = true;
            }
        }
    }
}
