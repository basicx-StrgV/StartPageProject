using StartPageWeb.Components.Enums;
using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Models
{
    public class Bookmarks : IColumnEntry
    {
        /// <inheritdoc/>
        public required string Title { get; set; }
        /// <inheritdoc/>
        public required ColumnEntryType Type { get; set; }
    }
}