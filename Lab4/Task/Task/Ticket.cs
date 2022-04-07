using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Ticket
    {
        public Ticket(int cost) 
        {
            this.TicketCost = cost;
        }
        public Ticket()
        {
            this.TicketCost = 0;
        }

        protected int m_ticketCost;

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
            set
            {
                m_ticketCost = value;
            }
        }           
    }
}
