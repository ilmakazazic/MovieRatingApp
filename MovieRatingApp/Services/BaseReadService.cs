using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieRatingApp.EF;

namespace MovieRatingApp.Services
{
    public class BaseReadService<T, TDatabase, TSearch> : IReadService<T, TSearch> where T : class where TDatabase : class where TSearch : class
    {
        protected readonly MovieContext _context;
        protected readonly IMapper _mapper;

        public BaseReadService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var list = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<T>(list);
        }
    }
}
