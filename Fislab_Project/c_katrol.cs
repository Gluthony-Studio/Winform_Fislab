using System;
namespace Fislab_Project
{
    public class c_katrol: c_friction
    {
        private new double _fs;
        private new double _fk;
        public double Fs{get{return _fs;} set{_fs = value;}}
        public double Fk{get{return _fk;} set{_fk = value;}}
        
    }
}