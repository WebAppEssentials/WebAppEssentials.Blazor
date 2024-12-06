namespace WebAppEssentials.Services.Base;

public partial class Client : IClient
{
    public HttpClient HttpClient { get; }   
}