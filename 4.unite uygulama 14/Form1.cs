using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulama_14
{
    public partial class Form1 : Form
    {
        Queue kuyruk = new Queue();
        int sira= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            listele();
        }
        private void listele()
        {
            listeSiralar.Items.Clear();
            foreach(int sira in kuyruk)
            {
                listeSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikar_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            listele();
        }
    }
}
