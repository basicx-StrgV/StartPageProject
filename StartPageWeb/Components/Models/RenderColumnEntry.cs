using StartPageWeb.Components.Enums;

namespace StartPageWeb.Components.Models
{
    public class RenderColumnEntry
    {
        /// <summary>
        /// Gets or sets the title of the column entry.
        /// </summary>
        public required string Title { get; set; }
        /// <summary>
        /// Gets or sets the identifier of the column, that the entry belongs to.
        /// </summary>
        public required string ColumnId { get; set; }
        /// <summary>
        /// Gets or sets the entry index inside the column.
        /// </summary>
        public required int Index { get; set; }
        /// <summary>
        /// Gets or sets the entry type. 
        /// </summary>
        public required ColumnEntryType Type { get; set; }
        
        /// <summary>
        /// Gets or sets the notes Markdown.
        /// </summary>
        public string Markdown { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the bookmark entries.
        /// </summary>
        public List<Bookmark> Entries { get; set; } = [];
    }
}