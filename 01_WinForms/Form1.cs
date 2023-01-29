namespace _01_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var displayName = $"{tb_FirstName.Text} {tb_LastName.Text}";
            MessageBox.Show(displayName);
        }


    }
}