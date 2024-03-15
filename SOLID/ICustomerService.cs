using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Open/Closed Principle (OCP)
    // Bir sınıf, genişletilebilir olmalı, ancak değiştirilemez olmalıdır.
    // Müşteri işlemleri için bir arayüz oluşturulur.
    interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        List<Customer> GetAll();
    }

    // CustomerManager sınıfı, müşteri işlemlerini gerçekleştiren sınıftır.
    // Ancak, işlemleri CustomerRepository üzerinden yapar.
}
