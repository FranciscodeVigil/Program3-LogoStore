using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3_LogoStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //visibilty toggle from check box
            if (NumColors.Visible == false)
            {
                NumColors.Visible = true;
                NumColorsText.Visible = true;
            } 
            else
            {
                NumColors.Visible = false;
                NumColorsText.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Submit button function
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogoOrderItem userItem = new LogoOrderItem(LogoCheckBox.Checked, EngravingText.Text);
                userItem.NumItems = Convert.ToInt32(NumItemsText.Text);

                if (LogoCheckBox.Checked == true)
                {
                    userItem.NumColors = Convert.ToInt32(NumColorsText.Text);
                }
                else
                {
                    userItem.NumColors = 0;
                }

                if (Pen.Checked == true)
                {
                    userItem.ItemType = "Pen";
                }
                if (USB.Checked == true)
                {
                    userItem.ItemType = "USB";
                }
                if (Mug.Checked == true)
                {
                    userItem.ItemType = "Mug";
                }
                txbOutput.Text = userItem.GetOrderSummary();
            } catch (Exception)
            {
                txbOutput.Text = "Hey bro, you did something wrong";
            }
        }

        //Clear button resets things individually.
        private void button2_Click(object sender, EventArgs e)
        {
            if (Pen.Checked == true)
            {
                Pen.Checked = false;
            }
            if (USB.Checked == true)
            {
                USB.Checked = false;
            }
            if (Mug.Checked == true)
            {
                Mug.Checked = false;
            }

            NumItemsText.Text = "";
            EngravingText.Text = "";
            NumColorsText.Text = "";

            LogoCheckBox.Checked = false;
            txbOutput.Text = "";
        }
    }
}
