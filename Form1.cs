namespace DannyBLV3
{
    public partial class Form1 : Form
    {
        int age = 0;
        public Form1()
        {
            InitializeComponent();
            AgeBox.Text = "Age: " + age;
        }

        private void AgeUp_Click(object sender, EventArgs e)
        {
            age++;
            AgeBox.Text = "Age: " +age;
        }
    }
}
