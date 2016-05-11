using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace traductor
{
    public partial class Form1 : Form
    {
        List<string> espanol = new List<string>();
        List<string> ingles = new List<string>();
        string linea;
        string[] partes;
        string pespanol;
        string pingles;
        int i,j;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("ListaPalabras.txt", Encoding.Default);

            while(!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                partes = linea.Split(',');
                espanol.Add(partes[0]);
                ingles.Add(partes[1]);
                    
                
            }
            

            sr.Close();
        }

        private void buttonIng_MouseClick(object sender, MouseEventArgs e)
        {
            pingles = textBoxIngles.Text;

            for (i = 0; i < espanol.Count; i++)
            {
                if (ingles[i] == pingles)
                {
                    textBoxEspanol.Text = espanol[i];
                }

            }

            
            

        }

        private void buttonEsp_MouseClick(object sender, MouseEventArgs e)
        {
            pespanol = textBoxEspanol.Text;

            for(i = 0; i < espanol.Count; i++)
            {
                if(espanol[i] == pespanol)
                {
                    textBoxIngles.Text = ingles[i];
                }

            }
            
            
        }

    }
}
