using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public class VisitorRunerar
    {
        public void MainVisitor()
        { 
            var car = new car();
            var Truck = new Truck();
            var Plane = new Truck();

            var Promotion = new Promotion();
            car.Accept(Promotion);
            Plane.Accept(Promotion);

            var Markup = new Markup();
            Truck.Accept(Markup);

            Console.WriteLine("car => "+ car.cost);
            Console.WriteLine("Plane => " + Truck.cost);
            Console.WriteLine("Truck => " + Plane.cost);
        }
    }
}
