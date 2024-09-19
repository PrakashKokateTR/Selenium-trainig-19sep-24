using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomsonreuters.formulae
{
    public class Area
    {
        public static double AreaOfTriangle(double Base, double height)
        {
            return 0.5 * Base * height;

        }
        public  double AreaOfRectiangle(double width, double height)
        {
            return width * height;
        }
        public static double AreaOfCircle(int r)
        {
            return 0.5 * r * r;
        }
        public static int AreaOfCube(int a)
        {
            return 6 * a;
        }
        public static string name(string N)
        {
            return N;
        }
        public static int test(int a, int b, int c)
        {
            return c = a + b - c;
        }
        public static string GetAuthorName()
        {
            return "Prakash Kokate";
        }
    }
}
