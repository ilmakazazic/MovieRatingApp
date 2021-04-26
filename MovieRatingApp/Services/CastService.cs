using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieRatingApp.EF;
using MovieRatingApp.Model;

namespace MovieRatingApp.Services
{
    public class CastService : BaseReadService<Model.Cast, Database.Cast, object>, ICastService
    {
        public CastService(MovieContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Cast> Get(object search = null)
        {
            var entitiy = _context.Set<Database.Cast>().Include(x => x.Actor).ToList();
            return _mapper.Map<List<Model.Cast>>(entitiy);
        }

        public override Cast GetById(int id)
        {
            var entitiy = _context.Set<Database.Cast>().Include(x => x.Actor).SingleOrDefault(c => c.CastId == id);
            return _mapper.Map<Model.Cast>(entitiy);
        }

        public List<Model.Cast> GetCastByContentId(int id)
        {
            var entity =  _context.Set<Database.Cast>().Include(x => x.Actor)
                .Where(x => x.ContentId == id).ToList();
            return _mapper.Map<List<Model.Cast>>(entity);
        }
    }
}
