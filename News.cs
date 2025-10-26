using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    public class News
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public Editor Editor { get; set; }
        public Category Category { get; set; }

        public News()
        {
            Title = "Chưa có tiêu đề";
            Summary = "Chưa có nội dung";
            Date = DateTime.Now;
            Editor = new Editor();
            Category = new Category();
        }

        public News(string title, string summary, DateTime date, Editor editor, Category category)
        {
            Title = title;
            Summary = summary;
            Date = date;
            Editor = editor;
            Category = category;
        }
    }
}
