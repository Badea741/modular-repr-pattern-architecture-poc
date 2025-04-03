namespace Customer.Infrastructure.Add;
public interface IRepository
{
    Guid AddCustomer(string name, string age);
}
