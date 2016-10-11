using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoMaster.Domain.Entities;
using ProjetoMaster.MVC.ViewsModel;

namespace ProjetoMaster.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<PessoaDomain, PessoaModelView>();
        }
    }
}