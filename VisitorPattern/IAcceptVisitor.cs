using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.VisitorPattern
{
    public interface IAcceptVisitor
    {
        void Accept(IVisitor visitor);
    }
}
