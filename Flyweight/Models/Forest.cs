using Flyweight.Factories;
using System.Collections.Generic;

namespace Flyweight.Models
{
    public class Forest
    {
        public List<Tree> Trees { get; private set; }

        public Forest()
        {
            Trees = new List<Tree>();
        }

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, treeType);
            Trees.Add(tree);
        }

        public void Draw(object map)
        {
            foreach (var tree in Trees)
                tree.Draw(map);
        }
    }
}
