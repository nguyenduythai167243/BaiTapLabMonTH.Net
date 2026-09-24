using System;
using System.Text.RegularExpressions;

namespace Btaplab2.Baitap.Bai5
{
    /// <summary>
    /// Bài 5: Xử lý xâu ký tự
    /// 1. Nhập vào một xâu ký tự sau đó hiển thị xâu ký tự vừa nhập ra màn hình
    /// 2. Đếm xem trong xâu có bao nhiêu chữ thường, bao nhiêu chữ hoa
    /// 3. Đếm số từ trong xâu vừa nhập
    /// 4. Đếm số phụ âm và nguyên âm trong xâu vừa nhập
    /// 5. Nhập vào một xâu con và đếm xem số lần xuất hiện của xâu con trong xâu đã nhập ở trên
    /// </summary>
    public class XuLyChuoi
    {
        private string noiDung;

        public string NoiDung
        {
            get => noiDung;
            set => noiDung = value;
        }

        public XuLyChuoi()
        {
            noiDung = string.Empty;
        }

        public XuLyChuoi(string text)
        {
            noiDung = text;
        }

        // 1. Nhập xâu ký tự
        public void Nhap()
        {
            Console.Write("Nhập vào một xâu ký tự: ");
            noiDung = Console.ReadLine() ?? string.Empty;
        }

        // 1. Hiển thị xâu ký tự
        public void HienThi()
        {
            Console.WriteLine($"Xâu ký tự vừa nhập: \"{noiDung}\"");
        }

        // 2. Đếm số chữ thường và chữ hoa
        public (int chuThuong, int chuHoa) DemChuThuongVaHoa()
        {
            int chuThuong = 0;
            int chuHoa = 0;

            foreach (char c in noiDung)
            {
                if (char.IsLower(c))
                {
                    chuThuong++;
                }
                else if (char.IsUpper(c))
                {
                    chuHoa++;
                }
            }

            return (chuThuong, chuHoa);
        }

        // 3. Đếm số từ trong xâu vừa nhập
        public int DemSoTu()
        {
            if (string.IsNullOrWhiteSpace(noiDung))
                return 0;

            string[] tu = noiDung.Trim().Split(new[] { ' ', '\t', '\n', '\r', ',', '.', ';', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }

        // 4. Đếm số phụ âm và nguyên âm trong xâu vừa nhập (hỗ trợ cả tiếng Anh và tiếng Việt)
        public (int nguyenAm, int phuAm) DemNguyenAmVaPhuAm()
        {
            string danhSachNguyenAm = "aeiouyAEIOUY" +
                                      "aáàảãạăắằẳẵặâấầẩẫậ" +
                                      "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬ" +
                                      "eéèẻẽẹêếềểễệ" +
                                      "EÉÈẺẼẸÊẾỀỂỄỆ" +
                                      "iíìỉĩị" +
                                      "IÍÌỈĨỊ" +
                                      "oóòỏõọôốồổỗộơớờởỡợ" +
                                      "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ" +
                                      "uúùủũụưứừửữự" +
                                      "UÚÙỦŨỤƯỨỪỬỮỰ" +
                                      "yýỳỷỹỵ" +
                                      "YÝỲỶỸỴ";

            int nguyenAm = 0;
            int phuAm = 0;

            foreach (char c in noiDung)
            {
                if (char.IsLetter(c))
                {
                    if (danhSachNguyenAm.Contains(c))
                    {
                        nguyenAm++;
                    }
                    else
                    {
                        phuAm++;
                    }
                }
            }

            return (nguyenAm, phuAm);
        }

        // 5. Đếm số lần xuất hiện của xâu con trong xâu chính
        public int DemSoLanXuatHien(string subStr, bool phanBietHoaThuong = false)
        {
            if (string.IsNullOrEmpty(noiDung) || string.IsNullOrEmpty(subStr))
                return 0;

            StringComparison comparison = phanBietHoaThuong ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            int count = 0;
            int index = 0;

            while ((index = noiDung.IndexOf(subStr, index, comparison)) != -1)
            {
                count++;
                index += subStr.Length;
            }

            return count;
        }
    }
}
