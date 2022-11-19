using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class AgendamentoModel : PageModel
    {
        private readonly ILogger<AgendamentoModel> _logger;

        public AgendamentoModel(ILogger<AgendamentoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}