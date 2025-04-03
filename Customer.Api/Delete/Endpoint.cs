using Customer.Application.Delete;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Api.Delete;
internal class Endpoint(Handler handler) : ControllerBase
{
    public Response Execute(Request request)
    {
        handler.Handle(request.ToApplication());
        return new Response();
    }
}
