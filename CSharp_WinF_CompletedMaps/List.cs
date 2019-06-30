using System;
using System.Windows.Forms;

namespace CSharp_WinF_CompletedMaps
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
            fillGrid();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void fillGrid()
        {
            foreach (Maps maps in Insert.mapList)
            {
                listBox1.Items.Add(maps.ToString());
            }
        }
    }
}
