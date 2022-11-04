namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSothu1.Text);
            b = int.Parse(txtSoThu2.Text);
            ketQua = a + b;
            lbKetQua.Text = ketQua.ToString();
        }
    }
}