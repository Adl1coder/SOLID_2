// Liskov Substitution Principle (LSP)
// Alt sınıflar, üst sınıfların yerine geçebilmelidir.
// Örneğin, Customer sınıfı Person sınıfından türeyebilir.
// Ancak, burada basitlik için bu özellik kullanılmamıştır.

// Interface Segregation Principle (ISP)
// İstemciye sadece ihtiyaç duyduğu metotları sunmalıdır.
// Bu prensibi göstermek için CustomerManager sınıfı tek başına kullanılmıştır.
// Ancak, gerçekte başka servisler de olabilir ve bunlar için farklı arayüzler sağlanabilir.

using SOLID;

class Program
{
    static void Main(string[] args)
    {
        // Dependency Injection kullanarak CustomerManager sınıfını kullanıyoruz.
        var customerRepository = new CustomerRepository();
        var customerManager = new CustomerManager(customerRepository);

        // Müşteri ekleme işlemi
        var newCustomer = new Customer { Id = 3, Name = "Ayşe", Email = "ayse@example.com" };
        customerManager.Add(newCustomer);

        // Tüm müşterileri listeleme işlemi
        var customers = customerManager.GetAll();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
        }
    }
}