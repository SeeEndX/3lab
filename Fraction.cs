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

        public double countFraction()
        {
            var fractionValue = num / denom;
            return fractionValue;
        }
        public string output()
        {
            string output = this.num + "\n-\n" + this.denom;
            return output;
        }

        public int[] plus(int n1, int d1, int n2, int d2)
        {
            int plusNum, plusDen;
            int[] plus = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            if (fract1.denom == fract2.denom)
            {
                plus[0] = fract1.num + fract2.num;
                plus[1] = fract1.denom;
            }
            else
            {
            plusNum = fract1.num * fract2.denom + fract2.num * fract1.denom;
            plusDen = fract1.denom * fract2.denom;
            plus[0] = plusNum;
            plus[1] = plusDen;
            }
            return plus;
        }

        public int[] minus(int n1, int d1, int n2, int d2)
        {
            int minusNum, minusDen;
            int[] minus = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            if (fract1.denom == fract2.denom)
            {
                minus[0] = fract1.num - fract2.num;
                minus[1] = fract1.denom;
            }
            else 
            { 
            minusNum = fract1.num * fract2.denom - fract2.num * fract1.denom;
            minusDen = fract1.denom * fract2.denom;
            minus[0] = minusNum;
            minus[1] = minusDen;
            }
            return minus;
        }

        public int[] multiply(int n1, int d1, int n2, int d2)
        {
            int multiplyNum, multiplyDen;
            int[] multiply = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            multiplyNum = fract1.num * fract2.num;
            multiplyDen = fract1.denom * fract2.denom;
            multiply[0] = multiplyNum;
            multiply[1] = multiplyDen;
            return multiply;
        }

        public int[] division(int n1, int d1, int n2, int d2)
        {
            int divisionNum, divisionDen;
            int[] division = new int[2];
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            divisionNum = fract1.num * fract2.denom;
            divisionDen = fract1.denom * fract2.num;
            division[0] = divisionNum;
            division[1] = divisionDen;
            return division;
        }

        public string compare(int n1, int d1, int n2, int d2)
        {
            string answer = "0";                                   // 0-неверно      1-1я дробь больше  2-2я дробь больше
            double f1, f2;                                    // 3-дроби равны
            Fraction fract1 = new Fraction(n1, d1);
            Fraction fract2 = new Fraction(n2, d2);
            f1 = Convert.ToDouble(fract1.num) / Convert.ToDouble(fract1.denom);
            f2 = Convert.ToDouble(fract2.num) / Convert.ToDouble(fract2.denom);
            if (f1 > f2) answer = ">";
            else if (f1 < f2) answer = "<";
            else if (f1 == f2) answer = "=";
            return answer;
        }

        public int[] slash(int n, int d)
        {
            int[] slash_pr = new int[2];
            Fraction fract = new Fraction(n, d);

            if (fract.denom % fract.num == 0)
            {
                fract.denom = fract.denom / fract.num;
                fract.num = 1;
            }

            while (fract.num%7 == 0 && fract.denom%7 == 0)
            {
                fract.num = fract.num / 7;
                fract.denom = fract.denom / 7;
            }

            while (fract.num % 5 == 0 && fract.denom % 5 == 0)
            {
                fract.num = fract.num / 5;
                fract.denom = fract.denom / 5;
            }

            while (fract.num % 3 == 0 && fract.denom % 3 == 0)
            {
                fract.num = fract.num / 3;
                fract.denom = fract.denom / 3;
            }

            if (fract.num % 2 == 0 && fract.denom % 2 == 0 && fract.num != 0)
            {
                fract.num = fract.num / 2;
                fract.denom = fract.denom / 2;
            }

            while (fract.num % 2 == 0 && fract.denom % 2 == 0 && fract.num != 0)
            {
                fract.num = fract.num / 2;
                fract.denom = fract.denom / 2;
            }

            slash_pr[0] = fract.num; 
            slash_pr[1] = fract.denom;
            return slash_pr;
        }
    }
}
