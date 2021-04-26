﻿using Newtonsoft.Json;

namespace MovieRatingApp.Model.Response
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }
        [JsonIgnore] 
        public string RefreshToken { get; set; }
    }
}
