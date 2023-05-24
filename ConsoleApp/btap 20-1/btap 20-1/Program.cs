using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bai20t1
{
    public class sinhvien
    {
        public string ht, que;
        public int nsinh;
        public sinhvien()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Moi ban nhap ten sinh vien ");
            ht = Console.ReadLine();
            Console.Write("Nhap nam sinh cua sinh vien ");
            nsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan cua sinh vien ");
            que = Console.ReadLine();
        }
    }
    public class sinhviendaihoc:sinhvien
    {
        public float diemqt, diemthi;
        public sinhviendaihoc():base()
        {

        }
        public void thongtinsvdh()
        {
            base.nhapthongtin();
            Console.Write("Moi ban nhap diem qua trinh: ");
            diemqt = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem thi: ");
            diemthi = float.Parse(Console.ReadLine());
        }
        public double dtb()
        {
           return ((diemqt + diemthi) / 2);
        }
        public void hienthi()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} ", ht, que, nsinh, diemqt, diemthi,dtb());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m;
            do
            {
                Console.Write("Nhap so sinh vien: ");
                m = int.Parse(Console.ReadLine());  
            }
            while (m <=3 );
            List<sinhviendaihoc> a = new List<sinhviendaihoc>();
            sinhviendaihoc b;
            for(int i = 0; i < m; i++)
            {
                b = new sinhviendaihoc();
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                b.thongtinsvdh();   
                a.Add(b);
            }
            Console.WriteLine("--------------Danh sach sinh vien------------");
            Console.WriteLine("| Ho ten | Que quan | nam sinh | diem qua trinh | diem thi | diem TB |");
            for(int i = 0; i < m;i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Xoa sinh vien thu 1 cua danh sach a: ");
            a.RemoveAt(0);
            Console.WriteLine("---------Danh sach sinh vien moi---------------");
            Console.WriteLine("| Ho ten | Que quan | nam sinh | diem qua trinh | diem thi | diem TB |");
            for (int i =0; i< a.Count; i++)
            {
                a[i].hienthi();    
            }
            Console.WriteLine("Chen vao danh sach b mot sinh vien moi vao vtri thu 2 va thu 3:");
            sinhviendaihoc c= new sinhviendaihoc();
            c.thongtinsvdh();
            a.Insert(1, c);
            Console.WriteLine("---------------------------");
            sinhviendaihoc d= new sinhviendaihoc();
            d.thongtinsvdh();
            a.Insert(3, d);
            Console.WriteLine("----------------Danh sach sinh vien moi 1--------------");
            Console.WriteLine("| Ho ten | Que quan | nam sinh | diem qua trinh | diem thi | diem TB |");
            for(int i=0; i< a.Count; i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Thong tin sinh vien cuoi cung cua danh sach la: ");
            a[a.Count - 1].hienthi();
            Console.ReadLine();
        }
    }

}
