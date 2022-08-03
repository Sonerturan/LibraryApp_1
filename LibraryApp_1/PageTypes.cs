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
    public partial class PageTypes : Form
    {
        TypeManager typeManager = new TypeManager();
        public PageTypes()
        {
            InitializeComponent();
        }

        private void PageTypes_Load(object sender, EventArgs e)
        {
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = typeManager.ListBase();
        }
        public void ListSearch(string searchcontent)
        {
            dgwlist.DataSource = typeManager.ListSearch(searchcontent);
        }
        public void textboxClear()
        {
            txttypename.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(dgwlist.CurrentRow.Cells["TÜR NO"].Value);
            string typename = dgwlist.CurrentRow.Cells["TÜR AD"].Value.ToString().ToLower().Trim();

            DialogResult dg = MessageBox.Show(typeid + " Numaralı işlem Güncellensin mi ?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Type type = new Type
                {
                    TypeId = typeid,
                    TypeName = typename
                };
                typeManager.Update(type);
                ListBase();
            }

        }

        private void pctrrefresh_Click(object sender, EventArgs e)
        {
            ListBase();
            btnsearch.Visible = true;
            pctrsearch.Visible = false;
            txtsearch.Visible = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int typeid =Convert.ToInt32( dgwlist.CurrentRow.Cells["TÜR NO"].Value);

            DialogResult dg = MessageBox.Show(typeid + " Numaralı tür silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                Type type = new Type
                {
                    TypeId = typeid
                };
                typeManager.Delete(type);
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

            if (txttypename.Text == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else
            {

                lblerror.Text = null;
                if (typeManager.RegisteredTypeName(txttypename.Text) == txttypename.Text.ToLower().Trim())
                {
                    MessageBox.Show(txttypename.Text + " No'lu tür sistemde Zaten mevcut", "Mevcut olan tür ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Type type = new Type
                    {
                        TypeName=txttypename.Text
                    };
                    typeManager.Add(type);
                    ListBase();
                    textboxClear();
                }
            }

        }
    }
}
