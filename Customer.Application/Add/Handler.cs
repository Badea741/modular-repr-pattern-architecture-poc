using Customer.Infrastructure.Add;

namespace Customer.Application.Add;
public class Handler(IRepository repository) : IHandler
{
    public Guid Handle(Request request)
    {
        return Guid.NewGuid();
    }
}