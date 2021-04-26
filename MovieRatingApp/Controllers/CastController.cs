using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieRatingApp.Model;
using MovieRatingApp.Services;

namespace MovieRatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : BaseReadController<Model.Cast, object>
    {
        private readonly ICastService _castService;
        public CastController(IReadService<Cast, object> service, ICastService castService) : base(service)
        {
            _castService = castService;
        }

        [HttpGet("Content/{id}")]
        public List<Model.Cast> GetCastByContentId(int id)
        {
            return _castService.GetCastByContentId(id);
        }
    }
}
