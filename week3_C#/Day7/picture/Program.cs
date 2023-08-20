using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Geoshape
{ 
    public class Geoshape
    {
        protected int dim1;
        protected int dim2;
        public Geoshape()
        {
            dim1 = dim2 = 1;
        }
        public Geoshape(int x)
        {
            dim1 = dim2 = x;
        }
        public Geoshape(int x, int y)
        {
            this.dim1 = x;
            this.dim2 =y;
        }
        public virtual float CalcArea()
        {
            return 1;
        }
    }
    public class Circle : Geoshape 
    {
        public Circle() { }
        public Circle(int r) : base(r)
        {
        }
        public override float CalcArea()
        {
            return (3.14f*dim1*dim2);
        }
    }
    public class Rec : Geoshape
    {
        public Rec() { }
        public Rec(int x,int y) : base(x, y)
        {
        }
        public override float CalcArea()
        {
            return dim1*dim2;
        }
    }
    public class Tri : Geoshape
    {
        public Tri() { }
        public Tri(int b,int h) : base(b, h) { }
        public override float CalcArea()
        {
            return (0.5f*dim1*dim2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(6);
            Console.WriteLine($"Circle \nArea:{c.CalcArea()}\n-----------------------------");

            Tri t = new Tri(5,4);
            Console.WriteLine($"Triangle \nArea:{t.CalcArea()}\n-----------------------------");

            Rec r = new Rec(2, 2);
            Console.WriteLine($"Rectangle\nArea:{r.CalcArea()} \n-----------------------------");

            Geoshape[] g = new Geoshape[] { c, t, r };
            float sum = 0;
            for(int i = 0; i < g.Length; i++)
            {
                sum += g[i].CalcArea();
            }
            Console.WriteLine("SUM OF AREAS: " + sum);

        }
    }
}
