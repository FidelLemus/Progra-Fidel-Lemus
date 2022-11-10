namespace L11_FL_1185721
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circulo miCirculo = new Circulo();
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1 = miCirculo.CalcularGeometria(ref perimetro);
        }

       
}