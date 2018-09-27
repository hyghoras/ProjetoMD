using AutoMapper;

namespace ProjetoMD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(m => {
                m.AddProfile<DominioParaViewModelMapper>();
                m.AddProfile<ViewModelParaDominioMapper>();
            });
        }
    }
}