using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class DadosPessoaisModel : PageModel
    {
        private readonly ILogger<DadosPessoaisModel> _logger;

        public DadosPessoaisModel(ILogger<DadosPessoaisModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}