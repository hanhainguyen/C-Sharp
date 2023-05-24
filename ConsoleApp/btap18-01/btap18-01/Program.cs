using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace btap1801
{
    public class hanghoa
    {
        public string thh;
        public int mhh; 
        public string hsd;
        public string nsx;
        public float dgia;
        public hanghoa()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Moi ban nhap ten hang hoa: ");
            thh = Console.ReadLine();
            Console.Write("Moi ban nhap ma hang hoa: ");
            mhh = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap don gia hang hoa: ");
            dgia = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap ngay sx hang hoa: ");
            nsx = Console.ReadLine();
            Console.Write("Moi ban nhap hsd hang hoa: ");
            hsd =Console.ReadLine();   
        }
    }
    public class hangthucpham:hanghoa
    {
        public float klg;
        public string ncc;
        public hangthucpham():base()
        {

        }
        public void thongtinhangtp()
        {
            base.nhapthongtin();
            Console.Write("Moi ban nhap khoi luong thuc pham: ");
            klg = float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap nha cung cap: ");
            ncc = Console.ReadLine();
        }
        public double TT1()
        {
            return (dgia * klg);
        }
        public void hienthihangtp()
        {
            Console.WriteLine("| {0}  | {1}  | {2}  | {3}  | {4}  | {5}  | {6}  | {7} |",thh,mhh,nsx,hsd,klg,dgia,ncc,TT1());
        }
        public void hienthihangtp2()
        {
            Console.WriteLine("|  {0}  |");
        }
    }
    public class hanggiadung:hanghoa
    {
        public int slg;
        public string hangsx;
        public hanggiadung():base()
        {

        }
        public void thongtinhanggd()
        {
            base.nhapthongtin();
            Console.Write("Moi ban nhap so luong hang gia dung: ");
            slg = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap hang san xuat: ");
            hangsx = Console.ReadLine();
        }
        public double TT2()
        {
            return (slg*dgia);
        }
        public void hienthihanggd()
        {
            Console.WriteLine("| {0}  | {1}  | {2}  | {3}  | {4}  | {5}  | {6}  | {7}  |", thh, mhh, nsx, hsd, slg,dgia, hangsx, TT2());
        }
        public void hienthihanggd2()
        {
            Console.WriteLine("|  {0}  ",thh);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0;
            double tong = 0;
            double khuyenmai = 0;
            double vat = 0;
            Console.Write("Moi ban nhap so mat hang: ");
            m= int.Parse(Console.ReadLine()); 
            hangthucpham[] a = new hangthucpham[1000];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Thong tin hang hoa thu {0}: ", i + 1);
                a[i] = new hangthucpham();
                a[i].thongtinhangtp();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("| ten hang TP | ma hang TP | NSX | HSD | khoi lg | Dgia(*100VND) | NCC | TTien*100VND |");
            for(int i=0; i < m;i++)
            {
                a[i].hienthihangtp();
            }
            for(int i=0;i < m;i++)
            {
                tong = tong + a[i].TT1();
            }
            Console.WriteLine("Tong tien: {0}", tong);
            if(tong >500)
            {
                khuyenmai = ((tong / 100) * 20);
            }
            else
                khuyenmai=0;
            Console.WriteLine("Khuyen mai 20%:  {0}", khuyenmai);
            vat = (0.1*(tong-khuyenmai));
            Console.WriteLine("VAT 10%: {0}",vat);
            Console.WriteLine("Tong tien thanh toan: {0}", tong - khuyenmai + vat);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hien thi mat hang thu 3 trong danh sach: ");
            Console.WriteLine("| ten hang TP | ma hang TP | NSX | HSD | khoi lg | Dgia(*100VND) | NCC | TTien*100VND |");
            a[2].hienthihangtp();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Danh sach cac mat hang do ba vi cung cap co khoi luong nho hon 5: ");
            for(int i=0; i < m; i++)
            {
                if(string.Compare(a[i].ncc,"Ba vì ")==0 && a[i].klg < 5)
                {
                    a[i].hienthihangtp2();
                    dem++;
                }
            }
            if(dem == 0)
            {
                Console.WriteLine("Khong co mat hang nao do ba vi cung cap hoac khoi luong duoi 5:");
            }

            int n, dem1 = 0;
            double tong2 = 0;
            double khuyenmai1 = 0;
            double vat2 = 0;
            Console.Write("Moi ban nhap so hang hoa gia dung: ");
            n= int.Parse(Console.ReadLine());
            hanggiadung[] b = new hanggiadung[1000];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Thong tin hang hoa thu {0} ",i+1);
                b[i]=new hanggiadung();
                b[i].thongtinhanggd();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("| ten hang TP | ma hang TP | NSX | HSD | so lg | Dgia(*100VND) | hang sx | TTien*100VND |");
            for (int i=0;i<n;i++)
            {
                b[i].hienthihanggd();
            }
            for (int i=0;i<n;i++)
            {
                tong2 = tong2 + b[i].TT2();
            }
            Console.WriteLine("Tong tien: {0}", tong2);
            if (tong2 > 10000)
            {
                khuyenmai1 = ((tong / 100) * 30);
            }
            else
                khuyenmai1 = 0;
            Console.WriteLine("Khuyen mai 30%:  {0}",khuyenmai1 );
            vat2 = (0.1 * (tong - khuyenmai));
            Console.WriteLine("VAT 10%: {0}", vat2);
            Console.WriteLine("Tong tien thanh toan: {0}", tong2 - khuyenmai1 + vat2);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Cac loai mat hang xuat xu japan va co so luong nho hon 5:");
            for(int i=0;i<n;i++)
            {
                if (string.Compare(b[i].hangsx, "japan") == 0 && b[i].slg < 5)
                {
                    b[i].hienthihanggd2();
                    dem1++;
                }
            }
            if (dem1 == 0)
                Console.WriteLine("Khong co loai mat hang xuat xu japan hoac co so luong nho hon 5");
            Console.ReadLine();
        }
    }
}
