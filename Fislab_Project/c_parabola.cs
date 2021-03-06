using System;
namespace Fislab_Project
{
    public class c_parabola
    {
        private double vox;
        private double voy;
        private double vx;
        private double vy;
        private double s;
        private double smax;
        private double h;
        private double hmax;
        public double calVox(double Vo, double Alpha)
        {
            vox = Vo * Math.Cos( Alpha * (Math.PI / 180f));
            
            return vox;
        }
        public double calVoy(double Vo, double Alpha)
        {
            voy = Vo * Math.Sin(Alpha * (Math.PI / 180f));
            
            return voy;
        }
        public double calVx(double Vo, double Alpha, double Gravitation, double Time)
        {
            vx = Vo * Math.Sin(Alpha * (Math.PI / 180f)) - Gravitation * Time;
            
            return vx;
        }
        public double calVy(double Vo, double Alpha, double Gravitation, double Time)
        {
            vy = Vo * Math.Sin(Alpha * (Math.PI / 180f)) - Gravitation * Time;
            
            return vy;
        }
        public double calS(double Vo, double Time, double Alpha)
        {
            s = Vo * Time * Math.Cos(Alpha * (Math.PI / 180f));
            
            return s;
        }
        public double calSmax(double Vo, double Alpha, double Gravitation)
        {
            smax = (Math.Pow(Vo, 2) * Math.Sin(2 * Alpha * (Math.PI / 180f))) / Gravitation;
            
            return smax;
        }
        public double calH(double Vo, double Time, double Alpha, double Gravitation)
        {
            h = Vo * Time * Math.Sin( Alpha * (Math.PI / 180f)) - Gravitation * Math.Pow(Time, 2);
            
            return h;
        }
        public double calHmax(double Vo, double Alpha, double Gravitation)
        {
            hmax = (Math.Pow(Vo, 2) * Math.Pow(Math.Sin(Alpha * (Math.PI / 180f)), 2)) / (2 * Gravitation);
            
            return hmax;
        }
    }
}