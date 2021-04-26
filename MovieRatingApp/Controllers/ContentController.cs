using MovieRatingApp.Model;
using MovieRatingApp.Model.Request;
using MovieRatingApp.Services;

namespace MovieRatingApp.Controllers
{
    public class ContentController : BaseCRUDController<Model.Content, ContentSearchRequest, object, RatingStarsRequest> 
    {
        public ContentController(ICRUDService<Content, ContentSearchRequest, object, RatingStarsRequest> service) : base(service)
        {
        }
    }
}
