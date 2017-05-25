using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomForm
{
    class Polinom
    {
        int n; //степень полинома
        double[] Coefs; //коэффициенты полинома
        double[] Korni; //корни полинома
        bool HaveKorni=false;
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Polinom()
        {
        }

        /// <summary>
        /// Конструктор класса, задающий и коэффициенты полинома, и корни уравнения
        /// </summary>
        /// <param name="Coefs">Массив коэффициентов</param>
        /// <param name="Korni">Массив корней</param>
        public Polinom(double[] Coefs, double[] Korni)
        {
            this.Coefs = Coefs;
            this.Korni = Korni;
            this.n = Coefs.Length-1;
        }

        /// <summary>
        /// Конструктор, задающий только коэффициенты
        /// </summary>
        /// <param name="Coefs">Массив коэффициентов</param>
        public Polinom(double[] Array, bool korni)
        {
            if (korni == true)
            {
                this.Korni = Array;
                HaveKorni = true;
            }
            else
                this.Coefs = Array;
            this.n = Array.Length-1;
        }

        /// <summary>
        /// Метод позволяет найти значение полинома в указанной точке при заданных коэффициентах
        /// </summary>
        /// <param name="x">Точка, где ищется значение полинома</param>
        /// <returns>Значение полинома в этой точке</returns>
        public double PolinomZnach(double x)
        {
            double result=0;
            for (int j = 0; j < n+1; j++)
            {
                result +=Coefs[j]*Math.Pow(x,n-j);
            }
            return result;
        }

        /// <summary>
        /// Переопределенный метод ToString()
        /// </summary>
        /// <returns>Возвращает строку с видом массива</returns>
        public override string ToString()
        {
            string polinom="";
            if (HaveKorni == false)
            {
                for (int i = 0; i< Coefs.Length; i++)
                {
                    if (Coefs[i] != 0) //если коэффициент равен нулю, то пропускаем элемент
                    {
                        if (i != 0) //если строка не первая
                        {
                            if (n - i != 0 && n - i != 1) //условие для красивого отображения элементов при первой и нулевой степени
                                polinom += "+ " + Coefs[i] + "*x^" + (n - i) + " ";
                            else
                            {
                                if (n - i == 1)
                                    polinom += "+ " + Coefs[i] + "*x" +  " ";
                                else
                                    polinom += "+ " + Coefs[i] + " ";
                            }
                        }
                        else //если строка первая
                            if (n - i != 0 && n - i != 1) //условие для красивого отображения элементов при первой и нулевой степени
                                polinom += Coefs[i] + "*x^" + (n - i) + " ";
                            else
                            {
                                if (n - i == 1)
                                    polinom += Coefs[i] + "*x" +  " ";
                                else
                                    polinom += Coefs[i] + " ";
                            }
                    }
                }
            }
            polinom = polinom.TrimStart();
            if (polinom[0] == '+')
                polinom = polinom.Substring(2);
            return polinom;
        }


        /// <summary>
        /// Очистка полинома
        /// </summary>
        public void Polinom_CLear()
        {
            n = 0;
            Coefs = null;
            Korni = null;
        }

        /// <summary>
        /// Метод позволяет сложить 2 полинома
        /// </summary>
        /// <param name="polinom2">Второй полином</param>
        public void PolinomSlozh(Polinom polinom2)
        {
            Polinom temp;
            if (n < polinom2.n) //обмен полиномами, если второй полином имеет макс. степень больше макс. степени первого полинома
            {
                temp = new Polinom(this.Coefs, this.Korni);
                this.Coefs = polinom2.Coefs;
                this.Korni = polinom2.Korni;
                this.n = polinom2.n;
            }
            else
            {
                temp = new Polinom(polinom2.Coefs, polinom2.Korni);
            }
            int zaderhka = n;
            int k = 0;
            for (int i = 0; i < Coefs.Length; i++)
            {
                if (zaderhka > temp.n)
                { //пропускаем
                }
                else
                {
                    Coefs[i] += temp.Coefs[k];
                    k++;
                }
                zaderhka--;
            }
        }


        /// <summary>
        /// Вычитание двух полиномов
        /// </summary>
        /// <param name="polinom2">Второй полином</param>
        public void PolinomWych(Polinom polinom2)
        {
            Polinom temp;
            if (n < polinom2.n) //обмен двух полиномов, если макс. степень второго полинома больше макс. степени первого полинома
            {
                temp = new Polinom(this.Coefs, this.Korni);
                this.Coefs = polinom2.Coefs;
                this.Korni = polinom2.Korni;
                this.n = polinom2.n;
                for (int j = 0; j < Coefs.Length; j++)
                {
                    Coefs[j] = Coefs[j] / -1; //минусование элементов
                }
                for (int p = 0; p < temp.Coefs.Length; p++)
                {
                    temp.Coefs[p] = temp.Coefs[p] / -1;
                }
            }
            else
            {
                temp = new Polinom(polinom2.Coefs, polinom2.Korni);
            }
            int zaderhka = n;
            int k = 0;
            for (int i = 0; i < Coefs.Length; i++)
            {
                if (zaderhka > temp.n)
                {
                    zaderhka--;
                }
                else
                {
                    Coefs[i] -= temp.Coefs[k];
                    k++;
                }
                
            }
        }
    }
}
