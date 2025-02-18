namespace Andrew.DemoApp.Application.UseCases
{
    public class BaseRequest(HttpRequestMessage request)
    {
        public HttpContent? RequestContent { get => request.Content; }
    }
}