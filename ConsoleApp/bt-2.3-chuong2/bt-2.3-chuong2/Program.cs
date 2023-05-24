using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bai23
{
    public class giangvien
    {
        public string tgv, dvct;
        public int mgv;
        public float hsl, namct, lcb;
        public void nhapthongtin()
        {
            Console.Write("Nhap ten giang vien ");
            tgv = Console.ReadLine();
            Console.Write("Nhap ma giang vien ");
            mgv = int.Parse(Console.ReadLine());
            Console.Write("Nhap don vi cong tac ");
            dvct = Console.ReadLine();
            Console.Write("Nhap he so luong ");
            hsl = float.Parse(Console.ReadLine());
            Console.Write("Nhap nam cong tac ");
            namct = float.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban ");
            lcb = float.Parse(Console.ReadLine());

        }
        public double tl()
        {
            return (lcb * (hsl + namct / 50));
        }
        public void hienthi()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} |",tgv,mgv,dvct,hsl,namct,lcb,tl());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0, dem1 = 0;
            Console.Write("Nhap so giang vien ");
            m = int.Parse(Console.ReadLine());
            giangvien [] a= new giangvien [1000];
            for(int i=0;i<m;i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Thong tin giang vien so {0}",i+1);
                a[i] = new giangvien();
                a[i].nhapthongtin();
            }
            Console.WriteLine("| Ho ten| Ma giang vien| Dvi cong tac| he so luong| nam cong tac| luong cban|");
            for (int i=0; i<m;i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Danh sach cac giang vien co tong luong duoi 10 trieu la:");
            Console.WriteLine("| Ho ten| Ma giang vien| Dvi cong tac| he so luong| nam cong tac| luong cban|");
            for(int i=0;i<m;i++)
            {
                if (a[i].tl() < 10000000)
                {
                    a[i].hienthi();
                    dem++;
                }
            }
            if(dem==0)
             Console.WriteLine("Khong co giang vien nao co tong luong duoi 10 trieu ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Danh sach can bo thuoc khoa Dien-dien tu la: ");
            Console.WriteLine("| Ho ten| Ma giang vien| Dvi cong tac| he so luong| nam cong tac| luong cban|");
            for (int i=0;i <m;i++)
            {
                if(string.Compare(a[i].dvct,"khoa dien-dien tu")==0)
                {
                    a[i].hienthi();
                    dem1++;
                }
            }
            if(dem1 ==0)
                Console.WriteLine("Khong co can bo nao thuoc khoa Dien-Dien tu ");
            Console.ReadKey();
        }
    }

}