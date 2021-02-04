using System;
using System.Linq;

namespace Simple_C_Sharp
{


    class Program
    {
        public static void printArray(Array array)
        {
            foreach (var arr in array)
            {
                Console.Write(arr.ToString() + "  ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            const int size = 5;
            Point3D[] Points = new Point3D[size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                Points[i] = new Point3D(r.Next(1,10) , r.Next(1, 10), r.Next(1, 10));
                Console.Write(Points[i].ToString() + "  ");
            }
            Console.WriteLine();

            Point3D temp = new Point3D();
            for (int i  = 0; i < size; i++)
            {
                temp += Points[i];
            }
            Console.WriteLine(temp.ToString());

            // x 좌표기준, 오름차순
            Array.Sort(Points, delegate (Point3D A, Point3D B) {
                return A.x.CompareTo(B.x);
            });
            printArray(Points);

            // z 좌표기준, 내름차순
            Array.Sort(Points, delegate (Point3D A, Point3D B) {
                return B.z.CompareTo(A.z);
            });
            printArray(Points);

            /*            int[] nums;
                        nums = new int[100];

                        for (var i = 0; i < 100; i++)
                        {
                            nums[i] = i - 50;
                        }
                        foreach(var i in nums)
                        {
                            Console.WriteLine(i);
                        }

                        Array.Reverse(nums);

                        foreach (var i in nums)
                        {
                            Console.WriteLine(i);
                        }*/
        }


    }
}
