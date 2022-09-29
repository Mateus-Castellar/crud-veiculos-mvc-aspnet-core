using CadastroDeVeiculosEtec.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeVeiculosEtec.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "O campo deve conter {1} caracteres")]
        public string Codigo { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Marca { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Modelo { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Fabricante { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoVeiculo Tipo { get; set; }

        [MinLength(4, ErrorMessage = "O campo {0} precisa conter {1} caracteres")]
        [MaxLength(4, ErrorMessage = "O campo {0} precisa conter {1} caracteres")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ano { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoCombustivel Combustivel { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O campo deve conter entre {2} e {1} caracteres")]
        public string Cor { get; set; } = default!;

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "O campo deve conter {1} caracteres")]
        public string Chassi { get; set; } = default!;

        [DisplayName("KM")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Kilometragem { get; set; }

        public bool Revisão { get; set; }

        public bool Sinistro { get; set; }

        [DisplayName("Seguro")]
        public bool RouboFurto { get; set; }

        public bool Aluguel { get; set; }

        public bool Venda { get; set; }

        public bool Particular { get; set; }

        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "O campo contém caracteres especiais")]
        public string? Observacao { get; set; }
    }
}