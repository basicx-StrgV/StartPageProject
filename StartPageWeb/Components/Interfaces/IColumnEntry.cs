using StartPageWeb.Components.Enums;

namespace StartPageWeb.Components.Interfaces
{
    public interface IColumnEntry
    {
        /// <summary>
        /// Gets or sets the title of the column entry.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the identifier of the column, that the entry belongs to.
        /// </summary>
        public string ColumnIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the entry index inside the column.
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Gets or sets the entry type. 
        /// </summary>
        public ColumnEntryType Type { get; set; }
    }
}