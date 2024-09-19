using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thomsonreuters.formulae;

namespace Csharpconcept1
{
    public class Program1
    {
       
     


       static void Main(string[] args)
        {
          Console.WriteLine(Area.AreaOfTriangle(20, 5));
          //  Console.WriteLine(Area.AreaOfRectiangle(5, 6));
           Console.WriteLine(Area.AreaOfCircle(5));
            Console.WriteLine(Area.AreaOfCube(10));
            Console.WriteLine(Area.name("Prakash"));
            Console.WriteLine(Area.test(5, 6, 7));
            Area obj= new Area();
            double output = obj.AreaOfRectiangle(5, 25.2);
            Console.WriteLine(output);
            
        }


    }
}
