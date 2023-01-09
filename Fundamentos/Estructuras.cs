
namespace Fundamentos
{
    struct Estructuras
    {
        public int X;
        public int Y;

        public Estructuras(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Calcular() {
            return X*Y;
        }
    }
}
 