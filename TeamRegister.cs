using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class TeamRegister : Form
    {
        TeamClass team;
        List<PlayerClass> listplayer = new List<PlayerClass>();
        public TeamRegister()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                PlayerClass player = new PlayerClass();
                player.Name = "";
                player.LastName = "";
                player.StudentID = "";
                player.Major = "";
                player.GameName = "";
                player.Email = "";
                player.Phone = "";
                player.Age = 0;
                listplayer.Add(player);
            }
        }

        private void Teamsubmit_Click(object sender, EventArgs e)
        {
            string TeamName = nameTeam.Text;
            team = new TeamClass();
            team.TeamName = TeamName;
            team.Members = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;
        }

        private void HondaClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "Find1")
            {
                FindPlayer(0, member1);
            }
            else if (btn.Name == "Find2")
            {
                FindPlayer(1, member2);
            }
            else if (btn.Name == "Find3")
            {
                FindPlayer(2, member3);
            }
            else if (btn.Name == "Find4")
            {
                FindPlayer(3, member4);
            }
            else if (btn.Name == "Find5")
            {
                FindPlayer(4, member5);
            }
        }

        private void FindPlayer(int index, TextBox textbox)
        {
            FindPlayer fp = new FindPlayer();
            fp.ShowDialog();
            if (fp.DialogResult == DialogResult.OK)
            {
                listplayer[index] = fp.GetPlayer();
                textbox.Text = listplayer[index].Name;
            }
        }

        public TeamClass getTeam()
        {
            return this.team;
        }
    }
}
