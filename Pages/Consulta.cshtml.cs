using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class ConsultaModel : PageModel
    {
        private readonly ILogger<ConsultaModel> _logger;

        public ConsultaModel(ILogger<ConsultaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}