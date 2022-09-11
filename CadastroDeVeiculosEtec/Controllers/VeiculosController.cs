using AutoMapper;
using CadastroDeVeiculosEtec.Data;
using CadastroDeVeiculosEtec.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeVeiculosEtec.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppVeiculosContext _context;
        private readonly IMapper _mapper;

        public VeiculosController(AppVeiculosContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Veiculos
        public async Task<IActionResult> Index()
        {
            var veiculos = _mapper
                .Map<IEnumerable<VeiculoViewModel>>(await _context.Veiculos.ToListAsync());

            return View(veiculos);
        }

        // GET: Veiculos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Veiculos == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }

            return View(veiculoViewModel);
        }

        // GET: Veiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo,Fabricante,Tipo,Ano,Combustivel,Cor,Chassi,Kilometragem,Revisão,Sinistro,RouboFurto,Aluguel,Venda,Particular,Observacao")] VeiculoViewModel veiculoViewModel)
        {
            if (ModelState.IsValid)
            {
                veiculoViewModel.Id = Guid.NewGuid();
                _context.Add(veiculoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculoViewModel);
        }

        // GET: Veiculos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Veiculos == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.Veiculos.FindAsync(id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }
            return View(veiculoViewModel);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Marca,Modelo,Fabricante,Tipo,Ano,Combustivel,Cor,Chassi,Kilometragem,Revisão,Sinistro,RouboFurto,Aluguel,Venda,Particular,Observacao")] VeiculoViewModel veiculoViewModel)
        {
            if (id != veiculoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculoViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoViewModelExists(veiculoViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(veiculoViewModel);
        }

        // GET: Veiculos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Veiculos == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }

            return View(veiculoViewModel);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Veiculos == null)
            {
                return Problem("Entity set 'AppVeiculosContext.VeiculoViewModel'  is null.");
            }
            var veiculoViewModel = await _context.Veiculos.FindAsync(id);
            if (veiculoViewModel != null)
            {
                _context.Veiculos.Remove(veiculoViewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoViewModelExists(Guid id)
        {
            return (_context.Veiculos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
