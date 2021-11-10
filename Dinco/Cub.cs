using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.IO;

namespace Dinco
{
    class Cub
    {
        private int[,] Vertexes = new int[40, 40];
        private Color[] ColorV = { Color.White, Color.LawnGreen, Color.WhiteSmoke, Color.Tomato, Color.Turquoise, Color.OldLace, Color.Olive, Color.MidnightBlue, Color.PowderBlue, Color.PeachPuff, Color.LavenderBlush, Color.MediumAquamarine, Color.Red, Color.Fuchsia, Color.Cyan };
        private List<Vertex> vs_X = new List<Vertex>();
        private List<Vertex> vs_Y = new List<Vertex>();
        private List<Vertex> vs_Z = new List<Vertex>();
        private bool visibility;

        public Cub()
        {

            int[,] Vertexes = new int[,] {
            {70, 120, 70,
                120, 70, 120,
                70, 120, 70,
                120, 70, 120,
                70, 70, 70,
                70, 70, 70,
                70, 120, 70,
                120, 120, 70,
                120, 120, 120,
                120, 120, 120,
                70, 120, 70,
                120, 120, 70},
            {70, 70, 140,
                70, 140, 140,
                70, 70, 70,
                70, 70, 70,
                70, 140, 70,
                140, 70, 140,
                140, 140, 140,
                140, 140, 140,
                70, 140, 70,
                140, 70, 140,
                70, 70, 140,
                70, 140, 140},
            {80, 80, 80,
                80, 80, 80,
                80, 80, 140,
                80, 140, 140,
                80, 80, 140,
                80, 140, 140,
                80, 80, 140,
                80, 140, 140,
                80, 80, 140,
                80, 140, 140,
                140, 140, 140,
                140, 140, 140}};

            for (int i = 0; i < 36; i = i + 3)
            {
                vs_X.Add(new Vertex(Vertexes[0, i], Vertexes[1, i], Vertexes[2, i]));
                vs_Y.Add(new Vertex(Vertexes[0, i + 1], Vertexes[1, i + 1], Vertexes[2, i + 1]));
                vs_Z.Add(new Vertex(Vertexes[0, i + 2], Vertexes[1, i + 2], Vertexes[2, i + 2]));
            }

        }

        public void ToggleVisibility()
        {
            visibility = !visibility;
        }

        public bool GetVisibility()
        {
            return visibility;
        }

        public void DrawCub()
        {

            GL.Begin(PrimitiveType.Triangles);

            for (int i = 0; i < 12; i++)
            {
                GL.Color3(ColorV[i / 2]);
                GL.Vertex3(vs_X.ElementAt(i).GetX(), vs_X.ElementAt(i).GetY(), vs_X.ElementAt(i).GetZ());
                GL.Vertex3(vs_Y.ElementAt(i).GetX(), vs_Y.ElementAt(i).GetY(), vs_Y.ElementAt(i).GetZ());
                GL.Vertex3(vs_Z.ElementAt(i).GetX(), vs_Z.ElementAt(i).GetY(), vs_Z.ElementAt(i).GetZ());
            }
            GL.End();
        }


        /// LAB 5 PROBLEMA 1

        public void FallDown(ulong frames)
        {

            if (visibility)
            {
                if (frames < 70)
                {
                    GL.PushMatrix();
                    GL.Translate(0, -(long)frames, 0);
                    DrawCub();
                    GL.PopMatrix();
                }
                else
                {
                    GL.PushMatrix();
                    GL.Translate(0, -70, 0);
                    DrawCub();
                    GL.PopMatrix();
                }
                
            }

        }

    }
}
