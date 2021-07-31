using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Dyabp.Cds.Pages
{
    public class Index_Tests : CdsWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
