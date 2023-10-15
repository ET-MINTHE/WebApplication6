using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebApplication6.Controllers;

namespace WebApplication6.UnitTests
{
	[TestFixture]
	public class HomeControllerTests
	{
		[Test]
		public void GetCustomer_IdIsZero_ReturnNotFound()
		{
			ILogger<HomeController> logger = new LoggerFactory().CreateLogger<HomeController>();

			var controller = new HomeController(logger);

			var result = controller.GetCustomer(1);

			// NotFound 
			Assert.That(result, Is.TypeOf<NotFound>());

			// NotFound or one of its derivatives 
			//            Assert.That(result, Is.InstanceOf<NotFound>());
		}

	}
}