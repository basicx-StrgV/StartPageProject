using StartPageWeb.Components.Enums;
using StartPageWeb.Components.Models;
using StartPageWeb.Components.Interfaces;

namespace StartPageWeb.Components.Handler
{
    public static class StartPageHandler
    {
        public static List<StartPage> StartPages { get; set; } = [];

        static StartPageHandler()
        {
            StartPages.Add(new StartPage()
                {
                    Name = "Main",
                    IsMainPage = true,
                    Columns =  new List<StartPageColumn>()
                    {
                        new StartPageColumn()
                        {
                            Identifier = "9f93661e-15ca-4aec-8c2c-5082b2a6e770", 
                            Column = 0,
                            Entries = new List<IColumnEntry>()
                            {
                                new Bookmarks()
                                {
                                    Title = "Homelab",
                                    ColumnIdentifier = "9f93661e-15ca-4aec-8c2c-5082b2a6e770",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "Series",
                                    ColumnIdentifier = "9f93661e-15ca-4aec-8c2c-5082b2a6e770",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new NoteEntry()
                                {
                                    Title = "Notes",
                                    ColumnIdentifier = "9f93661e-15ca-4aec-8c2c-5082b2a6e770",
                                    Type = ColumnEntryType.Notes,
                                    Markdown = "**Sample**  Sample Text"
                                }
                            }
                        },
                        new StartPageColumn()
                        {
                            Identifier = "da3d1236-90a0-45b9-92b7-300750a92543", 
                            Column = 1,
                            Entries = new List<IColumnEntry>()
                            {
                                new Bookmarks()
                                {
                                    Title = "Main",
                                    ColumnIdentifier = "da3d1236-90a0-45b9-92b7-300750a92543",
                                    Type = ColumnEntryType.Bookmarks
                                }, 
                                new Bookmarks()
                                {
                                    Title = "Streaming",
                                    ColumnIdentifier = "da3d1236-90a0-45b9-92b7-300750a92543",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "Payment",
                                    ColumnIdentifier = "da3d1236-90a0-45b9-92b7-300750a92543",
                                    Type = ColumnEntryType.Bookmarks
                                }
                            }
                        },
                        new StartPageColumn()
                        {
                            Identifier = "6dbbe1f3-1fd4-40b0-beb0-ffe30477134b", 
                            Column = 2,
                            Entries = new List<IColumnEntry>()
                            {
                                new Bookmarks()
                                {
                                    Title = "Games",
                                    ColumnIdentifier = "6dbbe1f3-1fd4-40b0-beb0-ffe30477134b",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "Bookmarks",
                                    ColumnIdentifier = "6dbbe1f3-1fd4-40b0-beb0-ffe30477134b",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "Programming",
                                    ColumnIdentifier = "6dbbe1f3-1fd4-40b0-beb0-ffe30477134b",
                                    Type = ColumnEntryType.Bookmarks
                                }
                            }
                        },
                        new StartPageColumn()
                        {
                            Identifier = "3101bb42-af64-4d7c-9057-4cc415b97d33", 
                            Column = 3,
                            Entries = new List<IColumnEntry>()
                            {
                                new Bookmarks()
                                {
                                    Title = "Shopping",
                                    ColumnIdentifier = "3101bb42-af64-4d7c-9057-4cc415b97d33",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "3D-Printing",
                                    ColumnIdentifier = "3101bb42-af64-4d7c-9057-4cc415b97d33",
                                    Type = ColumnEntryType.Bookmarks
                                },
                                new Bookmarks()
                                {
                                    Title = "Other",
                                    ColumnIdentifier = "3101bb42-af64-4d7c-9057-4cc415b97d33",
                                    Type = ColumnEntryType.Bookmarks
                                },
                            }
                        }
                    }
                });
        }
    }
}