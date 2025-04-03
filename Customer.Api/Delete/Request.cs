namespace Customer.Api.Delete;
public class Request
{
    public Guid Id { get; init; }
    public Application.Delete.Request ToApplication() => new Application.Delete.Request(Id);

}
