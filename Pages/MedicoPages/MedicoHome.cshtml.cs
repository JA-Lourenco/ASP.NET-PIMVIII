using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class MedicoHomeModel : PageModel
    {
        private readonly ILogger<MedicoHomeModel> _logger;

        public MedicoHomeModel(ILogger<MedicoHomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}