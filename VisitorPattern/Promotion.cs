using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public class Promotion:IVisitor
    {
        //public void Visit(Vehicle vehicle)
        //{
        //    vehicle.cost = (int)(vehicle.cost * 0.9);
        //}

        public void Visitor(Vehicle vehicle)
        {
            vehicle.cost = (int)(vehicle.cost * 0.9);
        }
    }
}
