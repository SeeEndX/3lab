using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _3lab
{
    public class Fraction
    {
        private int num; //числитель
        private int denom; //знаменатель
        public Fraction(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }

        public double CountFraction()
        {
            var fractionValue = num / denom;
            return fractionValue;
        }
        public string Output()
        {
            string output = this.num + "\n-\n" + this.denom;
            return output;
        }

        public int[] Plus(int n1, int d1, int n2,int d2)
        {
            int plusNum, plusDen;
            int[] plus = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            plusNum = fract1.num * fract2.denom + fract2.num * fract1.denom;
            plusDen = fract1.denom * fract2.denom;
            plus[0] = plusNum;
            plus[1] = plusDen;
            return plus;
        }

        public int[] Minus(int n1, int d1, int n2, int d2)
        {
            int minusNum, minusDen;
            int[] minus = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            minusNum = fract1.num * fract2.denom - fract2.num * fract1.denom;
            minusDen = fract1.denom * fract2.denom;
            minus[0] = minusNum;
            minus[1] = minusDen;
            return minus;
        }

        /*public static Fraction operator+(Fraction fra, int num)
        {
            fract1 = ;
            var newFraction = inst + number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

        public static Fraction operator -(Fraction fract1, Fraction fract2)
        {
            var newFraction = inst - number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
        public static Fraction operator *(Fraction fract1, Fraction fract2)
        {
            var newFraction = inst.CountFraction() * number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
        public static Fraction operator /(Fraction fract1, Fraction fract2)
        {
            var newFraction = inst.CountFraction() / number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
    }
        */
    }
}
