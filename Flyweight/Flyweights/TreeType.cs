namespace Flyweight.Flyweights
{
    public class TreeType
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }

        public TreeType(string name, string color, string texture)
        {
            this.Name = name;
            this.Color = color;
            this.Texture = texture;
        }

        public void Draw(object map, int x, int y)
        {
            // Desenha árvore no mapa
        }
    }
}
