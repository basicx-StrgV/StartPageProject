using StartPageWeb.Components.Enums;
using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Models
{
    public class NoteEntry : IColumnEntry
    {
        /// <inheritdoc/>
        public required string Title { get; set; }
        /// <inheritdoc/>
        public string ColumnIdentifier { get; set; } = string.Empty;
        /// <inheritdoc/>
        public int Index { get; set; }
        /// <inheritdoc/>
        public required ColumnEntryType Type { get; set; }
        /// <summary>
        /// Gets or sets the notes Markdown.
        /// </summary>
        public string Markdown { get; set; } = string.Empty;
    }
}