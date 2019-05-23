

namespace Exercicio_Car_Interface.Entities.Service
{
    public class BrazilTaxService : ITaxService
    {
        
         double ITaxService.Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
