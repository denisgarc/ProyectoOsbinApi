using SeedSolution.Entity.Dummy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedSolution.Data.Interfaces.Dummy
{
    public interface IUserMaint
    {
        void SaveClient(Client pClient);
        Client SearchClient(string document_number);
        bool Status();
        string Message();

    }
}
