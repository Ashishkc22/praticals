using Microsoft.AspNetCore.Mvc;

public class DownloadController : Controller
{
    private readonly IWebHostEnvironment _env;

    public DownloadController(IWebHostEnvironment env)
    {
        _env = env;
    }

    public IActionResult Index()
    {
        return View();
    }

    //public IActionResult DownloadResume()
    //{
    //    string filePath = Path.Combine(_env.WebRootPath, "downloads", "resume.pdf");

    //    if (!System.IO.File.Exists(filePath))
    //        return NotFound();

    //    return File(filePath, "application/pdf", "resume.pdf");
    //}
    public IActionResult DownloadResume()
    {
        try
        {
            // Construct the full path to the file in wwwroot/downloads
            string filePath = Path.Combine(_env.WebRootPath, "downloads", "resume.pdf");

            // Check if the file exists
            if (!System.IO.File.Exists(filePath))
            {
                // Log if needed
                return NotFound("Resume file not found.");
            }

            // Return the file with proper content type and download name
            return PhysicalFile(filePath, "application/pdf", "resume.pdf");
        }
        catch (Exception ex)
        {
            // Optionally log the exception
            // _logger.LogError(ex, "Error downloading the resume");

            return StatusCode(500, "An error occurred while trying to download the resume.");
        }
    }
}