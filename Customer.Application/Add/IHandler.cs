namespace Customer.Application.Add;
public interface IHandler
{
    public Guid Handle(Request request);
}