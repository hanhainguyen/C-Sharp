using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace vidu2
{
    public class sinhvien
    {
        public string ht;
        public int msv;
        public float dtp, dt;
        public void nhapthongtin()
        {
            Console.Write("ho ten sinh vien ");
            ht = Console.ReadLine();
            Console.Write("ma sinh vien ");
            msv = int.Parse(Console.ReadLine());
            Console.Write("diem thanh phan ");
            dtp = float.Parse(Console.ReadLine());
            Console.Write("diem thi ");
            dt = float.Parse(Console.ReadLine());
        }
        public double dkthp()
        {
            return (0.3 * dtp + 0.7 * dt);
        }
        public void hienthi()
        {
            Console.WriteLine("|  {0}  |  {1}   |  {2}   |  {3}   |   {4}   |", ht, msv, dtp, dt, dkthp());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0;
            Console.Write("Nhap so sinh vien ");
            m = int.Parse(Console.ReadLine());
            sinhvien[] a = new sinhvien[1000];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Thong tin sinh vien thu {0}",i+1);
                a[i] = new sinhvien();
                a[i].nhapthongtin();
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|  Ho ten   | ma sinh vien | diem TP | diem thi | diem KTHP|");
            for (int i = 0; i < m; i++)
                a[i].hienthi();
            Console.WriteLine("Danh sach sinh vien hoc lai la: ");
            for(int i = 0; i < m;i++)
            {
                if (a[i].dkthp() < 4)
                {
                    a[i].hienthi();
                    dem++;
                }
            }
            if (dem == 0)
                Console.WriteLine("Khong co sinh vien nao phai hoc lai ");
            Console.ReadKey();
        }
         
    }
}