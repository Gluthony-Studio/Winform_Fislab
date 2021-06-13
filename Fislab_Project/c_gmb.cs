using System;
namespace Fislab_Project
{
    public class c_gmb
    {
        private double teta;
        private double vteta;
        private double period;
        private double vlinear;
        private double radius;
        private double frecuency;
        public double calTeta(double TetaO, double Vteta, double Time)
        {
            teta = TetaO + Vteta * Time;
            return teta;
        }
        public double calVteta(double F)
        {
            vteta = 2 * Math.PI * F;
            return vteta;
        }
        public double calPeriod(double Vteta)
        {
            period = (2 * Math.PI) / Vteta;
            return period;
        }
        public double calVlin(double Vteta, double Radius)
        {
            vlinear = Vteta * Radius;
            return vlinear;
        }
        public double calRadius(double Vlin, double F)
        {
            radius = Vlin / (2 * Math.PI * F);
            return radius;
        }
        public double calFrec(double Period)
        {
            frecuency = 1 / Period;
            return frecuency;
        }
    }
}