using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Airport
    {
        
        private Ticket ticket;
        private string m_name = "undefined";
        private int m_places = 0;
        private int m_soldTickets = 0;

        public int CostOfSoldTickets()
        {
            return ticket.TicketCost * this.SoldTickets;
        }

        public void setCostOfTicket(int cost)
        {
            ticket.changeCost(cost);
        }

        public Airport(string name, int cost, int sold, int places)
        {
            this.Name = name;
            ticket = Ticket.getInstance(cost);
            this.SoldTickets = sold;
            this.Places = places;
        }

        public Airport() 
        {
            ticket = Ticket.getInstance(0);
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
