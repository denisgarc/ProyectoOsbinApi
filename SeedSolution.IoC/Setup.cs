using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using SeedSolution.Data.Connection;
using SeedSolution.Data.Connection.Interfaces;
using SeedSolution.Data.SecurityAcces;
using SeedSolution.Data.Interfaces.SecurityAcces;
using SeedSolution.Business.SecurityAccess;
using SeedSolution.Business.Interfaces;

using SeedSolution.Business.Dummy;
using SeedSolution.Business.Interfaces.Dummy;
using SeedSolution.Data.Interfaces.Dummy;
using SeedSolution.Data.Dummy;

namespace SeedSolution.IoC
{
    public class Setup
    {
        public static void ConfigureIoC(Action<ConfigurationExpression> MoreIoCConfigurations)
        {
            ObjectFactory.Configure(x =>
            {   
                x.For<IConnectionTools>().Use<MSSQLTools>();
                x.For<ISysUser>().Use<SysUserDB>();
                x.For<ISecurityAccesBL>().Use<SecurtiyAccesBL>();
                x.For<IUserMaint>().Use<UserMaint>();
                x.For<IUserPayment>().Use<UserPayment>();
                x.For<IUserMaintBL>().Use<DummyBL>();
                x.For<IUserPaymentBL>().Use<DummyBL>();

                //Más configuraciones
                MoreIoCConfigurations(x);
            });
        }
    }
}
