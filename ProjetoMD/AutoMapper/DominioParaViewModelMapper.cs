using AutoMapper;
using ProjetoMD.Dominio.Entidades;

namespace ProjetoMD.MVC.AutoMapper
{
    public class DominioParaViewModelMapper : Profile
    {
        public override string ProfileName
        {
            get { return "'DominioParaViewModelMapper'"; }
        }
        public DominioParaViewModelMapper()
        {
            CreateMap<Categoria, Models.CategoriaViewModel>();
            CreateMap<Clientes, Models.ClientesViewModel>();
            CreateMap<Enderecos, Models.EnderecosViewModel>();
            CreateMap<Fornecedores, Models.FornecedoresViewModel>();
            CreateMap<Funcionarios, Models.FuncionariosViewModel>();
            CreateMap<Produtos, Models.ProdutosViewModel>();
            CreateMap<Saidas, Models.SaidasViewModel>();

        }
    }
}