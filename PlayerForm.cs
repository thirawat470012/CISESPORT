using Newtonsoft.Json;

namespace CISESPORT
{
    public partial class PlayerForm : Form
    {
        public static PlayerForm Instance;
        public List<PlayerClass> listplayer = new List<PlayerClass>();
        public PlayerForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerRegister pr = new PlayerRegister();
            pr.ShowDialog();
            if (pr.DialogResult == DialogResult.OK)
            {
                listplayer.Add(pr.getPlayer());
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (PlayerClass player_ in listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog filesaveas = new SaveFileDialog();
            filesaveas.FileName = "Players";
            filesaveas.Filter = "Json|*.json";
            filesaveas.ShowDialog();
            if (filesaveas.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listplayer, Formatting.Indented);
                File.WriteAllText(filesaveas.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Players";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listplayer = JsonConvert.DeserializeObject<List<PlayerClass>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamForm tm = new TeamForm();
            tm.ShowDialog();
        }
    }
}