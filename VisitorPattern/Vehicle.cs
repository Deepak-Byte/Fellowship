using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public class Vehicle:IAcceptVisitor
    {
        virtual public int cost { get; set; } = 0;

        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }

    //public void Accept(IVisitor visitor)
    //{
    //    visitor.Visit(this);
    //}

    public class car : Vehicle
    {
        public override int cost { get ; set ; } = 5000;
    }

    public class Truck : Vehicle
    {
        public override int cost { get; set; } = 10000;
    }
    public class Plane : Vehicle
    {
        public override int cost { get; set; } = 50000;
    }
}
