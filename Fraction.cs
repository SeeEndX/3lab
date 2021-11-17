using System;

namespace _3lab
{
    public class Fraction
    {
        private int num; //числитель
        private int denom; //знаменатель

        public int Num { get => num; set => num = value; }
        public int Denom { get => denom; set => denom = value; }

        public Fraction(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }

        public string write()  //для автотестов, вывод ответа
        {
            string result = num.ToString()+" "+denom.ToString();
            return result;
        }
        public static Fraction operator+(Fraction f, Fraction s) //сложение
        {
            int num_new = f.num*s.denom + s.num*f.denom;
            int den_new = f.denom * s.denom;
            Fraction answer = new Fraction(num_new, den_new);
            return answer;
        }

        public static Fraction operator -(Fraction f, Fraction s) //вычитание
        {
            int num_new = f.num * s.denom - s.num * f.denom;
            int den_new = f.denom * s.denom;
            Fraction answer = new Fraction(num_new, den_new);
            return answer;
        }

        public static Fraction operator *(Fraction f, Fraction s) //умножение
        {
            int num_new = f.num * s.num;
            int den_new = f.denom * s.denom;
            Fraction answer = new Fraction(num_new, den_new);
            return answer;
        }

        public static Fraction operator /(Fraction f, Fraction s) //деление
        {
            int num_new = f.num * s.denom;
            int den_new = s.num * f.denom;
            Fraction answer = new Fraction(num_new, den_new);
            return answer;
        }

        public string compare(int n1, int d1, int n2, int d2) //сравнение
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

        public int[] slash(int n, int d) //сокращение
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
