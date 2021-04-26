using AutoMapper;
using MovieRatingApp.EF;

namespace MovieRatingApp.Services
{
    public class BaseCRUDService<T, TDatabase, TSearch, TInsert, TUpdate> : BaseReadService<T, TDatabase, TSearch>,
        ICRUDService<T, TSearch, TInsert, TUpdate> where T : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
        where TDatabase : class
    {
        public BaseCRUDService(MovieContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual T Insert(TInsert request)
        {
            var set = _context.Set<TDatabase>();
            var entity = _mapper.Map<TDatabase>(request);
            set.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }
}
