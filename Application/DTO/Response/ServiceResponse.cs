using Domain.Constants;

namespace Application.DTO.Response
{
    public class ServiceResponse
    {
        public bool Success { get; set; } = true;
        public ResponseStatus Status { get; set; } = ResponseStatus.Success;
        public string? Message { get; set; }
        public object? Data { get; set; }
        public DateTime ServerTime { get; set; } = DateTime.Now;
        public ServiceResponse Onsuccess(object? data = null)
        {
            if (data != null)
            {
                Data = data;
            }
            return this;
        }

        public ServiceResponse OnException(Exception ex)
        {
            if (ex != null)
            {
                Success = false;
                Status = ResponseStatus.InternalServerError;
                Message = ex.Message;
            }
            return this;
        }

        public ServiceResponse OnError(object? data = null, string message = "Error while procees request.", ResponseStatus status = ResponseStatus.BadRequest)
        {
            Success = false;
            Status = status;
            if (data != null)
            {
                Data = data;
            }
            if (string.IsNullOrEmpty(Message))
            {
                Message = message;
            }

            return this;
        }

        public ServiceResponse OnError(string message = "Error while procees request.", ResponseStatus status = ResponseStatus.BadRequest)
        {
            Success = false;
            Status = status;
            if (string.IsNullOrEmpty(Message))
            {
                Message = message;
            }

            return this;
        }
    }
}
