using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CISESPORT
{
    public partial class PlayerRegister : Form
    {
        PlayerClass player;
        public PlayerRegister()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string Name = tbname.Text;
            string LastName = tblastname.Text;
            string StudentID = tbstuid.Text;
            string Major = tbmajor.Text;
            string GameName = tbdisplayname.Text;
            string Email = tbmail.Text;
            string Phone = tbphone.Text;
            int Age = int.Parse(tbage.Text);

            player = new PlayerClass()
            {
                Name = Name,
                LastName = LastName,
                StudentID = StudentID,
                Major = Major,
                GameName = GameName,
                Email = Email,
                Phone = Phone,
                Age = Age
            };
            this.DialogResult = DialogResult.OK;
        }
        public PlayerClass getPlayer()
        {
            return player;
        }
    }
}
