using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    public class Chatroom : AbstractChatroom
    {
        public override void Send(string sms, AbstractVisitor Sender)
        {
            foreach (var visitor in activeVisitors)
            {
                if (visitor != null)
                {
                    visitor.Recesive(sms);
                }

            }
        }

        public override void Register(AbstractVisitor Visitor)
        {
            activeVisitors.Add(Visitor);
        }

        public override void UnRegister(AbstractVisitor Visitor)
        {
            activeVisitors.Remove(Visitor);
        }

        /*********************************************************************************************************/

        //public override void send(string sms, AbstractVisitor Visitor)
        //{

        //}

        //public override void Register(AbstractVisitor Visitor)
        //{
        //    activeVisitors.Add(Visitor);
        //}

        //public override void UnRegister(AbstractVisitor Visitor)
        //{
        //    activeVisitors.Remove(Visitor);
        //}
    }
}
