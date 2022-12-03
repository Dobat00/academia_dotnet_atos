using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_calculadora
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double firstnumber, secondnumber;
        public MainPage()
        {
            InitializeComponent();
            OnClear(new object(), new EventArgs());
        }

        void OnClear(object sender, EventArgs e)
        {
            firstnumber = 0;
            secondnumber = 0;
            currentState = 1;
            this.resultText.Text = "0";
        }
        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if(this.resultText.Text == "0" || currentState < 0)
            {
                this.resultText.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }
            this.resultText.Text += pressed;

            double number;
            if (double.TryParse(this.resultText.Text, out number))
            {
                this.resultText.Text = number.ToString("NO");
                if (currentState == 1)
                {
                    firstnumber = number;

                }
                else
                {
                    secondnumber = number;
                }
            }

        }
        void OnSelectOperator(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            String pressed = button.Text;
            mathOperator = pressed;

        }

        void OnCalculate(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double result = 0;
                if (mathOperator == "+")
                {
                    result = firstnumber + secondnumber;
                }

                if (mathOperator == "-")
                {
                    result = firstnumber - secondnumber;
                }

                if (mathOperator == "X")
                {
                    result = firstnumber * secondnumber;
                }
                if (mathOperator == "/")
                {
                    result = firstnumber / secondnumber;
                }

                this.resultText.Text = result.ToString();
                firstnumber = result;
                currentState = -1;
            }
        }
    }
}
