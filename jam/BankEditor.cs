using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jam.jaudio;

namespace jam
{
    public partial class BankEditor : UserControl
    {
        public JInstrumentBankv1 bank;
        public BankEditor(JInstrumentBankv1 bank)
        {
            this.bank = bank;
            InitializeComponent();
            refreshInstrumentList();
        }

        public void refreshInstrumentList()
        {
            instrumentList.Items.Clear();
            for (int i=0; i < bank.instruments.Length;i++)
            {
                if (bank.instruments[i] != null)
                {
                    if (bank.instruments[i].Percussion == false) 
                        instrumentList.Items.Add($"INSTRUMENT {i}");
                    else
                        instrumentList.Items.Add($"PERCUSSION {i}");

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OsciList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnkedittabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instEditorTab_Click(object sender, EventArgs e)
        {

        }

        private void lblIns_Click(object sender, EventArgs e)
        {

        }

        private void instrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void oscTab_Click(object sender, EventArgs e)
        {

        }

        private void envTab_Click(object sender, EventArgs e)
        {

        }

        private void sensEffTab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randEffTab_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
