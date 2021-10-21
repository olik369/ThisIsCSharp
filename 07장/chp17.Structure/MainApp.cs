using static System.Console;

namespace Structure
{
    struct Point3D
    {
        public int X, Y, Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;   //선언만으로도 인스턴스 생성됨(구조체이므로)
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;    //자동으로 깊은 복사 일어남
            p3d3.Z = 400;

            WriteLine(p3d2.ToString());
            WriteLine(p3d3.ToString());
        }
    }
}