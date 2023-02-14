using AutoMapper;
using Web.Data.DTO;
using Web.Data.Models;

namespace WebApplicationGitHub.MapConfig
{
    public class MapConfiguration:Profile
    {
        public MapConfiguration()
        {
            CreateMap<University, AddUniverDto>().ReverseMap();
            CreateMap<University, UpdUniverDto>().ReverseMap();
        }
    }
}
