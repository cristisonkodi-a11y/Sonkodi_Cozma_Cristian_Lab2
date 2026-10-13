using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sonkodi_Cozma_Cristian_Lab2.Models;

namespace Sonkodi_Cozma_Cristian_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Sonkodi_Cozma_Cristian_Lab2Context _context;

    public IndexModel(Sonkodi_Cozma_Cristian_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
