using Microsoft.AspNetCore.Mvc.Testing;

namespace DontBroke.API.Controller.Test;

public class UserProfileControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    readonly WebApplicationFactory<Program> _webApplicationFactory;
    public UserProfileControllerTest(WebApplicationFactory<Program> webApplicationFactory)
    {
        _webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async Task Test1()
    {
        var _client = _webApplicationFactory.CreateClient();
        var result = await _client.GetAsync("/api/user-profile");
        result.EnsureSuccessStatusCode();
        var content = await result.Content.ReadAsStringAsync();
        Assert.Equal("User Profile", content);
    }
}
