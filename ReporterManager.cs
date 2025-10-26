using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    public class ReporterManager
    {
        public List<Reporter> ReporterList { get; set; }

        // Khởi tạo
        public ReporterManager()
        {
            ReporterList = new List<Reporter>();
        }

        public Reporter GetReporter(string name, string email)
        {
            return ReporterList.FirstOrDefault(e =>
                (e.Firstname + " " + e.LastName).Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase)
                && e.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Tìm kiếm gần đúng (phục vụ TextBox search)
        public List<Reporter> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return ReporterList;

            keyword = keyword.ToLower();
            return ReporterList.Where(e =>
                e.Firstname.ToLower().Contains(keyword) ||
                e.LastName.ToLower().Contains(keyword) ||
                e.Email.ToLower().Contains(keyword) ||
                e.Area.ToLower().Contains(keyword)
            ).ToList();
        }
    }
}
