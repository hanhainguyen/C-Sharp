using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ontap86
{
    public class lcbo
    {
        public string ten, que;
        public float nsinh, hsl, lcb;
        public lcbo()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Nhap thong tin ten can bo: ");
            ten= Console.ReadLine();
            Console.Write("Nhap thong tin que quan can bo: ");
            que= Console.ReadLine();
            Console.Write("Nhap thong tin nam sinh can bo: ");
            nsinh = float.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin hsl can bo: ");
            hsl = float.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin lcb can bo: ");
            lcb = float.Parse(Console.ReadLine());  

        }
    }
    public class gv:lcbo
    {
        public string dvct;
        public gv():base()
        {

        }
        public void nhapthongtin2()
        {
            base.nhapthongtin();
            Console.Write("Nhap thong tin DVCT can bo: ");
            dvct= Console.ReadLine();
        }
        public double tl()
        {
            return (lcb * hsl); 
        }
        public void hienthi()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} |",ten,que,nsinh,hsl,lcb,tl(),dvct);
        }
    }
    class program
    {
        static void Main(string[] args )
        {
            int m;
            do
            {
                Console.Write("Nhap so can bo: ");
                m = int.Parse(Console.ReadLine());
            }
            while (m <= 2);
            List<gv> a = new List<gv>();
            gv b;
            for (int i = 0; i < m; i++)
            {
                b = new gv();
                Console.WriteLine("thong tin can bo thu {0}",i+1);
                b.nhapthongtin2();
                a.Add(b);
            }
            Console.WriteLine("Danh sach can bo la: ");
            Console.WriteLine("| ho ten | que quan | nam sinh | hsl | lcb | tl | dvct |");
            for (int i = 0; i < m; i++)
            {
                a[i].hienthi(); 
            }
            Console.WriteLine("chen vao vtri thu 3 cua danh sach a");
            gv c = new gv();
            c.nhapthongtin2();
            a.Insert(2,c);
            Console.WriteLine("danh sach moi la: ");
            Console.WriteLine("| ho ten | que quan | nam sinh | hsl | lcb | tl | dvct |");
            for(int i = 0; i < a.Count; i++)
            {
                a[i].hienthi();
            }
        }
    }
}