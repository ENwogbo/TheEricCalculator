using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEricCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dividesign.Text = "\u00F7";
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if values are numbers

            bool isNumber1 = float.TryParse(addtxt1.Text, out float addtxt1Value);
            bool isNumber2 = float.TryParse(addtxt2.Text, out float addtxt2Value);


            if (isNumber1 == true && isNumber2 == true )
            {
                float addresultValue = addtxt1Value + addtxt2Value;
                addresult.Text = addresultValue.ToString();
            }

            else
            {
                MessageBox.Show("Invalid Input Format");
            }
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool subIsNumber1 = float.TryParse(subtxt1.Text, out float subtxt1Value);
            bool subIsNumber2 = float.TryParse(subtxt2.Text, out float subtxt2Value);
            if (subIsNumber1 == true && subIsNumber2 == true)
            {
                float subresultValue = subtxt1Value - subtxt2Value;
                subresult.Text = subresultValue.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input Format");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            bool isTrue = CheckIfNumberIsTrue(multtxt1.Text, multtxt2.Text);

            if (isTrue)
            {
                float multtxt1Value = float.Parse(multtxt1.Text);
                float multtxt2Value = float.Parse(multtxt2.Text);
                float multresultValue = multtxt1Value * multtxt2Value;
                multresult.Text = multresultValue.ToString();
            }

            else
            {
                MessageBox.Show("Invalid Input Format");
            }

         
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isTrue = CheckIfNumberIsTrue(divtxt1.Text, divtxt2.Text);
            if (isTrue)
            { 
                float divtxt1Value = float.Parse(divtxt1.Text);
                float divtxt2Value = float.Parse(divtxt2.Text);
                float divresultValue = divtxt1Value / divtxt2Value;
                divresult.Text = divresultValue.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input Format");

            }

        }

        bool CheckIfNumberIsTrue(string number1, string number2)
        {
            bool IsNumber1 = float.TryParse(number1, out float a);
            bool IsNumber2 = float.TryParse(number2, out float b);

            if (IsNumber1 == true && IsNumber2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
