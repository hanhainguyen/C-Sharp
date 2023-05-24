using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
namespace ontap
{
    public class lopsv
    {
        public string ht, que;
        public int ns;
        public lopsv()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            ht= Console.ReadLine();
            Console.Write("NHap que quan sinh vien: ");
            que= Console.ReadLine();
            Console.Write("Nhap nam sinh cua sinh vien: ");
            ns= int.Parse(Console.ReadLine());
        }
    }
    public class lsvdh:lopsv
    {
        public float dqt, dthi;
        public lsvdh():base()
        {

        }
        public void nhapthongtinsvdh()
        {
            base.nhapthongtin();
            Console.Write("Nhap diem qua trinh cua sinh vien: ");
            dqt= float.Parse(Console.ReadLine());
            Console.Write("NHap diem thi cua sinh vien: ");
            dthi= float.Parse(Console.ReadLine());
        }
        public double dtb()
        {
            return ((dqt + dthi) / 2);
        }
        public void hienthi()
        {
            Console.WriteLine("| {0}  | {1}  | {2}  | {3}  | {4}  | {5}  |", ht, que, ns, dqt, dthi, dtb());
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
            while (m <= 1);
            List<lsvdh> a = new List<lsvdh>();
            lsvdh b;
            for (int i = 0; i < m; i++)
            {
                b = new lsvdh();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Thong tin sinh vien thu {0}",i+1);
                b.nhapthongtinsvdh();
                a.Add(b);
            }
            Console.WriteLine("--------------Danh sach sinh vien-----------------");
            Console.WriteLine("|  Ho ten  | Que quan  | Nam sinh | Diem qt | Diem thi | Diem TB |");
            for (int i = 0; i<m; i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Xoa sinh vien thu 1 va thu 2 cua danh sach a: ");
            a.RemoveAt(1);
            a.RemoveAt(0);
            Console.WriteLine("-----------Danh sach sinh vien moi--------------");
            Console.WriteLine("|  Ho ten  | Que quan  | Nam sinh | Diem qt | Diem thi | Diem TB |");
            for (int i = 0; i < a.Count; i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Bo sung them mot sinh vien vao vi tri dau tien cua danh sach b: ");
            lsvdh c = new lsvdh();
            c.nhapthongtinsvdh();
            a.Insert(0, c);
            Console.WriteLine("-------------Danh sach sinh vien moi--------------");
            Console.WriteLine("|  Ho ten  | Que quan  | Nam sinh | Diem qt | Diem thi | Diem TB |");
            for (int i = 0; i < a.Count; i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Nhung sinh vien co diem tb duoi 5 la: ");
            for(int i = 0; i < a.Count;i++)
            {
                if (a[i].dtb() < 5)
                    dem++;
            }
            if (dem > 0)
            {
                Console.WriteLine("|  Ho ten  | Que quan  | Nam sinh | Diem qt | Diem thi | Diem TB |");
            }
            for(int i = 0; i < a.Count;i++)
            {
                if(a[i].dtb()<5)
                {
                    a[i].hienthi();
                }
            }
            if(dem==0)
            {
                Console.WriteLine("Khong co sinh vien nao co diem tb duoi 5 ");
            }
            Console.ReadKey();  


        }
    }
}