using System;
using System.IO;
using System.Windows.Forms;

namespace CSharp_WinF_CompletedMaps
{
    public partial class Menu : Form
    {
        private static bool flag = false;
        public Menu()
        {
            InitializeComponent();
            if (!flag)
            {
                readFiles();
                flag = true;
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            writeFile();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert insert = new Insert();
            insert.Show();
        }

        private void Txt_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.Show();
        }

        public static void writeFile()
        {
            StreamWriter wr = new StreamWriter(@"maps.txt", true);
            foreach(Maps maps in Insert.mapList)
            {
                wr.WriteLine(maps.ToString2Read());
            }
            wr.Close();
        }

        public static void readFiles()
        {
            if (File.Exists(@"maps.txt"))
            {
                StreamReader sr = new StreamReader(@"maps.txt");
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] divisao = linha.Split('|');
                    Maps maps = new Maps(divisao[0], int.Parse(divisao[1]), divisao[2], divisao[3]);
                    Insert.mapList.Add(maps);
                }
                sr.Close();
            }
        }

    }
}
