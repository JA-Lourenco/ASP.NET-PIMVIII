using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class MedicoPerfilModel : PageModel
    {
        private readonly ILogger<MedicoPerfilModel> _logger;

        public MedicoPerfilModel(ILogger<MedicoPerfilModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}