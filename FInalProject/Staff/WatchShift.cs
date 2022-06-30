using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FInalProject
{
    public partial class WatchShift : Form
    {
        public int id;
        DataTable table;
        public WatchShift()
        {
            InitializeComponent();
        }

        private void WatchShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet2.Shift' table. You can move, or remove it, as needed.
            this.shiftTableAdapter1.Fill(this.finalProjectDataSet2.Shift);

            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shift",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            for(int i=0;i<table.Rows.Count;i++)
            {
                for(int j=1;j<table.Columns.Count;j++)
                {
                    if(table.Rows[i][j].ToString()==Convert.ToString(Globals.GlobalUserId))
                    {
                        table.Rows[i][j] = "X";
                    }
                    else table.Rows[i][j] = "";
                }
            }
            dataGridView1.DataSource = table;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            WatchShift_Load(sender, e);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0) return;
            int x = dataGridView1.CurrentCell.RowIndex;
            int y = dataGridView1.CurrentCell.ColumnIndex;
            if (table.Rows[x][y].ToString() == "X") table.Rows[x][y] = "";
            else table.Rows[x][y] = "X";
            dataGridView1.DataSource = table;
        }

        private void button_Request_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You do not have the right to change but you can request the manager!\n" +
                "Proceed to countinue?","Change shift", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.No:
                    return;
            }
            //Try to send Email
            try
            {
                //https://www.youtube.com/watch?v=vDxs3NYTvUs&t=1196s
                Random rng = new Random();
                MailMessage mail = new MailMessage();
                SmtpClient sever = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("voduchoangphi@gmail.com");
                mail.To.Add("voduchoangphi@gmail.com");
                mail.Subject = "Add new staff";
                mail.Body = "Staff " + Globals.GlobalUserId + " requested a change in schedule" +
                    "\nDetail of the change is in the attachment file";
                //Attachment=============================================================
                //Resize DataGridView to full height.
                int DGVOriginalHeight = dataGridView1.Height;
                dataGridView1.Height = (dataGridView1.RowCount * dataGridView1.RowTemplate.Height) +
                                        dataGridView1.ColumnHeadersHeight;
                string desktopPath;
                using (Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height))
                {
                    dataGridView1.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.dataGridView1.Size));
                    string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    bitmap.Save(Path.Combine(DesktopFolder, "datagridview1.png"), ImageFormat.Png);
                    desktopPath = Path.Combine(DesktopFolder, "datagridview1.png");
                }
                dataGridView1.Height = DGVOriginalHeight;
                //===================================================
                System.Net.Mail.Attachment att;
                att = new Attachment(desktopPath);
                mail.Attachments.Add(att);
                //=======================================================================
                sever.Port = 587;
                sever.Credentials = new NetworkCredential("20110432@student.hcmute.edu.vn", "Phi09Phi09");
                sever.EnableSsl = true;
                sever.Send(mail);
                //MessageBox.Show("Success!");
                //Inform
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message, "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("An email was sent to " + textBox_Email1.Text + textBox_Email2.Text, "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //AddNewStaff_Load(sender, e);
        }
    }
}
