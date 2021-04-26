using System.Collections.Generic;
using MovieRatingApp.Database;
using MovieRatingApp.Model.Response;
using MovieRatingApp.Model.Request;

namespace MovieRatingApp.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
