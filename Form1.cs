﻿using System;
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

        private void Plus_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(this.Numerator1.Text);
            int n2 = Convert.ToInt32(this.Numerator2.Text);
            int d1 = Convert.ToInt32(this.Denominator1.Text);
            int d2 = Convert.ToInt32(this.Denominator2.Text);
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            int [] arr = fract1.Plus(n1, d1, n2, d2);
            resultNum.Text = Convert.ToString(arr[0]);
            resultDen.Text = Convert.ToString(arr[1]);
          //MessageBox.Show("Результат\n"+resultNum.Text+"\n-\n"+resultDen.Text);
        }


    }
}
