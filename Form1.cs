using System;
using System.Windows.Forms;

namespace _3lab
{
    public partial class Form1 : Form
    {
        Fraction fract1 = new Fraction(0, 1);
        Fraction fract2 = new Fraction(0, 1);
        Fraction answer = new Fraction(0, 1);
        public Form1()
        {
            InitializeComponent();
            Numerator1.Text = Properties.Settings.Default.Numerator1; //Использование сохраненных данных
            Numerator2.Text = Properties.Settings.Default.Numerator2; //Использование сохраненных данных
            Denominator1.Text = Properties.Settings.Default.Denominator1; //Использование сохраненных данных
            Denominator2.Text = Properties.Settings.Default.Denominator2; //Использование сохраненных данных
        }

        private int isCorrect()
        {
            int ans = 0;
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            if (n1 >= d1 || n2 >= d2) ans = 2;
            else if (n1 == 0 || d1 == 0 || n2 == 0 || d2 == 0) ans = 0;
            else ans = 1;
            return ans;
        }

        private int isInput()   //проверка, введено ли что-нибудь
        {
            int answer = 0;
            if (this.Numerator1.Text != "" && this.Numerator2.Text != "" && this.Denominator1.Text != "" && this.Denominator2.Text != "") answer = 1;
            answer = answer + isCorrect();
            return answer;
        }

        private void save()
        {
            Properties.Settings.Default.Numerator1 = this.Numerator1.Text;
            Properties.Settings.Default.Numerator2 = this.Numerator2.Text;
            Properties.Settings.Default.Denominator1 = this.Denominator1.Text;
            Properties.Settings.Default.Denominator2 = this.Denominator2.Text;
            Properties.Settings.Default.Save();
        }
        private void Plus_Click(object sender, EventArgs e) //сложение
        {
            visibleEl(true);
            Action_Label.Text = "+";
            if (isInput() == 2)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);

                fract1 = new Fraction(n1, d1);
                fract2 = new Fraction(n2, d2);
                answer = fract1 + fract2;
                resultNum.Text = Convert.ToString(answer.Num);
                resultDen.Text = Convert.ToString(answer.Denom);
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены или некорректные данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Minus_Click(object sender, EventArgs e)  //вычитание
        {
            visibleEl(true);
            Action_Label.Text = "-";
            if (isInput() == 2) { 
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            fract1 = new Fraction(n1, d1);
            fract2 = new Fraction(n2, d2);
            answer = fract1 - fract2;
            resultNum.Text = Convert.ToString(answer.Num);
            resultDen.Text = Convert.ToString(answer.Denom);
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены или некорректные данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Multiply_Click(object sender, EventArgs e)  //умножение
        {
            visibleEl(true);
            Action_Label.Text = "x";
            if (isInput() == 2)
            {
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            fract1 = new Fraction(n1, d1);
            fract2 = new Fraction(n2, d2);
            answer = fract1 * fract2;
            resultNum.Text = Convert.ToString(answer.Num);
            resultDen.Text = Convert.ToString(answer.Denom);
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены или некорректные данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Division_Click(object sender, EventArgs e)  //деление
        {
            visibleEl(true);
            Action_Label.Text = "/";
            if (isInput() == 2)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);
                fract1 = new Fraction(n1, d1);
                fract2 = new Fraction(n2, d2);
                answer = fract1 / fract2;
                resultNum.Text = Convert.ToString(answer.Num);
                resultDen.Text = Convert.ToString(answer.Denom);
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены или некорректные данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Compare_Click(object sender, EventArgs e)  //сравнение
        {
            if (isInput() == 2)
            {
                int n1 = Convert.ToInt32(this.Numerator1.Text);
                int n2 = Convert.ToInt32(this.Numerator2.Text);
                int d1 = Convert.ToInt32(this.Denominator1.Text);
                int d2 = Convert.ToInt32(this.Denominator2.Text);
                Fraction fract = new Fraction(n1, d1);
                string a = fract.compare(n1, d1, n2, d2);
                Action_Label.Text = a;
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
            visibleEl(false);
        }

        private void visibleEl(bool n)  //скрытие результата
        {
            resultNum.Visible = n;
            resultDen.Visible = n;
            label3.Visible = n;
            label6.Visible = n;
            label7.Visible = n;
        }

        private void Task_Click(object sender, EventArgs e) //задание
        {
            MessageBox.Show("Разработать приложение(а-ля калькулятор) для вычисления, сокращения и сравнения дробей");
            save();
        }

        private void Slash_Click(object sender, EventArgs e) //сокращение
        {
            visibleEl(true);
            Action_Label.Text = "С";
            if (isInput() == 2)
            {
                int n = Convert.ToInt32(this.resultNum.Text);
                int d = Convert.ToInt32(this.resultDen.Text);
                Fraction fract = new Fraction(n, d);
                int[] arr = new int[2];
                arr = fract.slash(n, d);
                resultNum.Text = Convert.ToString(arr[0]);
                resultDen.Text = Convert.ToString(arr[1]);
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Clear_Click(object sender, EventArgs e) //очистка полей
        {
            visibleEl(true);
            Numerator1.Text = "";
            Numerator2.Text = "";
            Denominator1.Text = "";
            Denominator2.Text = "";
            resultNum.Text = "";
            resultDen.Text = "";
            save();
        }

        private void result10_Click(object sender, EventArgs e) //вывод в форме десятичной дроби
        {
            visibleEl(true);
            if (isInput() == 2)
            {
                int n = Convert.ToInt32(this.resultNum.Text);
                int d = Convert.ToInt32(this.resultDen.Text);
                Fraction fract = new Fraction(n, d);
                int[] arr = new int[2];
                arr = fract.slash(n, d);
                MessageBox.Show("Результат в виде десятичной дроби:\n" + Convert.ToDouble(arr[0]) / Convert.ToDouble(arr[1]));
            }
            else if (isInput() == 1) MessageBox.Show("Ошибка! Не введены или некорректные данные!");
            else if (isInput() == 3) MessageBox.Show("Числитель одной из дробей больше или равен знаменталю, дробь должна быть правильная!");
            save();
        }

        private void Just_Key_Up(object sender, KeyEventArgs e) //работа enter
        {
            visibleEl(true);
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}