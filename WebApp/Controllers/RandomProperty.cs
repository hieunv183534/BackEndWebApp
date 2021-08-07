using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public static class RandomProperty
    {
        public static DateTime NewDOB()
        {
            return DateTime.Now.AddDays(new Random().Next(-20000, 0));
        }

        public static int NewGender()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public static string NewFullName()
        {
            List<string> ho = new List<string>() { "Nguyễn ", "Trần ", "Hồ ", "Bùi ", "Đào ", "Lê ", "Uông ", "Đỗ ", "Vũ ", "Phan ", "Phạm " }; //10

            List<string> dem = new List<string>() { "Văn ", "Thị ", "Minh ", "Đức ", "Trọng ", "Huỳnh ", "Bảo ", "Quốc ", "Ngọc ", "Đình ", "Trường ", "Long " }; //11

            List<string> ten = new List<string>() { "Hiếu", "Trâm", "Thắng", "Phi", "Đức", "Nhật", "Na", "Thông", "Ánh", "Hà", "Giang", "Sơn", "Linh", "Thơm", "Long" }; //14

            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();

            return ho[random1.Next(0, 11)] + dem[random2.Next(0, 12)] + ten[random3.Next(0, 15)];
        }

        public static string NewAddress()
        {
            List<string> tinh = new List<string>() { "Hà Tĩnh", "Hà Nội", "Nghệ An", "Thanh Hóa", "Quảng Bình", "Quảng Trị", "Đà Nẵng", "Long An", "Cần Thơ", "Cao Bằng", "Kon Tum", "Bắc Giang", "Hưng Yên", "Hải Phòng", "Bắc Kạn" }; //14
            Random random = new Random();

            return tinh[random.Next(0, 15)];
        }

        public static string NewEmail()
        {
            Random random = new Random();
            return "nhanvien" + random.Next(100, 999) + ".misa@gmail.com";
        }

        public static string NewPhoneNumber()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            return "09" + random1.Next(1000, 9999).ToString() + random2.Next(1000, 9999).ToString();
        }

        public static int NewDebit()
        {
            return new Random().Next(1000000, 90000000);
        }

        public static string NewCustomerTypeId()
        {
            List<string> id = new List<string>() { "khdg", "khln", "khqb", "khm", "khvip" };
            return id[new Random().Next(0, 5)];
        }

        public static string NewPositionId()
        {
            List<string> id = new List<string>() { "bv", "ct", "db", "gd", "lt" , "nv" ,"pv", "ql", "sp"};
            return id[new Random().Next(0, 9)];
        }

        public static string NewIdentityNumber()
        {
            return new Random().Next(100000000, 999999999).ToString();
        }

        public static int NewSalary()
        {
            return new Random().Next(10000000, 50000000);
        }

        public static DateTime NewJoinDate()
        {
            return DateTime.Now.AddDays(new Random().Next(-3500, 0));
        }

        public static int NewWorkStatus()
        {
            return new Random().Next(1, 4);
        }
    }
}
