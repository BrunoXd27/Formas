using static System.Windows.Forms.Design.AxImporter;

namespace Cal_formas
{
    public partial class Cal : Form
    {
        float peri;
        float area;
        public Cal()
        {
            InitializeComponent();
        }

        private async void instalador()
        {
            string tempFilePath = "D://BRUNO//Actua/Instalador2/Instalador2/bin/Debug/net8.0-windows/Instalador.exe";
            MessageBox.Show(tempFilePath);

            // Ejecutar el nuevo archivo EXE y cerrar la aplicación actual
            System.Diagnostics.Process.Start(tempFilePath);
            Application.Exit();
        }

        private void acept_Click(object sender, EventArgs e)
        {

            int resultado = 0;

            if (cua.Checked)
            {
                resultado = 1;
            }
            else if (rec.Checked)
            {
                resultado = 2;
            }
            else if (tri.Checked)
            {
                resultado = 3;
            }
            else if (cir.Checked)
            {
                resultado = 4;
            }
            else if (penta.Checked)
            {
                resultado = 5;
            }

            switch (resultado)
            {
                case 1:
                    //esconder
                    acept.Visible = false;
                    cua.Visible = false;
                    rec.Visible = false;
                    tri.Visible = false;
                    cir.Visible = false;
                    penta.Visible = false;
                    //mostrar
                    cua1.Visible = true;
                    num1.Visible = true;
                    res.Visible = true;
                    back.Visible = true;

                    cua1.Text = "Medida de uno de los lados en centímetros:";
                    cua1.Location = new Point(85, 52);

                    break;

                case 2:
                    //esconder
                    acept.Visible = false;
                    cua.Visible = false;
                    rec.Visible = false;
                    tri.Visible = false;
                    cir.Visible = false;
                    penta.Visible = false;
                    //mostrar
                    cua1.Visible = true;
                    num1.Visible = true;
                    num2.Visible = true;
                    res.Visible = true;
                    rec1.Visible = true;
                    back.Visible = true;
                    break;

                case 3:
                    //esconder
                    acept.Visible = false;
                    cua.Visible = false;
                    rec.Visible = false;
                    tri.Visible = false;
                    cir.Visible = false;
                    penta.Visible = false;
                    //mostrar
                    cua1.Visible = true;
                    num1.Visible = true;
                    num2.Visible = true;
                    res.Visible = true;
                    rec1.Visible = true;
                    back.Visible = true;

                    cua1.Text = "Medida de la base del triángulo en centímetros:";
                    cua1.Location = new Point(80, 52);
                    rec1.Text = "Medida de la altura del triángulo en centímetros:";
                    rec1.Location = new Point(75, 122);
                    break;
                case 4:
                    //esconder
                    acept.Visible = false;
                    cua.Visible = false;
                    rec.Visible = false;
                    tri.Visible = false;
                    cir.Visible = false;
                    penta.Visible = false;
                    //mostrar
                    cua1.Visible = true;
                    num1.Visible = true;
                    res.Visible = true;
                    back.Visible = true;

                    cua1.Text = "Medida del radio en centímetros:";
                    cua1.Location = new Point(110, 52);
                    break;
                case 5:
                    //esconder
                    acept.Visible = false;
                    cua.Visible = false;
                    rec.Visible = false;
                    tri.Visible = false;
                    cir.Visible = false;
                    penta.Visible = false;
                    //mostrar
                    cua1.Visible = true;
                    num1.Visible = true;
                    num2.Visible = true;
                    res.Visible = true;
                    rec1.Visible = true;
                    back.Visible = true;

                    cua1.Text = "Medida de un lado en centímetros:";
                    cua1.Location = new Point(110, 52);
                    rec1.Text = "Medida del apotema en centímetros:";
                    rec1.Location = new Point(105, 122);
                    break;

                default:
                    MessageBox.Show("Por favor, selecciona una opción válida.");
                    break;
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            if (cua.Checked)
            {
                pe.Visible = true;
                ar.Visible = true;
                peri = float.Parse(num1.Text) * 4;
                pe.Text = "El perimetro es: " + peri + " cm.";
                area = float.Parse(num1.Text) * float.Parse(num1.Text);
                ar.Text = "El área es: " + area + " cm cuadrados.";
            }
            else if (rec.Checked)
            {
                pe.Visible = true;
                ar.Visible = true;
                peri = float.Parse(num1.Text) * 2 + float.Parse(num2.Text) * 2;
                pe.Text = "El perimetro es: " + peri + " cm.";
                area = float.Parse(num1.Text) * float.Parse(num2.Text);
                ar.Text = "El área es: " + area + " cm cuadrados.";
            }
            else if (tri.Checked)
            {
                pe.Visible = true;
                ar.Visible = true;
                peri = float.Parse(num1.Text) * 3;
                pe.Text = "El perimetro es: " + peri + " cm.";
                area = (float.Parse(num1.Text) * float.Parse(num2.Text)) / 2;
                ar.Text = "El área es: " + area + " cm cuadrados.";
            }
            else if (cir.Checked)
            {
                pe.Visible = true;
                ar.Visible = true;
                peri = float.Parse(num1.Text) * (float.Pi * 2);
                pe.Text = "El perimetro es: " + peri + " cm.";
                area = float.Parse(num1.Text) * float.Parse(num1.Text) * float.Pi;
                ar.Text = "El área es: " + area + " cm cuadrados.";
                pe.Location = new Point(120, 251);
                ar.Location = new Point(110, 229);
            }
            else if (penta.Checked)
            {
                pe.Visible = true;
                ar.Visible = true;
                peri = float.Parse(num1.Text) * 5;
                pe.Text = "El perimetro es: " + peri + " cm.";
                area = (peri * float.Parse(num2.Text)) / 2;
                ar.Text = "El área es: " + area + " cm cuadrados.";
                pe.Location = new Point(120, 251);
                ar.Location = new Point(110, 229);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            //ocultar
            back.Visible = false;
            cua1.Visible = false;
            num1.Visible = false;
            num2.Visible = false;
            res.Visible = false;
            rec1.Visible = false;
            pe.Visible = false;
            ar.Visible = false;

            //regreso
            acept.Visible = true;
            cua.Visible = true;
            rec.Visible = true;
            tri.Visible = true;
            cir.Visible = true;
            penta.Visible = true;
            num1.Text = "";
            num2.Text = "";
        }

        private void act_Click(object sender, EventArgs e)
        {
            instalador();
        }
    }
}
