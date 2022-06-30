using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Font = Xceed.Document.NET.Font;

namespace FInalProject
{
    public partial class ContractListForm : Form
    {
        public ContractListForm()
        {
            InitializeComponent();
        }
        CaringContract ca = new CaringContract();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = ca.GetContract(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd=new SqlCommand();
                String query;
                if (radioButtonRent.Checked)
                {
                    if (radioButtonValidated.Checked)
                    {
                        query = "Select a.Id, a.CusName as 'Customer Name', a.Address, a.Phone, a.VehicleID, b.Number, b.Back, b.Type, a.Duration, a.Price, a.RentTime" +
                            " from Rent a inner join RentVehicle b on a.VehicleID = b.Id" +
                            " where DateAdd(hour,Duration,RentTime) > GetDate()";
                    }
                    else if (radioButtonOut.Checked)
                    {
                        query = "Select a.Id, a.CusName as 'Customer Name', a.Address, a.Phone, a.VehicleID, b.Number, b.Back, b.Type, a.Duration, a.Price, a.RentTime" +
                            " from Rent a inner join RentVehicle b on a.VehicleID = b.Id " +
                            "where DateAdd(hour,Duration,RentTime) <= GetDate()";
                    }
                    else
                    {
                        query = "Select a.Id, a.CusName as 'Customer Name', a.Address, a.Phone, a.VehicleID, b.Number, b.Back,  b.Type, a.Duration, a.Price, a.RentTime" +
                            " from Rent a inner join RentVehicle b on a.VehicleID = b.Id where a.Id>0";
                    }
                    cmd = new SqlCommand(query);
                    if (textBoxID.Text.Trim() != "")
                    {
                        int id = Convert.ToInt32(textBoxID.Text);
                        query += " and a.Id=@id";
                        cmd = new SqlCommand(query);
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    }
                    fillGrid(cmd);
                }
                else
                {
                    if (radioButtonValidated.Checked)
                    {
                        query = "Select a.Id, a.OwnerName, b.Address, b.Phone, a.VehicleID, b.Number, b.Back, b.Type, a.Duration, a.Price, a.TimeIn as 'Supply Time' " +
                            " from Supply a inner join RentVehicle b on a.VehicleID = b.Id" +
                            " where Duration > GetDate()";
                    }
                    else if (radioButtonOut.Checked)
                    {
                        query = "Select a.Id, a.OwnerName, b.Address, b.Phone, a.VehicleID, b.Number, b.Back, b.Type, a.Duration, a.Price, a.TimeIn as 'Supply Time' " +
                            " from Supply a inner join RentVehicle b on a.VehicleID = b.Id" +
                            " where Duration <= GetDate()";
                    }
                    else
                    {
                        query = "Select a.Id, a.OwnerName, b.Address, b.Phone, a.VehicleID, b.Number, b.Back, b.Type, a.Duration, a.Price, a.TimeIn as 'Supply Time' " +
                            " from Supply a inner join RentVehicle b on a.VehicleID = b.Id";

                    }
                    cmd = new SqlCommand(query);
                    if (textBoxID.Text.Trim() != "")
                    {
                       int id = Convert.ToInt32(textBoxID.Text);
                        query += " and a.Id=@id";
                        cmd = new SqlCommand(query);
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    }
                    fillGrid(cmd);
                }
        }
            catch
            {
                MessageBox.Show("Something wrong");
            }
}

