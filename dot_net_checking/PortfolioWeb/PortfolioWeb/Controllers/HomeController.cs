using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Name = "Ashish Krishna Choudhari",
            Intro = "I'm a passionate MERN stack developer with over 2 years of experience. I've built scalable web apps similar to OLA, Uber, and insurance platforms.",
            Tagline = "Turning ideas into powerful web solutions."
        };
        return View(model);
    }
}