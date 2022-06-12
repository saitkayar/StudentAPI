using AutoMapper;
using StudentAPI.DomainModels;

namespace StudentAPI.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentAPI.Model.Student>().ReverseMap();
            CreateMap<Gender, StudentAPI.Model.Gender>().ReverseMap();
            CreateMap<Adress, StudentAPI.Model.Adress>().ReverseMap();
        }
    }
}
