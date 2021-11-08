using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int isInput()
        {
            int answer = 0;
            if (this.Numerator1.Text != "" && this.Numerator2.Text != "" && this.Denominator1.Text != "" && this.Denominator2.Text != "") answer = 1;
            return answer;
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            Action_Label.Text = "+";
            if (isInput() == 1)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);
                Fraction fract = new Fraction(n1, d1);
                int[] arr = fract.plus(n1, d1, n2, d2);
                resultNum.Text = Convert.ToString(arr[0]);
                resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Action_Label.Text = "-";
            if (isInput() == 1) { 
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            Fraction fract = new Fraction(n1, d1);
            int[] arr = fract.minus(n1, d1, n2, d2);
            resultNum.Text = Convert.ToString(arr[0]);
            resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Action_Label.Text = "x";
            if (isInput() == 1)
            {
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            Fraction fract = new Fraction(n1, d1);
            int[] arr = fract.multiply(n1, d1, n2, d2);
            resultNum.Text = Convert.ToString(arr[0]);
            resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Action_Label.Text = "/";
            if (isInput() == 1)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);
                Fraction fract = new Fraction(n1, d1);
                int[] arr = fract.division(n1, d1, n2, d2);
                resultNum.Text = Convert.ToString(arr[0]);
                resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            if (isInput() == 1)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);
                Fraction fract = new Fraction(n1, d1);
                string a = fract.compare(n1, d1, n2, d2);
                Action_Label.Text = a;
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработать приложение(а-ля калькулятор) для вычисления, сокращения и сравнения дробей");
        }

        private void Slash_Click(object sender, EventArgs e)
        {
            Action_Label.Text = "С";
            if (isInput() == 1)
            {
                int n = Convert.ToInt32(this.resultNum.Text);
                int d = Convert.ToInt32(this.resultDen.Text);
                Fraction fract = new Fraction(n, d);
                int[] arr = new int[2];
                arr = fract.slash(n, d);
                resultNum.Text = Convert.ToString(arr[0]);
                resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Numerator1.Text = "";
            Numerator2.Text = "";
            Denominator1.Text = "";
            Denominator2.Text = "";
            resultNum.Text = "";
            resultDen.Text = "";
        }

        private void result10_Click(object sender, EventArgs e)
        {
            if (isInput() == 1)
            {
                int n = Convert.ToInt32(this.resultNum.Text);
                int d = Convert.ToInt32(this.resultDen.Text);
                Fraction fract = new Fraction(n, d);
                int[] arr = new int[2];
                arr = fract.slash(n, d);
                MessageBox.Show("Результат в виде десятичной дроби:\n" + Convert.ToDouble(arr[0]) / Convert.ToDouble(arr[1]));
            }
            else if (isInput() == 0) MessageBox.Show("Ошибка! Не введены данные!");
        }
    }

}
