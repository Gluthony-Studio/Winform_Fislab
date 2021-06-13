using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fislab_Project
{
    class C_thermal
    {
        private double _celcius;
        private double _reamur;
        private double _kelvin;
        private double _fahrenheit;
        public double celcius
        {
            get { return _celcius; }
            set { _celcius = value; }
        }
        public double reamur
        {
            get { return _reamur; }
            set { _reamur = value; }
        }
        public double kelvin
        {
            get { return _kelvin; }
            set { _kelvin = value; }
        }
        public double fahrenheit
        {
            get { return _fahrenheit; }
            set { _fahrenheit = value; }
        }
        public void convertC(double Celcius)
        {
            fahrenheit = (9.0/5.0 * Celcius) + 32.0;
            kelvin = Celcius + 273.15;
            reamur = 4.0/5.0 * Celcius;
            celcius = Celcius;
        }
        public void convertR(double Reamur)
        {
            fahrenheit = (9.0 / 4.0 * Reamur) + 32.0;
            kelvin = (5.0 / 4.0 * Reamur) + 273.15;
            celcius = 5.0 / 4.0 * Reamur;
            reamur = Reamur;
        }
        public void convertF(double Fahrenheit)
        {
            fahrenheit = Fahrenheit;
            kelvin = 5.0 / 9.0 * (Fahrenheit + 459.67);
            celcius = 5.0 / 9.0 * (Fahrenheit - 32.0);
            reamur = 4.0 / 5.0 * (Fahrenheit - 32.0);
        }
        public void convertK(double Kelvin)
        {
            fahrenheit = (9.0 / 5.0 * Kelvin) - 459.67;
            kelvin = Kelvin;
            celcius = Kelvin - 273.15;
            reamur = 4.0 / 5.0 * (Kelvin - 273.15);
        }
    }
}
