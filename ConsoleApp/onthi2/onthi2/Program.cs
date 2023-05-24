using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace onthi2
{
    public class lsv
    {
        public string ht, que, cnh;
        public lsv()
        {

        }
        public void ntt()
        {
            Console.Write("Nhap thong tin ho ten ");
            ht = Console.ReadLine();
            Console.Write("Nhap thong tin que quan");
            que = Console.ReadLine();
            Console.Write("nhap thong tin chuyen nganh hoc");
            cnh = Console.ReadLine();
        }   
    }
    public class svdh:lsv
    {
        public float dtp, dthi;
        public svdh():base()
        {

        }
        public void ntt2()
        {
            base.ntt();
            Console.Write("Nhap thong tin diem thanh phan");
            dtp = float.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin diem thi");
            dthi = float.Parse(Console.ReadLine());
        }
        public double dtb()
        {
            return (0.3 * dtp + 0.7 * dthi);
        }
        public void hthi()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} |",ht,que,cnh,dtp,dthi,dtb());
        }
    }
    public class program
    {
        static void Main(string[] args)
        {
            int m, dem = 0;
            do
            {
                Console.Write("Nhap so luong sinh vien");
                m = int.Parse(Console.ReadLine());
            }
            while (m <= 1);
            List<svdh> a = new List<svdh>();
            svdh b;
            for(int i=0;i<m;i++)
            {
                b = new svdh();
                Console.WriteLine("Thong tin sinh vien thu {0}", i + 1);
                b.ntt2();
                a.Add(b);
            }
            Console.WriteLine("Danh sach sinh vien la");
            Console.WriteLine("|Ho ten|que quan|chuyen nganh hoc|dtp|dthi|dtb|");
            for (int i = 0; i<m;i++)
            {
                a[i].hthi();
            }
            for(int i=0;i<m;i++)
            {
                if(string.Compare(a[i].cnh,"TDH")==0&&a[i].dtb()>8)
                {
                    dem++;
                }
            }
            if(dem>0)
            {
                Console.WriteLine("Danh sach sinh vien TM dk la");
                Console.WriteLine("|Ho ten|que quan|chuyen nganh hoc|dtp|dthi|dtb|");
                for(int i=0;i<m;i++)
                {
                    if (string.Compare(a[i].cnh, "TDH") == 0 && a[i].dtb() > 8)
                        a[i].hthi();
                }
            }
            if (dem == 0)
                Console.WriteLine("khong co sinh vien nao TM dk");
            Console.ReadKey();
        }
    }
}
