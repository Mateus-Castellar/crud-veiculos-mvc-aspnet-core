using AutoMapper;
using CadastroDeVeiculosEtec.Models;
using CadastroDeVeiculosEtec.ViewModels;

namespace CadastroDeVeiculosEtec.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
        }
    }
}