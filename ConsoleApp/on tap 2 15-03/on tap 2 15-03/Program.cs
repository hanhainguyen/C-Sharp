using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ontap1
{
    public class cnvc
    {
        public string ht;
        public float lcb, hsl;
        public void nhapthongtin()
        {
            Console.Write("Nhap ho ten cong nhan vien chuc: ");
            ht = Console.ReadLine();
            Console.Write("Nhap luong co ban cua cong nhan vien chuc: ");
            lcb = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so luong cua cong nhan vien chuc: ");
            hsl = float.Parse(Console.ReadLine());
        }
    }
    public class cbpb : cnvc
    {
        public string dvct;
        public cbpb() : base()
        {

        }
        public void nhapthongtin1()
        {
            base.nhapthongtin();
            Console.Write("Nhap thong tin don vi cong tac: ");
            dvct = Console.ReadLine();
        }
        public double tl()
        {
            return(lcb*hsl);
        }
        public void hienthi()
        {
            Console.WriteLine("| {0}  | {1}  | {2}  | {3}  | {4}  |", ht, lcb, hsl, dvct, tl());
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int m;
            do
            {
                Console.Write("Nhap so cong nhan vien chuc: ");
                m= int.Parse(Console.ReadLine());
            }
            while(m<=2);
            List<cbpb> a = new List<cbpb>();
            cbpb b;
            for (int i = 0; i < m; i++)
            {
                b = new cbpb();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Nhap thong tin can bo thu {0}", i+1);
                b.nhapthongtin1();
                a.Add(b);
            }
            Console.WriteLine("---------Danh sach can bo phong ban-----------");
            Console.WriteLine("| Ho ten | luong cb | hs luong | DVCT | tong luong |");
            for (int i = 0;i < m;i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Chen vao vi tri thu 2 va 3 cua danh sach a moi vtri 1 can bo moi: ");
            cbpb c = new cbpb();
            c.nhapthongtin1();
            a.Insert(1, c);
            cbpb d = new cbpb();
            d.nhapthongtin1();
            a.Insert(3,d);
            Console.WriteLine("---------Danh sach can bo moi-----------");
            Console.WriteLine("| Ho ten | luong cb | hs luong | DVCT | tong luong |");
            for (int i = 0; i <a.Count; i++)
            {
                a[i].hienthi();
            }
            Console.WriteLine("Xoa di can bo phong ban thu 3 trong danh sach b: ");
            a.RemoveAt(2);
            for (int i = 0; i < a.Count; i++)
            {
                a[i].hienthi();
            }
            Console.ReadKey();
        }
    }
}