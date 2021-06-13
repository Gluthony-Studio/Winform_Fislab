using System;
namespace Fislab_Project
{
    public class c_glb
    {
        private double _s;
        private double _velocity;
        private double _time;

        public double s{
            get{return _s;}
            set{_s = value;}
        }
        public double velocity{
            get{return _velocity;}
            set{_velocity = value;}
        }
        public double time{
            get{return _time;}
            set{_time = value;}
        }
        public c_glb(){}
        public double calculateS(double Time, double Velocity)
        {
            s = Velocity * Time;
            return s;
        }
        public double calculateV(double Time, double Distance)
        {
            velocity = Distance / Time;
            return velocity;
        }
        public double calculateT(double Velocity, double Distance)
        {
            time = Distance / Velocity;
            return time;
        }
    }
}