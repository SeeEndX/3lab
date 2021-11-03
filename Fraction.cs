using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _3lab
{
    public class Fraction
    {
        private double num; //числитель
        private double denom; //знаменатель
        public Fraction(double num, double denom)
        {
            this.num = num;
            this.denom = denom;
        }
        
        public double CountFraction()
        {
            var fractionValue = num/denom; 
            return fractionValue;
        }
        /*
        public double Value
        {
            get => (num / denom);
        }
        */
        public string Output()
        {
            string output = this.num+"\n-\n"+this.denom;
            return output;
        }
        public static Fraction operator+(Fraction inst, double number)
        {
            var newFraction = inst.CountFraction() + number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

        public static Fraction operator +(double number, Fraction inst)
        {
            var newFraction = number + inst.CountFraction();
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

        public static Fraction operator -(Fraction inst, double number)
        {
            var newFraction = inst.CountFraction() - number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
        public static Fraction operator -(double number, Fraction inst)
        {
            var newFraction = number - inst.CountFraction();
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

        public static Fraction operator *(Fraction inst, double number)
        {
            var newFraction = inst.CountFraction() * number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
        public static Fraction operator *(double number, Fraction inst)
        {
            var newFraction = number * inst.CountFraction();
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

        public static Fraction operator /(Fraction inst, double number)
        {
            var newFraction = inst.CountFraction() / number;
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }
        public static Fraction operator /(double number, Fraction inst)
        {
            var newFraction = number / inst.CountFraction();
            var fraction = new Fraction(newFraction, inst.num);
            return fraction;
        }

    }
}
