using Flyweight.Flyweights;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight.Factories
{
    public class TreeFactory
    {
        private static List<TreeType> TreeTypes;

        /// <summary>
        /// Decide se retorna um TreeType existente ou cria um novo
        /// </summary>
        /// <param name="name">Nome da árvore</param>
        /// <param name="color">Cor da árvore</param>
        /// <param name="texture">Textura da árvore</param>
        /// <returns>Objeto Flyweight com as propriedades da árvore</returns>
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            TreeTypes ??= new List<TreeType>(); // inicializa TreeTypes caso seja null

            var treeType = TreeTypes
                .FirstOrDefault(tt =>
                    tt.Name.Equals(name)
                    && tt.Color.Equals(color)
                    && tt.Texture.Equals(texture));

            if(treeType == null)
            {
                treeType = new TreeType(name, color, texture);
                TreeTypes.Add(treeType);
            }

            return treeType;
        }
    }
}
