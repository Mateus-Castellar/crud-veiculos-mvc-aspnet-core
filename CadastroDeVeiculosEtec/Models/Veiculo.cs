namespace CadastroDeVeiculosEtec.Models
{
    public class Veiculo : Entity
    {
        public string Codigo { get; set; } = default!;
        public string Marca { get; set; } = default!;
        public string Modelo { get; set; } = default!;
        public string Fabricante { get; set; } = default!;
        public TipoVeiculo Tipo { get; set; }
        public string Ano { get; set; } = default!;
        public TipoCombustivel Combustivel { get; set; }
        public string Cor { get; set; } = default!;
        public string Chassi { get; set; } = default!;
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
