using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_DATABASE
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            /*container.AddSingleton<IManager, Manager>();
            container.AddSingleton<IDBConnection, DBConnection>();*/

            container.AddSingleton<IManager, Manager>();
            container.AddSingleton<INewDBServices, NewDBServices>();
            

            return container.BuildServiceProvider();
        }


        /*public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IManager, Manager>();
            container.AddSingleton<IDBConnection, DBConnection>();

            return container.BuildServiceProvider();
        }*/
    }
}
