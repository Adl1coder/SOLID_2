# Müşteri Yönetim Uygulaması

Bu basit C# konsol uygulaması, SOLID prensiplerine uygun bir şekilde yazılmıştır. Aşağıdaki prensipleri içerir:

- **Single Responsibility Principle (SRP)**: Her sınıfın, fonksiyonun ve metotun tek bir sorumluluğu vardır.
- **Open/Closed Principle (OCP)**: Bir sınıf, genişletilebilir olmalı, ancak değiştirilemez olmalıdır.
- **Liskov Substitution Principle (LSP)**: Alt sınıflar, üst sınıfların yerine geçebilmelidir.
- **Interface Segregation Principle (ISP)**: İstemciye sadece ihtiyaç duyduğu metotları sunmalıdır.

## Nasıl ?

1. Bu projeyi yerel makinenize klonlayın.
2. Visual Studio veya benzeri bir C# derleyici kullanarak projeyi açın.
3. `Program.cs` dosyasındaki `Main` metodu içindeki kodları inceleyin.
4. Projeyi derleyip çalıştırarak uygulamayı test edin.

## Örnek 

```csharp
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
