using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_C_Sharp
{
    class Point3D
    {
        int x, y, z;
        public int X {
            get { return x; }
            set { x = value; } }
        public int Y
        {
            get { return y; }
            set { y = value; }}
        public int Z
        {
            get { return z; }
            set { z = value; }}

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

        public static Point3D operator +(Point3D a, Point3D b)
            => new Point3D(a.x + b.x, a.y+b.y, a.z+b.z);
        public static Point3D operator -(Point3D a, Point3D b)
            => new Point3D(a.x - b.x, a.y - b.y, a.z - b.z);
    }
}
