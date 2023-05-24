using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace vidu3
{
    public class sinhvien
    {
        public string ht, que;
        public int msv, namsinh;
        public sinhvien()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Moi ban nhap ten sinh vien ");
            ht = Console.ReadLine();
            Console.Write("Nhap ma sinh vien ");
            msv = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh cua sinh vien ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan cua sinh vien ");
            que = Console.ReadLine();
        }
       
    }
    public class sinhviendaihoc:sinhvien
    {
        public float diem1, diem2, diem3, diem4, diem5;
        public sinhviendaihoc(): base()
        {

        }
        public void thongtinsvdh()
        {
            base.nhapthongtin();
            Console.Write("Moi ban nhap diem sinh vien nam 1: ");
            diem1= float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem sinh vien nam 2: ");
            diem2 = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem sinh vien nam 3: ");
            diem3 = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem sinh vien nam 4: ");
            diem4 = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap diem sinh vien nam 5: ");
            diem5 = float.Parse(Console.ReadLine());
        }
        public double dtb()
        {
            return ((diem1 + diem2 + diem3 + diem4 + diem5) / 5);
        }
        public void hienthi()
        {
           
            Console.WriteLine("| {0}  |  {1}  |  {2}   |  {3}   |   {4}  |   {5}    |   {6}  |   {7}  |   {8}   |   {9}  ", ht,msv,que,namsinh,diem1,diem2,diem3,diem4,diem5,dtb());
        }
        public void hienthi1()
        {
            Console.WriteLine("|   {0}   ",ht);
        }
    }
   class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0;
            do
            {
                Console.Write("Nhap so sinh vien: ");
                m = int.Parse(Console.ReadLine());
            }
            while(m <=3);
            sinhviendaihoc[] a = new sinhviendaihoc[1000];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Thong tin sinh vien thu {0}",i+1);
                a[i] = new sinhviendaihoc();
                a[i].thongtinsvdh();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|  Ho ten | ma sinh vien  | que quan  |  nam sinh  | diem 1 | diem 2 | diem 3 | diem 4 | diem 5 | diem tb | ");
            for (int i = 0; i < m; i++)
                a[i].hienthi();
            Console.WriteLine("Danh sach sinh vien co diem trung binh duoi 5 diem la: ");
            for(int i = 0; i < m;i++)
            {
                if (a[i].dtb() < 5)
                {
                    a[i].hienthi1();
                    dem++;
                }
            }
            if (dem == 0)
            Console.Write("Khong co sinh vien nao co diem tb duoi 5 ");
            Console.ReadKey();
        }
    }
}