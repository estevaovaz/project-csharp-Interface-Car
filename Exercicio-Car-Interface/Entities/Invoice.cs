
using System.Globalization;

namespace Exercicio_Car_Interface.Entities
{
   public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }     

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
           
        }

        public Invoice() { }

        public double TotalPayment {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return " Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + " \nTax: "
                + Tax
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
