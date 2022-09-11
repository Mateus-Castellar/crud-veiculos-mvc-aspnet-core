using CadastroDeVeiculosEtec.Models;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeVeiculosEtec.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Marca { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Modelo { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Fabricante { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoVeiculo Tipo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoCombustivel Combustivel { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Cor { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Chassi { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Kilometragem { get; set; }

        public bool Revisão { get; set; }

        public bool Sinistro { get; set; }

        public bool RouboFurto { get; set; }

        public bool Aluguel { get; set; }

        public bool Venda { get; set; }

        public bool Particular { get; set; }

        public string? Observacao { get; set; }
    }
}