using AutoMapper;
using Core_MVC_pet_project.Data;
using Core_MVC_pet_project.Models;

namespace Core_MVC_pet_project.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
