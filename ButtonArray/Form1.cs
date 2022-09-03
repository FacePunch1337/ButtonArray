using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonArray
{
    public partial class Form1 : Form
    {
        private Button button;
        public int c = 5;
        public int r = 5;
        public int id = 0;
        public int x = 0;
        public int y = 0;
        public int w = 50;
        public int h = 50;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < c; i++)
            {

                for (int u = 0; u < r; u++)
                {
                    id++;
                    button = new Button();
                    button.Text = id.ToString();
                    button.Location = new Point(x, y);
                    button.Size = new Size(w, h);
                    Controls.Add(button);

                    x += w;
                }

                x = 0;
                y += h;
            }
        }

    }
}
