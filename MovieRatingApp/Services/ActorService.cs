using AutoMapper;
using MovieRatingApp.EF;

namespace MovieRatingApp.Services
{
    public class ActorService : BaseReadService<Model.Actor, Database.Actor, object>
    {
        public ActorService(MovieContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
