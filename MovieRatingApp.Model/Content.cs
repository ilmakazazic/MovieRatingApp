using System;

namespace MovieRatingApp.Model
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float RatingPoints { get; set; }
        public int ContentTypeId { get; set; }
        public ContentType ContentType { get; set; }
        public string Photo { get; set; }
    }
}
