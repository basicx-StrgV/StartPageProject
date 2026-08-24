namespace StartPageWeb.Components.Models
{
    public class RenderStartPage
    {
        /// <summary>
        /// Gets or sets the name of the start page. 
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Gets or sets the list of all columns.
        /// </summary>
        public required List<RenderColumn> Columns { get; set; } 
        /// <summary>
        /// Gets or sets the list of all entries. 
        /// </summary>
        public required List<RenderColumnEntry> Entries { get; set; }
    }
}