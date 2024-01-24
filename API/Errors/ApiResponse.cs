namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request, try again with a vlaid request",
                401 => "you are not authorized here",
                404 => "your requested resource was not found",
                500 => "This is an internal server error, please call your technical support",
                _ => "unknown error..!"
            };
        }
    }
}