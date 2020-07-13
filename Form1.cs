using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
namespace Word_Article_Writer
{
    public partial class articleWriter : Form
    {
        public articleWriter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string title = postTitleTb.Text;
            string imageUrl = imagePathTb.Text;
            string article = articleRtb.Text;
            string filename = $"{title}.docx";
            if(System.IO.File.Exists(filename))
            {
                Guid id = Guid.NewGuid();
                filename = id.ToString().Substring(0,id.ToString().IndexOf("-")+1)+filename;
                MessageBox.Show("Added guid to filename.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try 
            {
            
            Writer.createWordDoc(filename, title, imageUrl, article);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Process Complete");
        }

        private void articleWriter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
