using System;

namespace ComplexNumber_Name
{ 
    class ComplexNumber
    {
        public double r { get; set; }
        public double i { get; set; }

        #region Конструктор
        public ComplexNumber(double r, double i)
        {
            this.r = r;
            this.i = i;
        }
        #endregion

        #region Множення
        public static ComplexNumber Multipl(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.r * b.r - a.i * b.i, a.i * b.r + a.r * b.i);
        }
        #endregion

        #region Ділення
        public static ComplexNumber Divide(ComplexNumber a, ComplexNumber b)
        {
            double temp = b.r * b.r + b.i * b.i;
            return new ComplexNumber((a.r * b.r + a.i * b.i) / temp,
                (b.r * a.i - b.i * a.r) / temp);
        }
        #endregion


        #region Перегрузка
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return ComplexNumber.Divide(a, b);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return ComplexNumber.Multipl(a, b);
        }
        #endregion
    }
}