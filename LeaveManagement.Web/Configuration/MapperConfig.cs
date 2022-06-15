﻿using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
              
        }
    }
}