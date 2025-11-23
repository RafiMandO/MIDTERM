using MIDTERM;
using System;

namespace MIDTERM
{
    internal class Package
    {
        private string description;
        private double weight;
        private double charge;
        private double distance;
        private DateTime date;
        private double cost;

        public Package()
        {
            description="No description";
            weight=0.0;
            charge=0.0;
            distance=0.0;
            date=DateTime.Now;
            cost=0.0;
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }   
        public double Charge
        {
            get { return charge; }
            set { charge = value; }
        }
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public Package(string description, double weight, double charge, double distance)
        {
            this.description = description;
            this.weight = weight;
            this.charge = charge;
            this.distance = distance;
            this.date = DateTime.Now;
            this.cost = 0.0;
        }

        public virtual double CalculateCost()
        {
            cost = weight * charge;
            return cost;
        }

        public virtual double CalculateCost(double distance)
        {
            this.distance = distance;

            double distanceCharge = (distance > 500) ? 2.0 : 1.5;

            cost = (weight * charge) + (distance * distanceCharge);
            return cost;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("DETAILS : ");
            Console.WriteLine("Description: "+description);
            Console.WriteLine("Weight: " +weight+" kg");
            Console.WriteLine("Charge per kg: "+charge);
            Console.WriteLine("Distance: " + distance+" km");
            Console.WriteLine("Date: "+date);
            Console.WriteLine("Total Cost:"+cost+" tk");
            Console.WriteLine("---------------------------");
        }
    }
}
