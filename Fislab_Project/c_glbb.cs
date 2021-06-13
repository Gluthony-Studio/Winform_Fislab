using System;
namespace Fislab_Project
{
    public class c_glbb
    {
        private double _s;
        private double _time;
        private double _acceleration;
        private double _vo;
        private double _vt;

        public double s{
            get{return _s;}
            set{_s = value;}
        }
        public double time{
            get{return _time;}
            set{_time = value;}
        }
        public double acceleration{
            get{return _acceleration;}
            set{ _acceleration = value;}
        }
        public double vo{
            get{return _vo;}
            set{_vo = value;}
        }
        public double vt{
            get{return _vt;}
            set{_vt = value;}
        }
        public c_glbb(){}
        public double calculateS(double Time, double Vo, double Acceleration)
        {
            s = Vo * Time + 0.5 * Acceleration * Math.Pow(Time, 2);
            return s;
        }
        public double calculateT(double S, double Vo, double Vt)
        {
            time = 2 * S / (Vo + Vt);
            return time;
        }
        public double calculatea(double time, double Vo, double Vt)
        {
            acceleration = (Vt-Vo)/time;
            return acceleration;
        }
        public double calculatevo(double Vt, double Acceleration, double Time)
        {
            vo = Vt - Acceleration * Time;
            return vo;
        }
        public double calculatevt(double Vo, double Acceleration, double Time)
        {
            vt = Vo + Acceleration * Time;
            return vt;
        }
    }
}