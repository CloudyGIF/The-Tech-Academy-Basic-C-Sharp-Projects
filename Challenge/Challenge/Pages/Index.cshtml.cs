using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Challenge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public DateTime Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now;
        }
        public void OnPost()
        {
            Time = DateTime.Now;
        }

       
    }
}
