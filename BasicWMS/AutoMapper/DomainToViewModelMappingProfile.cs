using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BasicWMS.Model;
using BasicWMS.ViewModels;

namespace BasicWMS.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }

    }
}