using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progFrazione
{
    public partial class Form1 : Form
    {
        private Frazione frazione1;
        private Frazione frazione2; 
        public Form1()
        {
            InitializeComponent();
            frazione1 = new Frazione(1, 2);
            frazione2=new Frazione(2,3);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frazione1.semplificaFrazione();
            frazione2.semplificaFrazione();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frazione result = frazione1.Somma(frazione2);
            result.semplificaFrazione();
            listView1.Items.Add("somma"+ result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frazione result =frazione1.Sottrazione(frazione2);
            result.semplificaFrazione();
            listView1.Items.Add("differenza" + result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frazione result = frazione1.Moltiplicazione(frazione2);
            result.semplificaFrazione();
            listView1.Items.Add("prodotto" + result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frazione result = frazione1.Dividi(frazione2);
            result.semplificaFrazione();
            listView1.Items.Add("divisione" + result);
        }
    }
}
