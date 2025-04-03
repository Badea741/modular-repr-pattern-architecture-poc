using Customer.Infrastructure.AddCustomer;

namespace Customer.Infrastructure.Add;
public class Repository : IRepository
{
    public Guid AddCustomer(string name, string age)
    {
        return Guid.NewGuid();
    }
}