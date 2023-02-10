namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button_MouseClick(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    var rand = new Random();
                    button.Location = new Point(rand.Next(0,500),rand.Next(0,500));
                }
        }
    }
}