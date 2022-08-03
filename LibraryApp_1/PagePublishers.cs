using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp_1
{
    public partial class PagePublishers : Form
    {
        PublisherManager publisherManager = new PublisherManager();
        public PagePublishers()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtpublishername.Text == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else
            {

                lblerror.Text = null;
                if (publisherManager.RegisteredPublisherName(txtpublishername.Text) == txtpublishername.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtpublishername.Text + " ad'lı yayınevi  sistemde Zaten mevcut", "Mevcut olan yayınevi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Publisher publisher = new Publisher
                    {
                        PublisherName = txtpublishername.Text,
                        PublisherPhone = txtpublisherphone.Text,
                        PublisherAdress = txtpublisheradress.Text
                    };
                    publisherManager.Add(publisher);
                    ListBase();
                    textboxClear();
                }
            }
        }

        private void PagePublisher_Load(object sender, EventArgs e)
        {
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = publisherManager.ListBase();
        }
        public void ListSearch(string searchcontent)
        {
            dgwlist.DataSource = publisherManager.ListSearch(searchcontent);
        }
        public void textboxClear()
        {
            txtpublishername.Text = "";
            txtpublisheradress.Text = "";
            txtpublisherphone.Text = "";
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
            int publisherid = Convert.ToInt32(dgwlist.CurrentRow.Cells["YAYINEVİ NO"].Value);
            string publishername = dgwlist.CurrentRow.Cells["YAYINEVİ AD"].Value.ToString().ToLower().Trim();
            string publisherphone = dgwlist.CurrentRow.Cells["YAYINEVİ TEL"].Value.ToString().ToLower().Trim();
            string publisheradress = dgwlist.CurrentRow.Cells["YAYINEVİ ADRES"].Value.ToString().ToLower().Trim();
            DialogResult dg = MessageBox.Show(publisherid + " Numaralı yayınevi Güncellensin mi?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Publisher publisher = new Publisher
                {
                    PublisherId=publisherid,
                    PublisherName=publishername,
                    PublisherPhone=publisherphone,
                    PublisherAdress=publisheradress
                };
                publisherManager.Update(publisher);
                ListBase();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int publisherid = Convert.ToInt32(dgwlist.CurrentRow.Cells["YAYINEVİ NO"].Value);

            DialogResult dg = MessageBox.Show(publisherid + " Numaralı yayınevi silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Publisher publisher = new Publisher
                {
                    PublisherId = publisherid
                };
                publisherManager.Delete(publisher);
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
    }
}
