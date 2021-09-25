using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CustomHost.Pages
{
    public class Index_Tests : CustomHostWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
