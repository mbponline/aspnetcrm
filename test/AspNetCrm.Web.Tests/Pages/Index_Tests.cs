using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AspNetCrm.Pages
{
    public class Index_Tests : AspNetCrmWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
