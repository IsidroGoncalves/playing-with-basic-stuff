using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections;

namespace dapperconsole
{
    class Program
    {
        static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        static void Main(string[] args)
        {
            Console.Title = "testing Dapper";          
            myquerydapper();
            Console.ReadKey();
        }

        /// <summary>
        /// basic query to get all the contacts
        /// </summary>
        static void myquerydapper()
        {
           
            IDbConnection db = new SqlConnection(connection);
            var contacts = db.Query<Contact>("SELECT * FROM Contacts");

            foreach (var x in contacts)
                Console.WriteLine("{0}" +" " + "{1} ", x.FirstName,x.LastName );
        }

        
    }
}
