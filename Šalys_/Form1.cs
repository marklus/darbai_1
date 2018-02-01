using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Šalys_
{
    public partial class Form1 : Form
    {
        public List<Miestas> Šalys { get; private set; }


        public Form1()
        {
            InitializeComponent();
            Šalys = new List<Miestas>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void baigtiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void latvijaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkoLangas = new OpenFileDialog())
            {
                failoPasirinkoLangas.Filter= "csv failai (*.csv)|*.csv";
                failoPasirinkoLangas.Multiselect = true;

                if (failoPasirinkoLangas.ShowDialog()==DialogResult.OK)
                {
                    //MessageBox.Show(failoPasirinkoLangas.FileName);

                    foreach (var failas in failoPasirinkoLangas.FileNames)
                    {
                        var šalis = new Miestas(failas);
                        Šalys.Add(šalis);
                    }



                    //nuskaitinejimas

                   /* using (var skaitytuvas = new StreamReader
                        (failoPasirinkoLangas.FileName))
                    {
                        string eilute;
                        var eil = 0;

                        while ((eilute=skaitytuvas.ReadLine())!=null)
                        {
                            //MessageBox.Show(eilute);
                            if (eil == 0)
                            {
                                eil++;
                                continue;//soka i while pradzia
                            }
                           

                            var šalis = new Miestas(eilute);
                            Šalys.Add(šalis);
                        }

                        dataGridView1.DataSource = Šalys;
                    }*/
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
