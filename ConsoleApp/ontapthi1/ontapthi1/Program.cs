using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ontapthi1
{
    public class lsv
    {
        public string ht, que, cnh;
        public int ns;
        public lsv()
        {

        }
        public void ntt()
        {
            Console.Write("Nhap thong tin ho ten sinh vien: ");
            ht = Console.ReadLine();
            Console.Write("Nhap thong tin que quan sinh vien: ");
            que = Console.ReadLine();
            Console.Write("Nhap thong tin chuyen nganh hoc sinh vien: ");
            cnh = Console.ReadLine();
        }

    }
    public class svdh:lsv
    {
        public float dtp, dthi;
        public svdh() : base()
        {

        }
        public void ntt1()
        {
            base.ntt();
            Console.Write("Nhap thong tin diem thanh phan sinh vien: ");
            dtp = float.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin diem thi sinh vien: ");
            dthi = float.Parse(Console.ReadLine());
        }
        public double dtb()
        {
            return (0.7 * dthi + 0.3 * dtp);
        }
        public void ht1()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} |",ht,que,cnh,ns,dtp,dthi,dtb());
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            int m = 0, dem = 0;
            do
            {
                Console.Write("Nhaps so luong sinh vien");
                m = int.Parse(Console.ReadLine());
            }
            while (m <= 3);
            List<svdh> a = new List<svdh>();
            svdh b;
            for(int i=0;i<m;i++)
            {
                b= new svdh();
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", i + 1);
                b.ntt1();
                a.Add(b);
            }
            Console.WriteLine("Danh sach sinh vien la: ");
            Console.WriteLine("|Ho ten|que quan|chuyen nganh hoc|nam sinh|diem tp|diem thi|diem TB");
            for(int i=0;i<m;i++)
            {
                a[i].ht1();
            }
            for(int i=0;i<m;i++)
            {
                if (string.Compare(a[i].cnh, "TDH") == 0 && a[i].dtb() < 8)
                {
                    dem++;
                }
            }
            if(dem>0)
            {
                Console.WriteLine("Danh sach sinh vien thoa man dk ");
                Console.WriteLine("|Ho ten|que quan|chuyen nganh hoc|nam sinh|diem tp|diem thi|diem TB");
                for(int i =0;i<m;i++)
                {
                    if (string.Compare(a[i].cnh, "TDH") == 0 && a[i].dtb() < 8)
                        a[i].ht1();
                }
            }
            if (dem < 0)
                Console.WriteLine("khong co sinh vien thoa man dk");
            Console.ReadKey();  
        }
    }
}