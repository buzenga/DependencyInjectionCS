using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace DI_DATABASE
{
    internal class Program
    {
        public static readonly IServiceProvider Container = new ContainerBuilder().Build();

        static void Main(string[] args)
        {

            Person ziomek = new Person(1, "JOHN", "RAMBO", "ŻOŁNIERZ");

            var manager = Container.GetService<IManager>();
            manager.Submit(ziomek);
        }




        /*public static readonly IServiceProvider Container = new ContainerBuilder().Build();

        static void Main(string[] args)
        {

            var manager = Container.GetService<IManager>();



            Person ziomek = new Person(1, "ADAM", "KRAWIEC", "MECHANIK");

            NewDBServices nowaBaza = new NewDBServices();
            nowaBaza.AddPerson(ziomek);
            nowaBaza.DisplayPeople();



            manager.Submit(ziomek);
        }*/
    }
}