using SQLite;

namespace BaiTap4.Models
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaHoa { get; set; }
        public string TenHoa { get; set; }
        public int MaLoai { get; set; }
        public string MoTa { get; set; }
        public long DonGia { get; set; }
        public string Hinh { get; set; }
    }
}
