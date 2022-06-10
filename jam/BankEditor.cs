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
            refreshOscillatorsList();
            refreshRandList();
            refreshSensList();
            refreshEnvelopesList();
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

        public void refreshOscillatorsList()
        {
            osciList.Items.Clear(); 
            for (int i=0; i < bank.Oscillators.Count; i++)
                if (bank.Oscillators[i]!=null)
                    osciList.Items.Add($"OSCILLATOR {bank.Oscillators[i].mBaseAddress:X}");
        }

        public void refreshEnvelopesList()
        {
            envList.Items.Clear();
            for (int i = 0; i < bank.Envelopes.Count; i++)
                if (bank.Envelopes[i] != null)
                    envList.Items.Add($"ENVELOPE {bank.Envelopes[i].mBaseAddress:X}");
        }

        public void refreshSensList()
        {
            sensList.Items.Clear();
            for (int i = 0; i < bank.SensorEffects.Count; i++)
                if (bank.SensorEffects[i] != null)
                    sensList.Items.Add($"SENSEFF {bank.SensorEffects[i].mBaseAddress:X}");
        }


        public void refreshRandList()
        {
            randList.Items.Clear();
            for (int i = 0; i < bank.RandomEffects.Count; i++)
                if (bank.RandomEffects[i] != null)
                    randList.Items.Add($"RANDEFF {bank.RandomEffects[i].mBaseAddress:X}");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private BankEnvelopeEditor envEd;
        private JInstrumentEnvelopev1 currentEnv;
        private JInstrumentEnvelopev1.JEnvelopeVector currentVector;

        private void envList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (envEd != null)
                envEd.Dispose();
            var bb = bank.Envelopes[envList.SelectedIndex];
            envEd = new BankEnvelopeEditor(bb);
            envTab.Controls.Add(envEd);
            envEd.Location = new Point(198, 25);
            vectorList.Items.Clear();
            for (int i=0; i < bb.points.Length;i++) 
                vectorList.Items.Add($"EnvelopeVector {i} m{bb.points[i].Mode} v{bb.points[i].Value}");
            currentEnv = bb;
            currentVector = null;
            envEd.SelectedIndex = - 1;
        }

        private void vectorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (envEd != null)
                envEd.SelectedIndex = vectorList.SelectedIndex;
            currentVector = currentEnv.points[vectorList.SelectedIndex];
            envTime.Value = currentVector.Delay;
            envVectorMode.SelectedIndex = currentVector.Mode < 10 ? currentVector.Mode : currentVector.Mode - 9;
            envValue.Value = currentVector.Value;
        }

        private void envVectorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentVector == null)
                return;
            currentVector.Mode = (ushort)(currentVector.Mode < 4 ? currentVector.Mode : currentVector.Mode + 9);
        }

        private void envTime_ValueChanged(object sender, EventArgs e)
        {
            if (currentVector == null)
                return;
            currentVector.Delay = (ushort)envTime.Value;
        }

        private void envValue_Scroll(object sender, EventArgs e)
        {
            if (currentVector == null)
                return;
            currentVector.Value = (short)envValue.Value;
        }
    }
}
