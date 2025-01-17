using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
        public DateTime Timestamp { get; set; }

        // Constructor for success response with data
        public Response(T data, int statusCode = 200, string message = "Request successful.")
        {
            Success = true;
            Message = message;
            Data = data;
            StatusCode = statusCode;
            Errors = null;
            Timestamp = DateTime.UtcNow;
        }

        // Constructor for error response with a list of errors
        public Response(List<string> errors, int statusCode = 400, string message = "Request failed.")
        {
            Success = false;
            Message = message;
            Data = default;
            StatusCode = statusCode;
            Errors = errors ?? new List<string>();
            Timestamp = DateTime.UtcNow;
        }

        // Constructor for error response with a single error message
        public Response(string error, int statusCode = 400, string message = "Request failed.")
        {
            Success = false;
            Message = message;
            Data = default;
            StatusCode = statusCode;
            Errors = new List<string> { error };
            Timestamp = DateTime.UtcNow;
        }
    }


}
