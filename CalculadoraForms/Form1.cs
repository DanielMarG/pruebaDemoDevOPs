namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        private int n1;
        private int n2;
        private string simbolo;
        public Form1()
        {
            InitializeComponent();
            simbolo = "";
            n1 = 0;
            n2 = 0;
        }

        /*Evento para escribir los numeros en la pantalla*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = ((Button)sender).Text;
            }
            else
            {
                txtPantalla.Text += ((Button)sender).Text;
            }
        }

        /*Evento para la operacion*/
        private void button11_Click(object sender, EventArgs e)
        {
            simbolo = ((Button)sender).Text;
            n1 = Convert.ToInt32(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        /*El boton igual*/
        private void button12_Click(object sender, EventArgs e)
        {
            if (simbolo != "")
            {
                n2 = Convert.ToInt32(txtPantalla.Text);
                switch (simbolo)
                {
                    case "+":
                        n1 += n2;
                        txtPantalla.Text = "" + n1;
                        break;
                    case "-":
                        n1 -= n2;
                        txtPantalla.Text = "" + n1;
                        break;
                    case "*":
                        n1 *= n2;
                        txtPantalla.Text = "" + n1;
                        break;
                    case "/":
                        n1 /= n2;
                        txtPantalla.Text = "" + n1;
                        break;
                }
            }
        }

        /*Boton Reset*/
        private void button16_Click(object sender, EventArgs e)
        {
            simbolo = "";
            n1 = 0;
            n2 = 0;
        }

        /*Boton de borrar*/
        private void button15_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
        }
    }
}