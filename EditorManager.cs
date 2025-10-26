using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    public class EditorManager
    {
        // Danh sách biên tập viên
        public List<Editor> EditorList { get; set; }

        // Khởi tạo
        public EditorManager()
        {
            EditorList = new List<Editor>();
        }

        public Editor GetEditor(string name, string email)
        {
            return EditorList.FirstOrDefault(e =>
                (e.Firstname + " " + e.LastName).Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase)
                && e.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Tìm kiếm gần đúng (phục vụ TextBox search)
        public List<Editor> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return EditorList;

            keyword = keyword.ToLower();
            return EditorList.Where(e =>
                e.Firstname.ToLower().Contains(keyword) ||
                e.LastName.ToLower().Contains(keyword) ||
                e.Email.ToLower().Contains(keyword) ||
                e.Department.ToLower().Contains(keyword)
            ).ToList();
        }
    }
}
