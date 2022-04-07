using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Airport
    {

        private static Airport instance;
        
        private Ticket ticket;
        private string m_name = "undefined";
        private int m_places = 0;
        private int m_soldTickets = 0;

        public static Airport Instance()
        {
            if (instance == null)
            {
                instance = new Airport();
            }
            return instance;
        }

        public static Airport Instance(string name, int cost, int sold, int places)
        {
            if (instance == null)
            {
                instance = new Airport();
                instance.Name = name;
                instance.ticket = new Ticket(cost);
                instance.SoldTickets = sold;
                instance.Places = places;
            }
            return instance;
        }

        public int CostOfSoldTickets()
        {
            return ticket.TicketCost * this.SoldTickets;
        }

        public void setCostOfTicket(int cost)
        {
            ticket.changeCost(cost);
        }

        private Airport()
        {
            ticket = new Ticket(0);
        }

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public int Places
        {
            get { return m_places; }
            set { m_places = value; }
        }

        public int SoldTickets
        {
            get { return m_soldTickets; }
            set { m_soldTickets = value; }
        }
    }
}
