using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bai22
{
    public class hanghoa
    {
        public string th;
        public int mhh, sl;
        public float dg;
        public void nhapthongtin()
        {
            Console.Write("Nhap ten mat hang ");
            th=Console.ReadLine();
            Console.Write("Nhap ma hang hoa ");
            mhh= int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong hang hoa ");
            sl= int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia hang hoa ");
            dg= float.Parse(Console.ReadLine());
        }
        public double TT()
        {
            return (dg * sl);
        }
        public void hienthi()
        {
            Console.WriteLine("|  {0}   |  {1}  |  {2}   |  {3}  |  {4}   |",th,mhh,sl,dg,TT());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0;
            do
            {
                Console.Write("Nhap so hang hoa ");
                m= int.Parse(Console.ReadLine());
            }
            while(m<=2);
            hanghoa[] a= new hanghoa[1000];
            for(int i=0;i<m;i++)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Thong tin hang hoa so {0}",i+1);
                a[i]= new hanghoa();
                a[i].nhapthongtin();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Ten mat hang | Ma hang hoa | So luong | Don gia | Tong tien |");
            for(int i=0;i<m;i++)
                a[i].hienthi();
            Console.WriteLine("Danh sach cac mat hang co so luong duoi 5 la: ");
            Console.WriteLine("| Ten mat hang | Ma hang hoa | So luong | Don gia | Tong tien |");
            for (int i=0;i<m;i++)
            {
                if (a[i].sl < 5)
                {
                    a[i].hienthi();
                    dem++;
                }
            }
            if(dem==0)
                Console.Write("Khong co mat hang nao co so luong duoi 5");
            Console.ReadKey();
        }
    }
}