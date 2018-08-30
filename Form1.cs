using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lettertype_Chaos
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Font> fonts = new List<Font>();

        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily f in System.Drawing.FontFamily.Families)
            {
                fonts.Add(new Font(f.Name, 13));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                richTextBox1.Select(i, 1);
                richTextBox1.SelectionFont = fonts[rnd.Next(0, fonts.Count)];
            }
        }
    }
}
