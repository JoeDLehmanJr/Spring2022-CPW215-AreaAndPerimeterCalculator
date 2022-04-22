namespace AreaAndPerimeterCalculator
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnCalculateAreaPerimeter_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txtLength.Text);
            int width = Convert.ToInt32(txtWidth.Text);

            int area = length * width;
            int perimeter = 2 * (length + width);

            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perimeter);
        }
    }
}