using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class AgRealizadoModel : PageModel
    {
        private readonly ILogger<AgRealizadoModel> _logger;

        public AgRealizadoModel(ILogger<AgRealizadoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}