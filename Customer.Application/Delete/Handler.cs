using Customer.Infrastructure.Delete;

namespace Customer.Application.Delete;
public class Handler(IRepository repository)
{
    public Dto Handle(Request request)
    {
        repository.Delete(request.Id);
        return new Dto();
    }
}