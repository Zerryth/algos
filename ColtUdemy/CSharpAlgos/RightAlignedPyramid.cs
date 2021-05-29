using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgos
{
    public class RightAlignedPyramid
    {
        public RightAlignedPyramid(int n)
        {
            Size = n;
        }

        public int Size { get; set; }
        public void PrintPyramid()
        {
            var pyramidStaircase = BuildPyramid();
            PrintPyramid(pyramidStaircase);
        }

        private List<string> BuildPyramid()
        {
            var pyramid = new List<string>();
            for (var i = 0; i < Size; i++)
            {
                pyramid.Add(BuildLayer(i).ToString());
            }

            return pyramid;
        }

        private void PrintPyramid(List<string> pyramid)
        {
            foreach (var layer in pyramid) Console.WriteLine(layer);
        }

        private string BuildLayer(int layerLevel)
        {
            var layer = new StringBuilder();
            // fill spaces in layer
            var space = 0;
            var spacesEnd = Size - 2 - layerLevel;
            while (space <= spacesEnd)
            {
                layer.Append(' ');
                space++;
            }

            // fill #'s in layer
            var poundStart = spacesEnd + 1;
            for (var pound = poundStart; pound < Size; pound++)
            {
                layer.Append('#');
            }

            return layer.ToString();
        }
    }
}