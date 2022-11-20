using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PIMVIII.Pages
{
    public class MedicoAgendaModel : PageModel
    {
        private readonly ILogger<MedicoAgendaModel> _logger;

        public MedicoAgendaModel(ILogger<MedicoAgendaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}