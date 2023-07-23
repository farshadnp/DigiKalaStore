namespace DigiKala.WebAPI.HelperClassess.StandardOutput
{
    public class StandardOutput<T>
    {
        public bool IsSuccess { get; set; }
        public ApiResultStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

    }

    public class StandardOutput
    {
        public bool IsSuccess { get; set; }
        public ApiResultStatusCode StatusCode { get; set; }
        public string Message { get; set; }

    }
}
