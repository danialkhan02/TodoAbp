using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TodoAbp.Pages;

public class Index_Tests : TodoAbpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
