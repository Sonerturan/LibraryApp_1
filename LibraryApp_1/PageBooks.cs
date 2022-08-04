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
    public partial class PageBooks : Form
    {
        BookManager bookManager = new BookManager();
        public PageBooks()
        {
            InitializeComponent();
        }

        private void PageBooks_Load(object sender, EventArgs e)
        {
            ListBase();
        }
        public void ListBase()
        {
            dgwlist.DataSource = bookManager.ListBase();
        }
        public void ListSearch(string searchcotent)
        {
            dgwlist.DataSource = bookManager.ListSearch(searchcotent);
        }
        public void ListSearchWriter(string searchcotent)
        {
            dgwlist.DataSource = bookManager.ListSearchWriter(searchcotent);
        }
        public void ListSearchType(string searchcotent)
        {
            dgwlist.DataSource = bookManager.ListSearchType(searchcotent);
        }
        public void ListSearchPublisher(string searchcotent)
        {
            dgwlist.DataSource = bookManager.ListSearchPublisher(searchcotent);
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
            string bookid = dgwlist.CurrentRow.Cells["KİTAP NO"].Value.ToString().ToLower().Trim();
            string bookname = dgwlist.CurrentRow.Cells["KİTAP ADI"].Value.ToString().ToLower().Trim();
            DateTime yearofpublication = Convert.ToDateTime(dgwlist.CurrentRow.Cells["BASIM YILI"].Value);
            int pagenumber = Convert.ToInt32(dgwlist.CurrentRow.Cells["Sayfa sayısı"].Value);

            string writer = dgwlist.CurrentRow.Cells["YAZAR"].Value.ToString().ToLower().Trim();
            string type = dgwlist.CurrentRow.Cells["TÜR"].Value.ToString().ToLower().Trim();
            string publisher = dgwlist.CurrentRow.Cells["YAYINEVİ"].Value.ToString().ToLower().Trim();
            if (bookManager.registeredWriter(writer) != writer)
            {
                MessageBox.Show(writer + " Adlı yazar sistemde bulunmuyor\n\nÖnce " + writer + " Adlı Yazarı yazar tablomuza eklemeniz gerekmektedir", "Mevcut olmayan öğrenci ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookManager.registeredType(type) != type)
            {
                MessageBox.Show(type + " Adlı Tür sistemde bulunmuyor\n\nÖnce " + type + " Adlı Tür'ü Tür tablomuza eklemeniz gerekmektedir", "Mevcut olmayan kitap ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookManager.registeredPublisher(publisher) != publisher)
            {
                MessageBox.Show(publisher + " Adlı Yayınevi sistemde bulunmuyor\n\nÖnce " + publisher + " Adlı Yayınevi'ni Yayınevi tablomuza eklemeniz gerekmektedir", "Mevcut olmayan kitap ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dg = MessageBox.Show(bookid + " Numaralı işlem Güncellensin mi?", "GÜNCELLE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (dg == DialogResult.Yes)
                {
                    Book book = new Book
                    {
                        BookId=Convert.ToInt32( bookid),
                        BookName = bookname,
                        YearOfPublication = yearofpublication,
                        PageNumber = Convert.ToInt32(pagenumber),
                        WriterId = Convert.ToInt32(bookManager.registeredWriterId(writer)),
                        TypeId = Convert.ToInt32(bookManager.registeredTypeId(type)),
                        PublisherId = Convert.ToInt32(bookManager.registeredPublisherId(publisher)),
                        
                    };
                    bookManager.Update(book);
                    ListBase();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(dgwlist.CurrentRow.Cells["KİTAP NO"].Value);
            string bookname = dgwlist.CurrentRow.Cells["KİTAP ADI"].Value.ToString();
            DialogResult dg = MessageBox.Show(bookid + " Numaralı " + bookname + " Adlı kitap silinsin mi?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dg == DialogResult.Yes)
            {
                bookManager.Delete(new Book
                {
                    BookId = bookid
                });
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
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
            if (txtbookname.Text == "" || txtpagenumber.Text == "" || txtwriter.Text == "" || txttype.Text == "" || txtpublisher.Text == "")
            {
                lblerror.Text = "Lütfen boş alan bırakmayınız";
            }
            else
            {

                lblerror.Text = null;
                if (bookManager.registeredWriter(txtwriter.Text) != txtwriter.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtwriter.Text + " Adlı yazar sistemde bulunmuyor\n\nÖnce " + txtwriter.Text + " Adlı yazarı Yazar tablomuza eklemeniz gerekmektedir", "Mevcut olmayan yazar ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (bookManager.registeredType(txttype.Text) != txttype.Text.ToLower().Trim())
                {
                    MessageBox.Show(txttype.Text + " Adlı Tür sistemde bulunmuyor\n\nÖnce " + txttype.Text + " Adlı türü Tür tablomuza eklemeniz gerekmektedir", "Mevcut olmayan tür ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (bookManager.registeredPublisher(txtpublisher.Text) != txtpublisher.Text.ToLower().Trim())
                {
                    MessageBox.Show(txtpublisher.Text + " Adlı Yayınevi sistemde bulunmuyor\n\nÖnce " + txtpublisher.Text + " Adlı yayınevini Yayınevi tablomuza eklemeniz gerekmektedir", "Mevcut olmayan Yayınevi ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Book book = new Book
                    {
                        BookName=txtbookname.Text,
                        YearOfPublication=Convert.ToDateTime( dtyearofpublication.Text),
                        PageNumber=Convert.ToInt32(txtpagenumber.Text),
                        WriterId= Convert.ToInt32(bookManager.registeredWriterId(txtwriter.Text)),
                        TypeId = Convert.ToInt32(bookManager.registeredTypeId(txttype.Text)),
                        PublisherId = Convert.ToInt32(bookManager.registeredPublisherId(txtpublisher.Text))

                    };
                    bookManager.Add(book);
                    ListBase();
                    TextboxClear();
                }
            }
            dgvpublisher.Visible = false;
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
        }
        public void TextboxClear()
        {
            txtbookname.Text = "";
            txtpagenumber.Text = "";
            txtwriter.Text = "";
            txtpublisher.Text = "";
            txttype.Text = "";
        }

        private void dgvwriter_Click(object sender, EventArgs e)
        {
            txtwriter.Text = dgvwriter.CurrentRow.Cells["YAZAR"].Value.ToString();
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtwriter_TextChanged(object sender, EventArgs e)
        {
            dgvwriter.Visible = true;
            dgvtype.Visible = false;
            dgvpublisher.Visible = false;
            bookManager.HandleException(() =>
            {
                string query = "SELECT WriterName+' '+WriterSurname 'YAZAR' " +
                            "FROM Writers " +
                            "WHERE WriterName+' '+WriterSurname LIKE '%" + txtwriter.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, bookManager.Connection()))
                {
                    bookManager.ConnectionOpenControl();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dgvwriter.DataSource = dataTable;
                        }
                    }
                }
            });
        }

        private void dgvtype_Click(object sender, EventArgs e)
        {
            txttype.Text = dgvtype.CurrentRow.Cells["TÜR"].Value.ToString();
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtpublisher_TextChanged(object sender, EventArgs e)
        {
            dgvpublisher.Visible = true;
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            bookManager.HandleException(() =>
            {
                string query = "SELECT PublisherName 'YAYINEVİ' " +
                            "FROM Publishers " +
                            "WHERE PublisherName LIKE '%" + txtpublisher.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, bookManager.Connection()))
                {
                    bookManager.ConnectionOpenControl();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dgvpublisher.DataSource = dataTable;
                        }
                    }
                }
            });
        }

        private void txttype_TextChanged(object sender, EventArgs e)
        {
            dgvtype.Visible = true;
            dgvpublisher.Visible = false;
            dgvwriter.Visible = false;
            bookManager.HandleException(() =>
            {
                string query = "SELECT TypeName 'TÜR' " +
                            "FROM Types " +
                            "WHERE TypeName LIKE '%" + txttype.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, bookManager.Connection()))
                {
                    bookManager.ConnectionOpenControl();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dgvtype.DataSource = dataTable;
                        }
                    }
                }
            });
        }

        private void dgvpublisher_Click(object sender, EventArgs e)
        {
            txtpublisher.Text = dgvpublisher.CurrentRow.Cells["YAYINEVİ"].Value.ToString();
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtwriter_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txttype_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtpublisher_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void tabbooksadd_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void dgwlist_Click(object sender, EventArgs e)
        {
            txtwritersearch.Text = "";
            txtwritersearch.Visible = false;
            txtpublishersearch.Text = "";
            txtpublishersearch.Visible = false;
            txttypesearch.Text = "";
            txttypesearch.Visible = false;
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtbookname_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void txtpagenumber_Click(object sender, EventArgs e)
        {
            dgvtype.Visible = false;
            dgvwriter.Visible = false;
            dgvpublisher.Visible = false;
        }

        private void pctrwritersearch_Click(object sender, EventArgs e)
        {
            txtwritersearch.Text = "";
            txtwritersearch.Visible = true;
            txtpublishersearch.Visible = false;
            txttypesearch.Visible = false;
        }

        private void txtwritersearch_TextChanged(object sender, EventArgs e)
        {
            ListSearchWriter(txtwritersearch.Text);
            
        }

        private void pctrtypesearch_Click(object sender, EventArgs e)
        {
            txttypesearch.Text = "";
            txttypesearch.Visible = true;
            txtpublishersearch.Visible = false;
            txtwritersearch.Visible = false;
        }

        private void txtttypesearch_TextChanged(object sender, EventArgs e)
        {
            ListSearchType(txttypesearch.Text);
        }

        private void txtpublishersearch_TextChanged(object sender, EventArgs e)
        {
            ListSearchPublisher(txtpublishersearch.Text);
        }

        private void pctrpublishersearch_Click(object sender, EventArgs e)
        {
            txtpublishersearch.Text = "";
            txtpublishersearch.Visible = true;
            txtwritersearch.Visible = false;
            txttypesearch.Visible = false;
        }
    }
}
