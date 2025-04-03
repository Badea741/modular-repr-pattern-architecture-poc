namespace Customer.Application.Delete;
public class Request(Guid id)
{
    public Guid Id { get; init; } = id;
}
