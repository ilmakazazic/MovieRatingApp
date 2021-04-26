using System.Collections.Generic;

namespace MovieRatingApp.Services
{
    public interface ICastService
    {
        List<Model.Cast> GetCastByContentId(int contentId);
    }
}
