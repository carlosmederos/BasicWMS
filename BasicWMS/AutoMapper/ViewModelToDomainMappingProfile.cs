using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BasicWMS.Model;
using BasicWMS.ViewModels;

namespace BasicWMS.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}