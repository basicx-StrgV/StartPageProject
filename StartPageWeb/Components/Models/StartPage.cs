namespace StartPageWeb.Components.Models
{
    public class StartPage
    {
        /// <summary>
        /// Gets or sets the name of the start page. 
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// gets or sets if this is the main start page.
        /// </summary>
        public bool IsMainPage { get; set; } = false;
        /// <summary>
        /// Gets or sets the column list.
        /// </summary>
        public List<StartPageColumn>  Columns { get; set; } = [];
    }
}