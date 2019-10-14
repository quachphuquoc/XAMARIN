using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2.Models
{
    public class LoaiHoa : List<Hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }

        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                    new Hoa {TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam"},
                    new Hoa {TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc_2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng"},
                    new Hoa {TenHoa = "Tím thuỷ chung", Gia = 45000, Hinh = "cuc_3.jpg", MoTa = "Hoa cúc tím"},
                },
                new LoaiHoa("Hoa cưới")
                {
                    new Hoa {TenHoa = "Dây tơ hồng", Gia = 250000, Hinh = "cuoi_1.jpg", MoTa = "Hoa hồng màu đậm, hoa hồng xanh, các loại lá măng"},
                    new Hoa {TenHoa = "Cầu thuỷ tinh", Gia = 220000, Hinh = "cuoi_2.jpg", MoTa = "Hoa hồng và hoa thuỷ tiên trắng"},
                    new Hoa {TenHoa = "Duyên thầm", Gia = 260000, Hinh = "cuoi_3.jpg", MoTa = "Hoa cúc trắng, baby, lá măng"},
                },
            };
            Loaihoas = l;
        }
    }
}
