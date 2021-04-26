namespace MovieRatingApp.Model.Request
{
    public class ContentSearchRequest
    {
        public string SearchInput { get; set; }
        public int? ContentTypeId { get; set; }
        public int LoadMoreCount { get; set; }
        public int PageContentSize { get; set; } = 10;
    }
}
