using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_XtremeCinema12
{
    public class RentalOrder
    {
        public Customer customer;
        public List<Rental> items = new List<Rental>();
        public double subTotal { get; set; } = 0;

        public RentalOrder(Customer cus)
        {
            customer = cus;
        }

        public void calculate(Rental item)
        {
            // Add rental to list of rentals
            items.Add(item);

            // Get rental price
            double rentalCost = getRentalCost(item);

            // Add amount to order subtotal
            subTotal += rentalCost;
        }

        public double getRentalCost(Rental item)
        {
            double itemTotal = 0;
            // Format type check
            if (item.bluray == true)
            {
                itemTotal += 5;
            }
            else
            {
                itemTotal += 4.5;
            }

            // Is new release?
            if (item.newRelease == true)
            {
                itemTotal += 1;
            }

            // 10% off if member
            if (customer.isMember == true)
            {
                itemTotal *= .9;
            }

            return itemTotal;
        }
    }
}