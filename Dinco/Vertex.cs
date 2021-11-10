using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using System.Drawing;

namespace Dinco
{
    class Vertex
    {
        private double X;
        private double Y;
        private double Z;

        public Vertex()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vertex(double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        public void SetX(double _x)
        {
            X = _x;
        }

        public void SetY(double _y)
        {
            Y = _y;
        }

        public void SetZ(double _z)
        {
            Z = _z;
        }

        public double GetX()
        {
            return X;
        }

        public double GetY()
        {
            return Y;
        }

        public double GetZ()
        {
            return Z;
        }

    }
}
