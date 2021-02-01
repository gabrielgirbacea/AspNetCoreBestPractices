using AutoMapper;
using JurisTempus.Data;
using JurisTempus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JurisTempus.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly BillingContext _context;
    private readonly IMapper _mapper;

    public HomeController(ILogger<HomeController> logger, BillingContext context, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }

    public IActionResult Index()
    {
      var result = _context.Clients
        .Include(c => c.Address)
        .ToArray();
      var viewModel = _mapper.Map<ClientViewModel[]>(result);

      return View(viewModel);
    }

    [HttpGet("editor/{id:int}")]
    public async Task<IActionResult> ClientEditor(int id)
    {
      var result = await _context.Clients
        .Include(c => c.Address)
        .Where(c => c.Id == id)
        .FirstOrDefaultAsync();

      return View(result);
    }

    [HttpGet("timesheet")]
    public IActionResult Timesheet()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
