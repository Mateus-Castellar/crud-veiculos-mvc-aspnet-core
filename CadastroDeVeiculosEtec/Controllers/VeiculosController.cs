using AutoMapper;
using CadastroDeVeiculosEtec.Data;
using CadastroDeVeiculosEtec.Models;
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var veiculos = _mapper
                .Map<IEnumerable<VeiculoViewModel>>(await _context.Veiculos.ToListAsync());

            return View(veiculos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Marca,Modelo,Fabricante,Tipo,Ano,Combustivel,Cor,Chassi,Kilometragem,Revisão,Sinistro,RouboFurto,Aluguel,Venda,Particular,Observacao")] VeiculoViewModel veiculoViewModel)
        {
            ValidarData(veiculoViewModel.Ano);

            ValidarCodigo(veiculoViewModel.Codigo);

            if (ModelState.IsValid is false)
                return View(veiculoViewModel);

            var veiculo = _mapper.Map<Veiculo>(veiculoViewModel);

            _context.Veiculos.Add(veiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo is null) return NotFound();

            var veiculoViewModel = _mapper.Map<VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Marca,Modelo,Fabricante,Tipo,Ano,Combustivel,Cor,Chassi,Kilometragem,Revisão,Sinistro,RouboFurto,Aluguel,Venda,Particular,Observacao")] VeiculoViewModel veiculoViewModel)
        {
            if (id != veiculoViewModel.Id)
                return NotFound();

            ValidarData(veiculoViewModel.Ano);

            ValidarCodigo(veiculoViewModel.Codigo);

            if (ModelState.IsValid is false)
                return View(veiculoViewModel);

            var veiculo = _mapper.Map<Veiculo>(veiculoViewModel);

            _context.Veiculos.Update(veiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo is null)
                return NotFound();

            return View(_mapper.Map<VeiculoViewModel>(veiculo));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo is null)
                return NotFound();

            return View(_mapper.Map<VeiculoViewModel>(veiculo));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo is null)
                return NotFound();

            _context.Veiculos.Remove(veiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //Metodos Complementares
        private void ValidarData(string ano)
        {
            var anoInformado = Convert.ToInt32(ano);
            var anoAtual = DateTime.Now.Year;

            if (anoInformado < 1900 || anoInformado > anoAtual)
                ModelState.AddModelError("", $"Selecione uma data válida entre 1900 e {anoAtual}");
        }

        private async void ValidarCodigo(string codigo)
        {
            var veiculoExiste = await _context.Veiculos
                .Where(lbda => lbda.Codigo == codigo)
                .FirstOrDefaultAsync();

            if (veiculoExiste is not null)
                ModelState.AddModelError("", "Já existe um veiculo cadastrado com este código");
        }
    }
}