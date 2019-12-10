using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public class Markup : IVisitor
    {
        //public void Visit(Vehicle vehicle)
        //{
        //    vehicle.cost += 7500;
        //}

        public void Visitor(Vehicle vehicle)
        {
            vehicle.cost += 7500;
        }
    }
}
