using Customer.Application.Add;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Api.Add;
public class Endpoint(IHandler handler) : ControllerBase
{
    public Response Handle(Request request)
    {
        handler.Handle(request);
    }
}
