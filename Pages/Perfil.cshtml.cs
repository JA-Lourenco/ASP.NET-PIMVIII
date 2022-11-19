using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class PerfilModel : PageModel
    {
        private readonly ILogger<PerfilModel> _logger;

        public PerfilModel(ILogger<PerfilModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}