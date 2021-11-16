using Flyweight.Flyweights;

namespace Flyweight.Models
{
    public class Tree
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TreeType TreeType { get; set; }

        public Tree(int x, int y, TreeType treeType)
        {
            this.X = x;
            this.Y = y;
            this.TreeType = treeType;
        }

        public void Draw(object map)
        {
            TreeType.Draw(map, X, Y);
        }
    }
}
