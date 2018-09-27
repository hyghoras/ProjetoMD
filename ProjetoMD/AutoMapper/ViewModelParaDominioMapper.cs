using AutoMapper;
using ProjetoMD.Dominio.Entidades;

namespace ProjetoMD.MVC.AutoMapper
{
    public class ViewModelParaDominioMapper : Profile
    {
        public override string ProfileName
        {
            get { return "'ViewModelParaDominioMapper'"; }
        }
        public ViewModelParaDominioMapper()
        {
            CreateMap<Models.CategoriaViewModel, Categoria>();
            CreateMap<Models.ClientesViewModel, Clientes>();
            CreateMap<Models.EnderecosViewModel, Enderecos>();
            CreateMap<Models.FornecedoresViewModel, Fornecedores>();
            CreateMap<Models.FuncionariosViewModel, Funcionarios>();
            CreateMap<Models.ProdutosViewModel, Produtos>();
            CreateMap<Models.SaidasViewModel, Saidas>();
        }
    }
}