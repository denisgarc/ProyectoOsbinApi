using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeedSolution.Entity.Dummy;

namespace SeedSolution.Business.Interfaces.Dummy
{
    public interface IUserMaintBL
    {
        void SaveClient(Client pClient);
        Client SearchClient(string document_number);
        bool Status();
        string Message();

    }
}
