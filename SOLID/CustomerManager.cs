using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // CustomerManager sınıfı, müşteri işlemlerini gerçekleştiren sınıftır.
    // Ancak, işlemleri CustomerRepository üzerinden yapar.
    class CustomerManager : ICustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerManager(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerRepository.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
