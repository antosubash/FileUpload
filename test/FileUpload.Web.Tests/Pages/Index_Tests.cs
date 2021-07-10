using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FileUpload.Pages
{
    public class Index_Tests : FileUploadWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
