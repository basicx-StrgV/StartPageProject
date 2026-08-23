using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Models
{
    public class StartPageColumn
    {
        /// <summary>
        /// Gets or sets the column id.
        /// </summary>
        public required int ColumnId { get; set; }
        /// <summary>
        /// Gets or sets the column entries.
        /// </summary>
        public List<IColumnEntry> Entries { get; set; } = [];
    }
}