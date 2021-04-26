using AutoMapper;

namespace MovieRatingApp.Mapper
{
    public class DataMapper : Profile
    {
        public DataMapper()
        {
            CreateMap<Database.Actor, Model.Actor>();
            CreateMap<Database.Content, Model.Content>().ReverseMap();
            CreateMap<Database.ContentType, Model.ContentType>();
            CreateMap<Database.Cast, Model.Cast>();
        }
    }
}
