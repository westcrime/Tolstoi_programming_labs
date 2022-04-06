using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Ticket
    {
        private static Ticket instance;

        private Ticket(int cost) 
        {
            this.TicketCost = cost;
        }

        protected int m_ticketCost;

        public static Ticket getInstance(int cost)
        {
            if (instance == null)
            {
                instance = new Ticket(cost);
            }
            return instance;    
        }

        public void changeCost(int cost)
        {
            this.TicketCost = cost;
        }
        public int TicketCost
        {
            get
            {
                return m_ticketCost;
            }
            private set
            {
                m_ticketCost = value;
            }
        }           
    }
}
