using StartPageWeb.Components.Enums;
using StartPageWeb.Components.Models;
using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Handler
{
    public static class StartPageHandler
    {
        /// <summary>
        /// Gets the names of all start pages.
        /// </summary>
        /// <remarks>
        /// The first entry is the main start page. 
        /// </remarks>
        public static IReadOnlyList<string> StartPageNames
        {
            get
            {
                List<string> names = new List<string>();

                foreach (StartPage startPage in _startPages)
                {
                    if (startPage.IsMainPage)
                    {
                        names.Insert(0, startPage.Name);
                    }
                    else
                    {
                        names.Add(startPage.Name);
                    }
                }

                return names;
            }
        }

        private static List<StartPage> _startPages = [];

        static StartPageHandler()
        {
            _startPages.Add(new StartPage()
            {
                Name = "Main",
                IsMainPage = true,
                Columns = new List<StartPageColumn>()
                {
                    new StartPageColumn()
                    {
                        Entries = new List<IColumnEntry>()
                        {
                            new BookmarkGroup() { Title = "Homelab", Type = ColumnEntryType.Bookmarks },
                            new BookmarkGroup() { Title = "Series", Type = ColumnEntryType.Bookmarks },
                            new NoteEntry()
                            {
                                Title = "Notes",
                                Type = ColumnEntryType.Notes,
                                Markdown = "**Sample** <br/> Sample Text"
                            }
                        }
                    },
                    new StartPageColumn()
                    {
                        Entries = new List<IColumnEntry>()
                        {
                            new BookmarkGroup() { Title = "Main", Type = ColumnEntryType.Bookmarks },
                            new BookmarkGroup()
                            {
                                Title = "Streaming", Type = ColumnEntryType.Bookmarks
                            },
                            new BookmarkGroup() { Title = "Payment", Type = ColumnEntryType.Bookmarks }
                        }
                    },
                    new StartPageColumn()
                    {
                        Entries = new List<IColumnEntry>()
                        {
                            new BookmarkGroup() { Title = "Games", Type = ColumnEntryType.Bookmarks },
                            new BookmarkGroup()
                            {
                                Title = "Bookmarks", Type = ColumnEntryType.Bookmarks
                            },
                            new BookmarkGroup()
                            {
                                Title = "Programming", Type = ColumnEntryType.Bookmarks
                            }
                        }
                    },
                    new StartPageColumn()
                    {
                        Entries = new List<IColumnEntry>()
                        {
                            new BookmarkGroup()
                            {
                                Title = "Shopping", Type = ColumnEntryType.Bookmarks
                            },
                            new BookmarkGroup()
                            {
                                Title = "3D-Printing", Type = ColumnEntryType.Bookmarks
                            },
                            new BookmarkGroup() { Title = "Other", Type = ColumnEntryType.Bookmarks },
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Gets the start page for the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the start page to get.
        /// </param>
        /// <returns>
        /// The <see cref="StartPageWeb.Components.Models.StartPage"/> instance
        /// or <see langword="null"/> if no start page with the given name exists.
        /// </returns>
        public static StartPage? GetStartPageByName(string name)
        {
            foreach (StartPage startPage in _startPages)
            {
                if (startPage.Name == name)
                {
                    return startPage;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the main start page.
        /// </summary>
        /// <returns>
        /// The main <see cref="StartPageWeb.Components.Models.StartPage"/> instance
        /// or <see langword="null"/> if no main start page exists.
        /// </returns>
        public static StartPage? GetMainStartPage()
        {
            foreach (StartPage startPage in _startPages)
            {
                if (startPage.IsMainPage)
                {
                    return startPage;
                }
            }

            return null;
        }
    }
}