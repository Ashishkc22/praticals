using Microsoft.AspNetCore.Mvc;

public class TechSkillsController : Controller
{
    public IActionResult Index()
    {
        var model = new TechSkillsViewModel
        {
            Skills = new Dictionary<string, List<string>>
        {
            { "Frontend", new List<string> { "HTML", "CSS", "JavaScript", "React", "Bootstrap" } },
            { "Backend", new List<string> { "C#", ".NET Core", "Node.js", "Express" } },
            { "Database", new List<string> { "SQL Server", "MongoDB", "MySQL" } },
            { "Tools & DevOps", new List<string> { "Git", "Docker", "Postman", "Azure" } }
        }
        };
        return View(model);
    }
}