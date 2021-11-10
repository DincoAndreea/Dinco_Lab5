using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.IO;

/// <summary>
/// LAB 5 PROBLEMA 3
/// </summary>

namespace Dinco
{
    class Obiect
    {

        private List<Vertex> vs = new List<Vertex>();

        public Obiect(string numeFisier)
        {
            try
            {
                StreamReader f1 = new StreamReader(numeFisier);
                string ln;

                while ((ln = f1.ReadLine()) != null)
                {
                    if (ln.Split(' ')[0] == "v")
                    {
                        vs.Add(new Vertex(Double.Parse(ln.Split(' ')[1]), Double.Parse(ln.Split(' ')[2]), Double.Parse(ln.Split(' ')[3])));
                    }
                }

                f1.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("Nu s-a putut citi fisierul.");
                Console.WriteLine(e.Message);
            }

        }
    }
}
