using Objetos;

namespace App
{
    public partial class FrmInicio : System.Windows.Forms.Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void ListarFiguras()
        {
            cboObjeto.Items.Clear();
            cboObjeto.Items.Add("Cuadrado");
            cboObjeto.Items.Add("Rectángulo");
            cboObjeto.Items.Add("Triángulo equilátero");
            cboObjeto.Items.Add("Círculo");
            cboObjeto.Enabled = true;
            lblObjeto.Text = "Figura";
            btnCalcular.Text = "Calcular área";
        }

        private void ListarSolidos()
        {
            cboObjeto.Items.Clear();
            cboObjeto.Items.Add("Cubo");
            cboObjeto.Items.Add("Prisma rectangular");
            cboObjeto.Items.Add("Pirámide rectangular");
            cboObjeto.Items.Add("Esfera");
            cboObjeto.Enabled = true;
            lblObjeto.Text = "Sólido";
            btnCalcular.Text = "Calcular volumen";
        }

        private void ResetearDatos()
        {
            numDato1.Value = 0;
            numDato2.Value = 0;
            numDato3.Value = 0;
        }

        private void HabilitarDatos()
        {
            lblDato1.Visible = false;
            numDato1.Visible = false;

            lblDato2.Visible = false;
            numDato2.Visible = false;

            lblDato3.Visible = false;
            numDato3.Visible = false;

            btnCalcular.Visible = false;
        }

        private void HabilitarDatos(string dato1)
        {
            lblDato1.Text = dato1;
            lblDato1.Visible = true;
            numDato1.Visible = true;

            lblDato2.Visible = false;
            numDato2.Visible = false;

            lblDato3.Visible = false;
            numDato3.Visible = false;

            btnCalcular.Visible = true;
        }

        private void HabilitarDatos(string dato1, string dato2)
        {
            lblDato1.Text = dato1;
            lblDato1.Visible = true;
            numDato1.Visible = true;

            lblDato2.Text = dato2;
            lblDato2.Visible = true;
            numDato2.Visible = true;

            lblDato3.Visible = false;
            numDato3.Visible = false;

            btnCalcular.Visible = true;
        }

        private void HabilitarDatos(string dato1, string dato2, string dato3)
        {
            lblDato1.Text = dato1;
            lblDato1.Visible = true;
            numDato1.Visible = true;

            lblDato2.Text = dato2;
            lblDato2.Visible = true;
            numDato2.Visible = true;

            lblDato3.Text = dato3;
            lblDato3.Visible = true;
            numDato3.Visible = true;

            btnCalcular.Visible = true;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarDatos();

            switch (cboTipo.SelectedItem)
            {
                case "Figura":
                    ListarFiguras();
                    break;

                case "Sólido":
                    ListarSolidos();
                    break;
            }
        }

        private void cboObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetearDatos();

            switch (cboObjeto.SelectedItem)
            {
                case "Cuadrado":
                    HabilitarDatos("Lado");
                    break;
                case "Rectángulo":
                    HabilitarDatos("Base", "Altura");
                    break;
                case "Triángulo equilátero":
                    HabilitarDatos("Base", "Altura");
                    break;
                case "Círculo":
                    HabilitarDatos("Radio");
                    break;
                case "Cubo":
                    HabilitarDatos("Lado");
                    break;
                case "Prisma rectangular":
                    HabilitarDatos("Ancho", "Largo", "Altura");
                    break;
                case "Pirámide rectangular":
                    HabilitarDatos("Ancho", "Largo", "Altura");
                    break;
                case "Esfera":
                    HabilitarDatos("Radio");
                    break;
            }
        }

        private void MostrarResultado(string dato, string objeto, decimal resultado)
        {
            MessageBox.Show($"El {dato} {objeto} es: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cboObjeto.SelectedItem)
            {
                case "Cuadrado":
                    MostrarResultado("área", "del cuadrado", Cuadrado.Area(numDato1.Value));
                    break;
                case "Rectángulo":
                    MostrarResultado("área", "del rectángulo", Rectangulo.Area(numDato1.Value, numDato2.Value));
                    break;
                case "Triángulo equilátero":
                    MostrarResultado("área", "del triángulo equilátero", TrianguloEquilatero.Area(numDato1.Value, numDato2.Value));
                    break;
                case "Círculo":
                    MostrarResultado("área", "del círculo", Circulo.Area(numDato1.Value));
                    break;
                case "Cubo":
                    MostrarResultado("volumen", "del cubo", Cubo.Volumen(numDato1.Value));
                    break;
                case "Prisma rectangular":
                    MostrarResultado("volumen", "del prisma rectangular", PrismaRectangular.Volumen(numDato1.Value, numDato2.Value, numDato3.Value));
                    break;
                case "Pirámide rectangular":
                    MostrarResultado("volumen", "de la pirámide rectangular", PiramideRectangular.Volumen(numDato1.Value, numDato2.Value, numDato3.Value));
                    break;
                case "Esfera":
                    MostrarResultado("volumen", "de la esfera", Esfera.Volumen(numDato1.Value));
                    break;
            }
        }
    }
}