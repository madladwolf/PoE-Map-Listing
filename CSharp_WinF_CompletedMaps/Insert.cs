using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_WinF_CompletedMaps
{
    public partial class Insert : Form
    {
        public static List<Maps> mapList = new List<Maps>();
        public Insert()
        {
            InitializeComponent();
            addOp();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            int tier = int.Parse(cb_tier.Text);
            string extraMIssion = cb_extraMission.Text;
            string layout = cb_layout.Text;
            Maps maps = new Maps(name, tier, extraMIssion, layout);
            mapList.Add(maps);
            MessageBox.Show(maps.ToString());
        }

        public void addOp()
        {
            for (int i = 0; i < 16; i++)
            {
                cb_tier.Items.Add(i);
            }
            cb_layout.Items.Add("Bad") ;
            cb_layout.Items.Add("Good");
            cb_layout.Items.Add("Perfect");
            cb_extraMission.Items.Add("Yes");
            cb_extraMission.Items.Add("No");
        }
    }
}
