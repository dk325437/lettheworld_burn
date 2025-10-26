using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    class ProgramHostManager
    {
        public List<ProgramHost> ProgramHostList { get; set; }

        // Khởi tạo
        public ProgramHostManager()
        {
            ProgramHostList = new List<ProgramHost>();
        }

        public ProgramHost GetProgramHost(string name, string email)
        {
            return ProgramHostList.FirstOrDefault(e =>
                (e.Firstname + " " + e.LastName).Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase)
                && e.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Tìm kiếm gần đúng (phục vụ TextBox search)
        public List<ProgramHost> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return ProgramHostList;

            keyword = keyword.ToLower();
            return ProgramHostList.Where(e =>
                e.Firstname.ToLower().Contains(keyword) ||
                e.LastName.ToLower().Contains(keyword) ||
                e.Email.ToLower().Contains(keyword) ||
                e.ProgramName.ToLower().Contains(keyword)
            ).ToList();
        }
    }
}
