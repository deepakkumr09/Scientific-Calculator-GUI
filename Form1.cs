using System.DirectoryServices;

namespace Scientific_Calculator_GUI
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num =(Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;

                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
            
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
            lblShowOp.Text = System.Convert.ToString(enterFirstValue) + " " + op;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
           switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + Double.Parse(txtResult.Text)).ToString();
                    break;
                    case "-":
                    txtResult.Text = (enterFirstValue - Double.Parse(txtResult.Text)).ToString();
                    break;
                    case "*":
                    txtResult.Text = (enterFirstValue * Double.Parse(txtResult.Text)).ToString();
                    break;
                    case "/":
                    txtResult.Text = (enterFirstValue / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % Double.Parse(txtResult.Text)).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                default:
                    break;


            }
            enterFirstValue = Double.Parse(txtResult.Text);
            lblShowOp.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
            lblShowOp.Text = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length> 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 859;
            txtResult.Width = 773;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 426;
            txtResult.Width = 370;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Cunfirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg =  Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtResult.Text) + ")");
            logg = Math.Log10(logg);
            txtResult.Text = System.Convert.ToString(logg);
           
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtResult.Text) + ")");
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {

            double x, q, p, m;
            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x =(q * p * m); 
            txtResult.Text = Convert.ToString(x);

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtResult.Text) + ")");
            sh = Math.Sin(sh);
            txtResult.Text = System.Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double sin = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtResult.Text) + ")");
            sin = Math.Sin(sin);
            txtResult.Text = System.Convert.ToString(sin);

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double cosh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtResult.Text) + ")");
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);

        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cos = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtResult.Text) + ")");
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);

        }

        private void btnTanh_Click(object sender, EventArgs e)
        {

            double tanh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtResult.Text) + ")");
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);

        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double tan = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtResult.Text) + ")");
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);

        }

        private void btn1x_Click(object sender, EventArgs e)
        {

            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);

        }

        private void btnlnx_Click(object sender, EventArgs e)
        {

            double lnx = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtResult.Text) + ")");
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);

        }

        private void btnPer_Click(object sender, EventArgs e)
        {

            double a ;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);

        }

        private void btnDec_Click(object sender, EventArgs e)
        {

            double dec = Convert.ToDouble(txtResult.Text);

            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);

        }

        private void btnBin_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);

        }

        private void btnHex_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);

        }

        private void btnOct_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width= 426;
            txtResult.Width = 370;
        }
    }
}