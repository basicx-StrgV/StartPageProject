namespace StartPageWeb.Components.Models
{
    public class Bookmark
    {
        /// <summary>
        /// Gets or sets the title of the bookmark.
        /// </summary>
        public required string Title { get; set; }
        /// <summary>
        /// Gets or sets the URL of the bookmarks.
        /// </summary>
        public required string Url { get; set; }
    }
}