using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Tutorial3.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem()
            {
                Id = 1,
                Category = "Financial",
                Headline = "Lerem Ipsum 1",
                Subhead = "doro sit amet 1",
                DateLine = "Nunc tristique nec 1",
                Image = "Assets/Financial2.png"
            });

            items.Add(new NewsItem()
            {
                Id = 2,
                Category = "Financial",
                Headline = "Lerem Ipsum 2",
                Subhead = "doro sit amet 2",
                DateLine = "Nunc tristique nec 2",
                Image = "Assets/Financial3.png"
            });

            items.Add(new NewsItem()
            {
                Id = 3,
                Category = "Financial",
                Headline = "Lerem Ipsum 3",
                Subhead = "doro sit amet 3",
                DateLine = "Nunc tristique nec 3",
                Image = "Assets/Financial4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 4,
                Category = "Financial",
                Headline = "Lerem Ipsum 4",
                Subhead = "doro sit amet 4",
                DateLine = "Nunc tristique nec 4",
                Image = "Assets/Financial5.png"
            });
            items.Add(new NewsItem()
            {
                Id = 5,
                Category = "Financial",
                Headline = "Lerem Ipsum 5",
                Subhead = "doro sit amet 5",
                DateLine = "Nunc tristique nec 5",
                Image = "Assets/Financial.png"
            });
            items.Add(new NewsItem()
            {
                Id = 6,
                Category = "Food",
                Headline = "Lerem Ipsum 6",
                Subhead = "doro sit amet 6",
                DateLine = "Nunc tristique nec 6",
                Image = "Assets/Food1.png"
            });
            items.Add(new NewsItem()
            {
                Id = 7,
                Category = "Food",
                Headline = "Lerem Ipsum 7",
                Subhead = "doro sit amet 7",
                DateLine = "Nunc tristique nec 7",
                Image = "Assets/Food2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 8,
                Category = "Food",
                Headline = "Lerem Ipsum 8",
                Subhead = "doro sit amet 8",
                DateLine = "Nunc tristique nec 8",
                Image = "Assets/Food3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 9,
                Category = "Food",
                Headline = "Lerem Ipsum 9",
                Subhead = "doro sit amet 9",
                DateLine = "Nunc tristique nec 9",
                Image = "Assets/Food4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 10,
                Category = "Food",
                Headline = "Lerem Ipsum 10",
                Subhead = "doro sit amet 10",
                DateLine = "Nunc tristique nec 10",
                Image = "Assets/Food5.png"
            });
            return items;
        }
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

    }

}
