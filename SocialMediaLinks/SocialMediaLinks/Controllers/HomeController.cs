using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SocialMediaLinks.Controllers {
	public class HomeController : Controller {

		private readonly SocialMediaLinksOptions _socialMediaLinksOptions;

		public HomeController(IOptions<SocialMediaLinksOptions> socialMediaOptions) {
			_socialMediaLinksOptions = socialMediaOptions.Value;
		}

		[Route("/")]
		public IActionResult Index() {
			ViewBag.Facebook = _socialMediaLinksOptions.Facebook;
			ViewBag.Instagram = _socialMediaLinksOptions.Instagram;
			ViewBag.Youtube = _socialMediaLinksOptions.Youtube;
			ViewBag.Twitter = _socialMediaLinksOptions.Twitter;
			return View();
		}
	}
}
