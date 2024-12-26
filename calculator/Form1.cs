using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        string operation = "";
    

        private void calculateTAN(object sender, EventArgs e)
        {
            btnequal.Tag = "tan";
            Guna2Button button = (Guna2Button)sender;
              txtstore.Text = txtstore.Text+ button.Tag.ToString();
        
        }
        private void calculateLN(object sender, EventArgs e)
        {
            btnequal.Tag = "ln";
            Guna2Button button = (Guna2Button)sender;
            txtstore.Text = txtstore.Text + button.Tag.ToString();

        }
        private void calculateLG(object sender, EventArgs e)
        {
            btnequal.Tag = "lg";
            Guna2Button button = (Guna2Button)sender;
            txtstore.Text = txtstore.Text + button.Tag.ToString();

        }
        private string processTan(string input)
        {
            while (input.Contains("tan("))
            {
                int startIndex = input.IndexOf("tan(");
                int endIndex = input.IndexOf(")", startIndex);
                string tanValueStr = input.Substring(startIndex + 4, endIndex - startIndex - 4);
                double.TryParse(tanValueStr, out double tanValue);
                double tanresult = Math.Tan(tanValue * Math.PI / 180);
                input = input.Substring(0, startIndex) + tanresult + input.Substring(endIndex + 1);
            }
            return input;
        }
        private string processLG(string input)
        {
            while (input.Contains("lg("))
            {
                int startIndex = input.IndexOf("lg(");
                int endIndex = input.IndexOf(")", startIndex);
                string lgValueStr = input.Substring(startIndex + 3, endIndex - startIndex - 3);
                double.TryParse(lgValueStr, out double lgValue);
                double lgresult = Math.Log10(lgValue );
                input = input.Substring(0, startIndex) + lgresult + input.Substring(endIndex + 1);
            }
            return input;
        }
        private string processLN(string input)
        {
            while (input.Contains("ln("))
            {
                int startIndex = input.IndexOf("ln(");
                int endIndex = input.IndexOf(")", startIndex);
                string lnValueStr = input.Substring(startIndex + 3, endIndex - startIndex - 3);
                double.TryParse(lnValueStr, out double lnValue);
                double lnresult = Math.Log(lnValue );
                input = input.Substring(0, startIndex) + lnresult + input.Substring(endIndex + 1);
            }
            return input;
        }
        private string processCOS(string input)
        {
            while (input.Contains("cos("))
            {
                int startIndex = input.IndexOf("cos(");
                int endIndex = input.IndexOf(")", startIndex);
                string cosValueStr = input.Substring(startIndex + 4, endIndex - startIndex - 4);
                double.TryParse(cosValueStr, out double cosValue);
                double cosResult = Math.Cos(cosValue * Math.PI / 180);
                input = input.Substring(0, startIndex) + cosResult + input.Substring(endIndex + 1);
            }
            return input;
        }
        private string processSIN(string input)
        {
            while (input.Contains("sin("))
            {
                int startIndex = input.IndexOf("sin(");
                int endIndex = input.IndexOf(")", startIndex);
                string sinValueStr = input.Substring(startIndex + 4, endIndex - startIndex - 4);
                double.TryParse(sinValueStr, out double sinValue);
                double sinResult = Math.Sin(sinValue * Math.PI / 180);
                input = input.Substring(0, startIndex) + sinResult + input.Substring(endIndex + 1);
            }
            return input;
        }
        private void evalueteEXPression(string operation)
        {
           
            try
            {
                var result = new DataTable().Compute(operation, null);
                txtresult.Text = result.ToString();
            }
            catch (Exception)
            {

            }
          
        }
        private void calculatecos (object sender, EventArgs e)
        {
            btnequal.Tag = "cos";
            Guna2Button button = (Guna2Button)sender;
            txtstore.Text = txtstore.Text + button.Tag.ToString();
        }
        private void calculateSIN(object sender, EventArgs e)
        {
            btnequal.Tag = "sin";
            Guna2Button button = (Guna2Button)sender;
            txtstore.Text = txtstore.Text + button.Tag.ToString();
        }
        private void Guna2Button_click(object sender, EventArgs e)
        {
         
            Guna2Button button = (Guna2Button)sender;
            txtstore.Text = txtstore.Text + button.Tag.ToString();
            
             
            
        }
        private void PrecentageCalculate(object sender, EventArgs e)
        {
            string value = txtstore.Text;
            double number = double.Parse(value);
            double precentage=number/100;
            txtresult.Text = precentage.ToString(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstore.Clear();
            txtresult.Clear();
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            string Tag = btnequal.Tag.ToString();
            string operation = txtstore.Text;
            switch (Tag)
            {
                case "=":

                    evalueteEXPression(operation);
                    break;
                case "tan":
                    try
                    {

                        string processedInput = processTan(operation);
                        evalueteEXPression(processedInput);
                    }
                    catch
                    {

                    }
                    btnequal.Tag = "=";
                    break;
                case "cos":
                    try
                    {

                        string processedInput = processCOS(operation);
                        evalueteEXPression(processedInput);
                    }
                    catch
                    {

                    }
                    btnequal.Tag = "=";
                    break;
                case "sin":
                    try
                    {

                        string processedInput = processSIN(operation);
                        evalueteEXPression(processedInput);
                    }
                    catch
                    {

                    }
                    btnequal.Tag = "=";
                    break;
                case "ln":
                    try
                    {

                        string processedInput = processLN(operation);
                        evalueteEXPression(processedInput);
                    }
                    catch
                    {

                    }
                    btnequal.Tag = "=";
                    break;
                case "lg":
                    try
                    {

                        string processedInput = processLG(operation);
                        evalueteEXPression(processedInput);
                    }
                    catch
                    {

                    }
                    btnequal.Tag = "=";
                    break;
            }




        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2Button9.Text = "\u221A";
            string value = txtstore.Text;
            double number = double.Parse(value);
            double SQRT = Math.Sqrt(number);
            txtresult.Text = SQRT.ToString();
        }
    }
}
