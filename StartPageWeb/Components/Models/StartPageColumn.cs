using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Models
{
    public class StartPageColumn
    {
        /// <summary>
        /// Gets or sets the identifier of the column. 
        /// </summary>
        public string Identifier { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// Gets or sets the column id.
        /// </summary>
        public required int Column { get; set; }
        /// <summary>
        /// Gets or sets the column entries.
        /// </summary>
        public List<IColumnEntry> Entries { get; set; } = [];
    }
}