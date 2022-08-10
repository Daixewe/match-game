namespace matchGame
{
    public partial class Form1 : Form

    {
        private Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!","!","N","N",
            ",",",","k","k",
            "b","b","v","v",
            "w","w","z","z"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconstToSquares();
        }



        private void AssignIconstToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }

            }
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}