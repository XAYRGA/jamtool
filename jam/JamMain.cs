using jam.jaudio;
using Be.IO;

namespace jam
{
    public partial class JamMain : Form
    {
        AudioArchive audioArchive;
        UserControl currentEditor; 

        public JamMain()
        {
            InitializeComponent();
        }

        private void openToolMenu(object sender, EventArgs e)
        {
            if (openAADialog.ShowDialog() == DialogResult.OK)
            {
                var stm = openAADialog.OpenFile();
                audioArchive = AudioArchive.CreateFromStream(new Be.IO.BeBinaryReader(stm));
                stm.Close();
            }
            rebuildTree();
        }

        private void rebuildTree()
        {
            if (audioArchive.Instruments!=null)
            {
                var bnks = AudioTree.Nodes.Add("BANKS");
                for (int i = 0; i < audioArchive.Instruments.Count; i++)
                    bnks.Nodes.Add($"B{i}",$"INSTBANK {audioArchive.Instruments[i].globalID}");
               
            }

            if (audioArchive.WaveSystems!= null)
            {
                var bnks = AudioTree.Nodes.Add("WAVES");
                for (int i = 0; i < audioArchive.WaveSystems.Count; i++)
                    bnks.Nodes.Add($"W{i}",$"WAVESYSTEM {audioArchive.WaveSystems[i].id}");
            }

            if (audioArchive.Instruments != null)
            {
                var bnks = AudioTree.Nodes.Add("S","STREAMS");
                
            }
        }

        private void JamMain_Load(object sender, EventArgs e)
        {

        }

        private void AudioTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var seli = AudioTree.SelectedNode;
            var bk = seli.Name;
            if (bk.Length < 1)
                return;
            var fc = bk[0];

            switch (fc)
            {
                case 'B':
                    {
                        mnuLayoutPanel.Controls.Clear();
                        var bIdx = bk.Substring(1);
                        var num = Convert.ToInt16(bIdx);

                        currentEditor = new BankEditor(audioArchive.Instruments[num]);

                        currentEditor.Location = new System.Drawing.Point(0, 0);
                        currentEditor.Name = "bankEditor1";
                        currentEditor.Size = new System.Drawing.Size(576, 741);
                        currentEditor.TabIndex = 2;

                        Console.WriteLine("BANK SELECTED");
                        currentEditor.Show();
                        mnuLayoutPanel.Controls.Add(currentEditor);

                        break;
                    }
            }
        }
    }
}