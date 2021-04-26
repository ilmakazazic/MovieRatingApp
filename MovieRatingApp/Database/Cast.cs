namespace MovieRatingApp.Database
{
    public class Cast
    {
        public int CastId { get; set; }
        public string Role { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int ContentId { get; set; }
        public Content Content { get; set; }
    }
}
