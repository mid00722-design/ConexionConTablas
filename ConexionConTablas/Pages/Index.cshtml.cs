using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConexionConTablas.Data;
using ConexionConTablas.Models;

namespace ConexionConTablas.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente NuevoCliente { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<Genero> Generos {get; set;}

        public void OnGet()
        {
            Clientes = _context.Clientes.ToList();
            Generos = _context.Generos.Include(g => g.Cliente).ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Clientes.Add(NuevoCliente);
            _context.SaveChanges();

            var genero = new Genero
            {
                GeneroTexto = NuevoCliente.Genero,
                Idcliente = NuevoCliente.Idcliente
            };

            _context.Generos.Add(genero);
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
