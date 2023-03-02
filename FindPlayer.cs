using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FindPlayer : Form
    {
        PlayerClass Playerform;
        public FindPlayer()
        {           
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach (PlayerClass player_ in PlayerForm.Instance.listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        public PlayerClass GetPlayer()
        {
            return Playerform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerClass pp = PlayerForm.Instance.listplayer[dataGridView1.CurrentRow.Index];
            Playerform = pp;
            this.DialogResult = DialogResult.OK;
        }
    }
}
