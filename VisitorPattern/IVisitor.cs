using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public interface IVisitor
    {
        void Visitor(Vehicle vehicle);
    }
}