        private void ContractListForm_Load(object sender, EventArgs e)
        {
            radioButtonRent.Checked = true;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                #region one
                string fileName ="Rent_Contract.docx";
                var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "SOCIALIST REPUBLIC OF VIETNAM\n" +
                "Independence – Freedom – Happiness\n" +
                "RENT VEHICLE CONTRACT\n" + "No.: " + dataGridView1.Rows[0].Cells[0].Value.ToString()+"\n";

                Formatting titleFormat = new Formatting();
                titleFormat.FontFamily = new Font("Times New Roman");
                titleFormat.Size = 16;
                titleFormat.Position = 40;
                titleFormat.FontColor = Color.Black;

                //Formatting Text Paragraph  
                Formatting textParagraphFormat = new Formatting();
                //font family  
                textParagraphFormat.FontFamily = new Font("Times New Roman");
                //font size  
                textParagraphFormat.Size = 13;
                //Spaces between characters  
                textParagraphFormat.Spacing = 1.5;
                //Insert title  
                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;
            //Insert text 
            string textParagraph = "Date: "+DateTime.Now.Day.ToString()+"/"+ DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()+"\n";
            doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            if (radioButtonRent.Checked)
            {
                textParagraph = "Party A (Rent):\n     - Address: "
                       + dataGridView1.Rows[0].Cells[2].Value.ToString() + "\n     - Name: " + dataGridView1.Rows[0].Cells[1].Value.ToString()
                        + "\n     - Phone: " + dataGridView1.Rows[0].Cells[3].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "Party B (Supply):\n     - Address: Thủ Đức\n     - Name: Company\n     - Phone: 0906941863"
                       + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "After discussion, party A agrees to rent vehicle of party B with conditions below:\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 1: CONTENT OF CONTRACT:\nParty A agrees to rent vehicle of party B.\n" +
                    "+ Vehicle ID: " + dataGridView1.Rows[0].Cells[4].Value.ToString() + " number " + dataGridView1.Rows[0].Cells[5].Value.ToString()
                    + "      Type: " + dataGridView1.Rows[0].Cells[7].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 2: COST OF CONTRACT\nRent Cost: " + dataGridView1.Rows[0].Cells[9].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 3: RESPONSIBILITY OF BOTH PARTIES\n1. Responsibility of party B:\n" +
                    "Deliver the vehicle and all documents related to the vehicle immediately after the Contract takes effect and Party A has paid the rental. Papers related to the vehicle include: " +
                    "Vehicle registration certificate, inspection certificate, vehicle insurance certificate.\n" +
                    "2. Responsibility of party A:\n -Pay the car rental to Party B on time.\n- Bear the full cost of periodic vehicle maintenance\n" +
                    "- Bear all fuel costs when using the vehicle.\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);

                textParagraph = "ARTICLE 4: VALIDITY OF THE CONTRACT\n- The contract is valid in " + dataGridView1.Rows[0].Cells[8].Value.ToString() + " hour(s) from " + dataGridView1.Rows[0].Cells[10].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 5: GENERAL TERMS\n- Any dispute arising out of or in connection with this contract shall be settled by the parties in a spirit of cooperation within 01 month from the date " +
                    "on which the dispute arises.\n- This contract is made in 02 original copies. Each party keeps 01 copy with equal legality for implementation.\n" +
                    "The contract, after the implementation of the two parties, if there are no complaints or disputes, shall be deemed liquidated.\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "PARTY A                          PARTY B";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
               
            }
            else
            { //Select a.Id, a.OwnerName, b.Address, b.Phone, a.VehicleID, 
                //b.Number, b.Back, b.Type, a.Duration, a.Price, a.TimeIn as 'Supply Time'
                textParagraph = "Party A (Rent):\n     - Address: Thủ Đức\n     - Name: Company\n     - Phone: 0906941863"
                        + "\n";
                
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "Party B (Supply):\n     - Address: "
                         + dataGridView1.Rows[0].Cells[2].Value.ToString() + "\n     - Name: " + dataGridView1.Rows[0].Cells[1].Value.ToString()
                          + "\n     - Phone: " + dataGridView1.Rows[0].Cells[3].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "After discussion, party A agrees to rent vehicle of party B with conditions below:\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 1: CONTENT OF CONTRACT:\nParty A agrees to rent vehicle of party B.\n" +
                    "+ Vehicle ID: " + dataGridView1.Rows[0].Cells[4].Value.ToString() + " number " + dataGridView1.Rows[0].Cells[5].Value.ToString()
                    + "      Type: " + dataGridView1.Rows[0].Cells[7].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 2: COST OF CONTRACT\nRent Cost: " + dataGridView1.Rows[0].Cells[9].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 3: RESPONSIBILITY OF BOTH PARTIES\n1. Responsibility of party B:\n" +
                    "Deliver the vehicle and all documents related to the vehicle immediately after the Contract takes effect and Party A has paid the rental. Papers related to the vehicle include: " +
                    "Vehicle registration certificate, inspection certificate, vehicle insurance certificate.\n" +
                    "2. Responsibility of party A:\n -Pay the car rental to Party B on time.\n- Bear the full cost of periodic vehicle maintenance\n" +
                    "- Bear all fuel costs when using the vehicle.\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);

                textParagraph = "ARTICLE 4: VALIDITY OF THE CONTRACT\n- The contract is valid from " + dataGridView1.Rows[0].Cells[10].Value.ToString() + " to the end of " + dataGridView1.Rows[0].Cells[8].Value.ToString() + "\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "ARTICLE 5: GENERAL TERMS\n- Any dispute arising out of or in connection with this contract shall be settled by the parties in a spirit of cooperation within 01 month from the date " +
                    "on which the dispute arises.\n- This contract is made in 02 original copies. Each party keeps 01 copy with equal legality for implementation.\n" +
                    "The contract, after the implementation of the two parties, if there are no complaints or disputes, shall be deemed liquidated.\n";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                textParagraph = "PARTY A                          PARTY B";
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            }
            #endregion
            dataGridView1.AllowUserToAddRows = false;
                #region four
                //doc.InsertParagraph();
                
                    //    var img2 = doc.AddImage(@"w1.png");
                    //    Picture p2 = img2.CreatePicture();
                    //    Paragraph par2 = doc.InsertParagraph();
                    //    par2.Alignment = Alignment.center;
                    //    par2.AppendPicture(p2);
  
                #endregion
                #region part of one
                doc.Save();
                Process.Start("WINWORD.EXE", fileName);
                #endregion
                Console.Read();
        }
            catch
            {
                MessageBox.Show("Something wrong. Just print 1 contract", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
    }
}
