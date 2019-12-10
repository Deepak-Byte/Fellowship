using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    public abstract class AbstractVisitor
    {
        private AbstractChatroom abstractChatroomcase = null;
        public string name = null;

        public void send(string sms)
        {
            Console.WriteLine("{0} == >{1}",name , sms);
            abstractChatroomcase.Send(sms, this);
        }

        public abstract void Recesive(string sms);

        public void Enter(AbstractChatroom abstractChatroom)
        {
            if(abstractChatroom!=null)
            {
                Leave();
            }
            abstractChatroom.Register(this);
            abstractChatroomcase = abstractChatroom;
        }

        public void Leave()
        {
            if (abstractChatroomcase != null)
            {
                abstractChatroomcase.UnRegister(this);
                abstractChatroomcase = null;
            }
        }
    }
}
