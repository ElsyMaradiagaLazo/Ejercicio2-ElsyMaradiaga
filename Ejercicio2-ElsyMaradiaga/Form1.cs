namespace Ejercicio2_ElsyMaradiaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Elsy Yohana Maradiaga Lazo - 20191002864 
        //Ejercicio#2
        //Lenguaje de programacion III-seccion 1400

        private void Guardarbutton1_Click(object sender, EventArgs e)
        {
            //Primero se realizara la opcion de poder guardar datos de cada estudiante y le daremos un limite de 5
            //Prodecimiento
        
            String[] ArregloNombre = new string[1];
            for (int i = 0; i < ArregloNombre.Length; i++)
            {
                ArregloNombre[i] = EstudiantetextBox1.Text;
                listBox1.Items.Add(ArregloNombre[i]);

            }
            int[] ArregloEdad = new int[1];
            int Edad = Convert.ToInt32(EdadtextBox2.Text);
            for (int i = 0; i < ArregloEdad.Length; i++)
            {
                ArregloEdad[i] = Edad;
                listBox2.Items.Add(ArregloEdad[i]);

            }
        }
    }


}
 