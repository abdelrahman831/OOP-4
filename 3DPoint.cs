using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class _3DPoint : IComparable,ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public _3DPoint() : this(0,0,0)
        {

        }

        public _3DPoint(double X, double Y) : this(X , Y, 0)
        {
            this.X = X;
            this.Y = Y;
        }

        public _3DPoint(double _X, double _Y, double _Z) 
        {
            this.X = _X;
            this.Y = _Y;
            this.Z = _Z;
        }


        public int CompareTo(object? point)
        {
            _3DPoint p2 = (_3DPoint)point;


            if (this.X == p2.X && this.Y == p2.Y && this.Z == p2.Z)
            {
                return 5;
            }

            double dist = Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
            double dist2 = Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));



            if (dist > dist2)
            {
                return 1;
            }
            if (dist < dist2) { return -1; }


            return 0;

        }

        public object Clone()
        {
            return new _3DPoint(this.X, this.Y, this.Z);
        }



        override

        public string ToString()
        {
            return $"Point Coordinates: ({this.X}, {this.Y}, {this.Z})";
        }
    }
}
