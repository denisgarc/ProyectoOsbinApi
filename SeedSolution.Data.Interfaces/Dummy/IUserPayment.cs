using SeedSolution.Entity.Dummy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedSolution.Data.Interfaces.Dummy
{
    public interface IUserPayment
    {
        void SavePayment(Payment pUserPayment);
        List<Payment> SearchPayment(int pClientId);
        bool Status();
        string Message();
    }
}
