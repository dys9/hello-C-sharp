using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_C_Sharp
{
    class Point3D
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int z { get; private set; }


        public Point3D()
        {
            this.x = 0; this.y = 0; this.z = 0;
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void SortXYZ(Array arr, char c)
        {
           //
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y}, {this.z})";
        }

        public static Point3D operator +(Point3D a, Point3D b)
            => new Point3D(a.x + b.x, a.y+b.y, a.z+b.z);
        public static Point3D operator -(Point3D a, Point3D b)
            => new Point3D(a.x - b.x, a.y - b.y, a.z - b.z);


    }
}
