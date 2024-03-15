using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class CustomerRepository
    {
        public void Add(Customer customer)
        {
            // Müşteriyi veritabanına ekler.
            Console.WriteLine($"{customer.Name} isimli müşteri eklendi.");
        }

        public void Update(Customer customer)
        {
            // Müşteriyi günceller.
            Console.WriteLine($"{customer.Name} isimli müşteri güncellendi.");
        }

        public void Delete(Customer customer)
        {
            // Müşteriyi siler.
            Console.WriteLine($"{customer.Name} isimli müşteri silindi.");
        }

        public List<Customer> GetAll()
        {
            // Tüm müşterileri listeler.
            return new List<Customer>
        {
            new Customer { Id = 1, Name = "Ahmet", Email = "ahmet@example.com" },
            new Customer { Id = 2, Name = "Mehmet", Email = "mehmet@example.com" }
        };
        }
    }
}
