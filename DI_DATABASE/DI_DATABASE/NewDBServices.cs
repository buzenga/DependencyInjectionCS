using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_DATABASE
{

    public interface INewDBServices
    {
        void AddPerson(Person person);
        void DisplayPeople();
    }

    public class NewDBServices: NewDBConnection, INewDBServices
    {
        public void AddPerson(Person person)
        {
            _sqlConnection.Open();

            string insertQuery = $@"INSERT INTO People(first_name,last_name,profession) VALUES('{person.FirstName}','{person.LastName}','{person.Profession}')";

            SqlCommand insertCommand = new SqlCommand(insertQuery, _sqlConnection);
            insertCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void DisplayPeople()
        {
            _sqlConnection.Open();

            string displayString = @"SELECT * FROM People";
            SqlCommand displayCommand = new SqlCommand(displayString, _sqlConnection);
            SqlDataReader dataReader = displayCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0).ToString());
                Console.WriteLine(dataReader.GetValue(1).ToString());
                Console.WriteLine(dataReader.GetValue(2).ToString());
                Console.WriteLine(dataReader.GetValue(3).ToString());
                Console.WriteLine();
            }
            dataReader.Close();
            _sqlConnection.Close();
        }
    }
}
