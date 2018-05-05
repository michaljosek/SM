using AutoMapper;
using SM.Core.Domain;
using SM.Infrastructure.Paging;
using SM.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Infrastructure.IoC.Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PagedList<B07_zglo>, PagedList<B07_zgloDTO>>();
                cfg.CreateMap<B07_zglo, B07_zgloDTO>().ReverseMap();

                cfg.CreateMap<AdrAdm, AdrAdmDTO>();
                cfg.CreateMap<AdrBud, AdrBudDTO>();
                cfg.CreateMap<AdrKla, AdrKlaDTO>();
                cfg.CreateMap<AdrLok, AdrLokDTO>();
                cfg.CreateMap<AdrOsi, AdrOsiDTO>();
                cfg.CreateMap<AdrUli, AdrUliDTO>();

                cfg.CreateMap<Osoba, OsobaDTO>();
                cfg.CreateMap<Branza, BranzaDTO>();


            })
            .CreateMapper();

    }
}
