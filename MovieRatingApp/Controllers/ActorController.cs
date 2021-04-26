using MovieRatingApp.Model;
using MovieRatingApp.Services;

namespace MovieRatingApp.Controllers
{
    public class ActorController : BaseReadController<Model.Actor, object>
    {
        public ActorController(IReadService<Actor, object> service) : base(service)
        {
        }
    }
}
