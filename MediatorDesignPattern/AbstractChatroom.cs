using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    public abstract class AbstractChatroom 
    {
       public List<AbstractVisitor> activeVisitors = new List<AbstractVisitor>();

        public abstract void Send(string sms , AbstractVisitor AbsVisitor );
        public abstract void UnRegister(AbstractVisitor Visitor);
        public abstract void Register(AbstractVisitor Visitor);
    }
}
