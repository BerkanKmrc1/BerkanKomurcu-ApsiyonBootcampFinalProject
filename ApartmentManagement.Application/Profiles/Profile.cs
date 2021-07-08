using ApartmentManagement.Application.Dto;
using ApartmentManagement.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Profiles
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<HousingAddDto, Housing>().ReverseMap();
            CreateMap<HousingUpdateDto, Housing>().ReverseMap();
            CreateMap<MessageDto, Message>().ReverseMap();

        }
    }
}
