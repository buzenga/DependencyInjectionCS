using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_DATABASE
{
    public interface IManager
    {
        void Submit(Person person);
    }

    public class Manager: NewDBConnection,IManager
    {

        private readonly INewDBServices _newDBServices;

        public Manager(INewDBServices newDBServices)
        {
            _newDBServices = newDBServices;   
        }

        public void Submit(Person person)
        {
            _newDBServices.AddPerson(person);

            _newDBServices.DisplayPeople();
        }




        /*private readonly IDBConnection _dBConnection;

        public Manager(IDBConnection dBConnection)
         {
            _dBConnection = dBConnection;
         }
         
        public void Submit(Person person)
        {
            _dBConnection.AddPerson(person);

            _dBConnection.DisplayPeople();   
        }*/
    }
}
