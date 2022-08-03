using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_1
{
    public partial class PageWriters : Form
    {
        WriterManager writerManager = new WriterManager();
        public PageWriters()
        {
            InitializeComponent();
        }

        private void PageWriters_Load(object sender, EventArgs e)
        {
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = writerManager.ListBase();
        }
        public void ListSearch(string searchcontent)
        {
            dgwlist.DataSource = writerManager.ListSearch(searchcontent);
        }
        public void textboxClear()
        {
            txtwritername.Text = "";
            txtwritersurname.Text = "";

        }

        private void pctrrefresh_Click(object sender, EventArgs e)
        {
            ListBase();
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int writerid = Convert.ToInt32(dgwlist.CurrentRow.Cells["Yazar No"].Value);
            string writername = dgwlist.CurrentRow.Cells["Yazar Ad"].Value.ToString().ToLower().Trim();
            string writersurname = dgwlist.CurrentRow.Cells["Yazar Soyad"].Value.ToString().ToLower().Trim();

            DialogResult dg = MessageBox.Show(writerid + " Numaralı işlem Güncellensin mi ?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Writer writer = new Writer
                {
                    WriterId = writerid,
                    WriterName = writername,
                    WriterSurname = writersurname
                };
                writerManager.Update(writer);
                ListBase();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int writerid = Convert.ToInt32( dgwlist.CurrentRow.Cells["Yazar No"].Value);

            DialogResult dg = MessageBox.Show(writerid + " Numaralı yazar silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Writer writer = new Writer
                {
                    WriterId = writerid
                };
                writerManager.Delete(writer);
                ListBase();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = false;
            txtsearch.Text = "";
            pctrsearch.Visible = true;
            txtsearch.Visible = true;
        }

        private void pctrsearch_Click(object sender, EventArgs e)
        {
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
            ListSearch(txtsearch.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtwritername.Text == "" || txtwritersurname.Text == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else
            {

                lblerror.Text = null;
                if (writerManager.RegisteredWriter(txtwritername.Text+" "+txtwritersurname.Text) == txtwritername.Text.ToLower().Trim()+" "+txtwritersurname.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtwritername.Text +" "+txtwritersurname+ " Adlı yazar sistemde Zaten mevcut", "Mevcut olan yazar ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Writer writer = new Writer
                    {
                        WriterName = txtwritername.Text.ToLower().Trim(),
                        WriterSurname = txtwritersurname.Text.ToLower().Trim()
                        
                    };
                    writerManager.Add(writer);
                    ListBase();
                    textboxClear();
                }
            }
        }
    }
}
