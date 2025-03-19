using ProblemPlecakowy;
namespace GUI
{
    public partial class Form1 : Form
    {

        private String numberOfItems;
        private String seed = "0";
        private String capacity;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfItems.Text == "")
            {
                lblNumberOfItems.Text = "Number of items - enter a number between 1 and 20";
            }
            if (int.Parse(txtNumberOfItems.Text) < 1 || int.Parse(txtNumberOfItems.Text) > 20)
            {
                txtNumberOfItems.BackColor = Color.Red;
                lblNumberOfItems.Text = "Number of items - enter a number between 1 and 20";
            } 
                else
                {
                    txtNumberOfItems.BackColor = Color.White;
                    lblNumberOfItems.Text = "Number of items";
                    numberOfItems = txtNumberOfItems.Text;
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            seed = txtSeed.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "")
            {
                lblCapacity.Text = "Capacity - enter a number between 1 and 20";
            }
            if (int.Parse(txtCapacity.Text) < 1 || int.Parse(txtCapacity.Text) > 20)
            {
                txtCapacity.BackColor = Color.Red;
                lblCapacity.Text = "Capacity - enter a number between 1 and 20";
            }
            else
            {
                txtCapacity.BackColor = Color.White;
                lblCapacity.Text = "Capacity";
                capacity = txtCapacity.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblCapacity.Text == "Capacity" && lblNumberOfItems.Text == "Number of items")
            {
                Problem problem = new Problem(int.Parse(numberOfItems), int.Parse(seed));
                lblInstance.Text = problem.ToString();
                Result result = problem.Solve(int.Parse(capacity));
                lblResults.Text = result.ToString();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblInstance_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }
    }
}
