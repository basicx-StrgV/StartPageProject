using StartPageWeb.Components.Enums;
using StartPageWeb.Components.Interfaces;

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
        public List<StartPageColumn> Columns { get; set; } = [];

        public RenderStartPage GetRenderComponents()
        {
            List<RenderColumn> columns = new List<RenderColumn>();
            List<RenderColumnEntry> entries = new List<RenderColumnEntry>();

            foreach (StartPageColumn column in Columns)
            {
                RenderColumn renderColumn = new RenderColumn()
                {
                    Identifier = Guid.NewGuid().ToString()
                };
                
                int entryIndex = 0;
                foreach (IColumnEntry columnEntry in column.Entries)
                {
                    string markdown = string.Empty;
                    List<Bookmark> bookmarks = [];
                    
                    if (columnEntry.Type == ColumnEntryType.Bookmarks && columnEntry is BookmarkGroup bookmarkGroup)
                    {
                        bookmarks = bookmarkGroup.Entries;
                    }
                    else if (columnEntry.Type == ColumnEntryType.Notes && columnEntry is NoteEntry noteEntry)
                    {
                        markdown = noteEntry.Markdown;
                    }
                    
                    RenderColumnEntry renderEntry = new RenderColumnEntry()
                    {
                        ColumnId = renderColumn.Identifier,
                        Index = entryIndex,
                        Title =  columnEntry.Title,
                        Type =  columnEntry.Type,
                        Markdown = markdown,
                        Entries =  bookmarks
                    };

                    entries.Add(renderEntry);
                    entryIndex++;
                }
                
                columns.Add(renderColumn);
            }
            
            return new RenderStartPage()
            {
                Name = this.Name,
                Columns = columns,
                Entries = entries
            };
        }
    }
}