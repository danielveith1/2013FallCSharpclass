using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CSharpContext())
            {
                db.Contacts.Add(new Contact { FirstName = "Dan", LastName = "Veith" });
                db.SaveChanges();
                foreach (var contact in db.Contacts)
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName);
                }
                Console.ReadLine();
            }
        }
    }
}