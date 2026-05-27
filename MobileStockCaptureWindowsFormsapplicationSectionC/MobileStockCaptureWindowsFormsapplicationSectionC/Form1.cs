namespace MobileStockCaptureWindowsFormsapplicationSectionC
{
    using System.Diagnostics.CodeAnalysis;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            lblOutput.Text += "Record Added";
            tblMoblePhones.Text += "     ";
            tblMoblePhones.Text += "Mobile code " + txtCode.Text;
            tblMoblePhones.Text += "     ";
            tblMoblePhones.Text += "Make " + txtMake.Text;
            tblMoblePhones.Text += "                             ";
            tblMoblePhones.Text += "Quantity " + txtQuantity.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;

            if (txtCode is null)
            {
                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record Not Found";
            }


            txtCode.Text = string.Empty;
            tblMoblePhones.Text = string.Empty;



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == tblMoblePhones.Text)
            {
                lblOutput.Text = "Record delited";
            }
            else
            {
                lblOutput.Text = "Record Not Found";
            }
        }
    }
}
