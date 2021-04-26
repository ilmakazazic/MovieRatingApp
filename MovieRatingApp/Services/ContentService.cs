using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieRatingApp.EF;
using MovieRatingApp.Model;
using MovieRatingApp.Model.Request;

namespace MovieRatingApp.Services
{
    public class ContentService : BaseCRUDService<Model.Content, Database.Content, ContentSearchRequest, object, RatingStarsRequest>
    {
        public ContentService(MovieContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Content> Get(ContentSearchRequest search = null)
        {
            var entity = _context.Set<Database.Content>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.SearchInput))
            {
                entity = entity.Where(x => x.Title.Contains(search.SearchInput) || x.Description.Contains(search.SearchInput));
            }

            if (search.ContentTypeId.HasValue)
            {
                entity = entity.Where(x => x.ContentTypeId == search.ContentTypeId);
            }

            entity = entity.Include(x => x.ContentType).OrderByDescending(x => x.RatingPoints)
                    .Skip(search.PageContentSize * search.LoadMoreCount).Take(search.PageContentSize); 
                
            var list = entity.ToList();
            return _mapper.Map<List<Model.Content>>(list);
        }

        public override Content Update(int id, RatingStarsRequest request)
        {
            var entity = _context.Set<Database.Content>().Find(id);

            if (entity.RatingPoints == 0)
            {
                entity.RatingPoints = request.RatingPoints;
            }
            else
            {
                var sum = entity.RatingPoints * entity.NumberOfRatingPoints + request.RatingPoints;
                var totalNumberOfRatings = entity.NumberOfRatingPoints + 1;
                entity.RatingPoints = sum / totalNumberOfRatings;
            }

            entity.NumberOfRatingPoints += 1;

            _context.SaveChanges();
            return _mapper.Map<Model.Content>(entity);
        }
    }
}
