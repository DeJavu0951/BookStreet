using Application.DTO.Response;
using System.Net;
using System.Text.Json;

namespace BookStreetAPI.Middlewares
{
    /// <summary>
    /// Middleware xử lý exception của ứng dụng
    /// </summary>
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;
                if (ex is UnauthorizedAccessException)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    response.Status = Domain.Constants.ResponseStatus.Unauthorized;
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.Status = Domain.Constants.ResponseStatus.InternalServerError;

                }
                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
        }
    }
}
