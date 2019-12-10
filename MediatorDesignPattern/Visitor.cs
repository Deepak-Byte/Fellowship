using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    public class Visitor : AbstractVisitor
    {
        public Visitor(string names)
        {
            this.name = names;
        }

        public override void Recesive(string sms)
        {
            Console.WriteLine("{0} <== {1} ", name, sms);
        }
    }
}
