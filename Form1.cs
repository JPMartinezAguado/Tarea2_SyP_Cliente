using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Tarea2_SyP_Cliente
{
    public partial class Form1 : Form
    {
        //clases necesarias para iniciar el proceso del notepad
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Activar ventana de una aplicación
        [DllImport("USER32.DLL")]

        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        //evento asociado al boton de formulario conectar, que llama a la tarea asignada para ello
        private async void conectar_Click(object sender, EventArgs e)
        {

            await Conectar();
        }

        /// <summary>
        /// Tarea que arranca el cliente, incial el pipe de conexion al servidor y lee el flujo de datos esperando informacion
        /// </summary>
        /// <returns></returns>
        private async Task Conectar()
        {
            using NamedPipeClientStream clientePipe = new NamedPipeClientStream(".", "servidor", PipeDirection.In);

            mensajeEntrada.Text = "Bienvenido. Esperando conexion al gran Oraculo que todo lo sabe";

            // permanece a la espera hasta que establece conexion con el servidor: 
            await clientePipe.ConnectAsync();

            mensajeEntrada.Text = "Se ha conectado al gran Oraculo.\r\n";
            mensajeEntrada.Text += "Le irá indicando una serie de instruccion. Por favor, sigua los pasos que le indique\r\n\r\n";


            //lectura de datos desde el flujo recibido a traves del pipe
            StreamReader sr = new StreamReader(clientePipe);

            // Lee el mensaje enviado desde el servidor: 
            string mensajeServidorPipe;

            //mientras los datos recibidos por el flujo no son nulos, el cliente sigue leyendo el flujo y añadiendo datos al cudro de texto del formulado
            //designado para recogerlos
            while ((mensajeServidorPipe = await sr.ReadLineAsync()) != null)
            {
                mensajeEntrada.Text += mensajeServidorPipe+"\r\n\r\n";
                sr = new StreamReader(clientePipe);
            }

        }

        private void mensajeEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// evento de boton que incia el proceso de la calculadora del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encenderCalculadora_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "calc";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
        }

        /// <summary>
        /// Evento de boton del formulario que incia el proceso del notepad y lo abre con una informacion predeterminada en el metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirNotepad_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = "notepad.exe";
            proceso.StartInfo.UseShellExecute = false;   //Para poder redirigir
            proceso.StartInfo.RedirectStandardInput = true;
            proceso.StartInfo.RedirectStandardOutput = true;
            proceso.StartInfo.RedirectStandardError = true;
            proceso.Start();

            System.Threading.Thread.Sleep(2000);
            //Crear manejador del proceso para encontrar la ventana
            IntPtr notepadHandle = FindWindow("Notepad", "Sin título: Bloc de notas");

            // Poner al NotePad en primer plano y pasarle datos
            SetForegroundWindow(notepadHandle);
            SendKeys.SendWait("***********Bienvenido al asistente del Oraculo.****************\r\n\r\n");
            SendKeys.SendWait("Escriba aqui su numero elegido de 6, 7, o mas cifras\r\n");
            SendKeys.SendWait("\r\n");
            SendKeys.SendWait("Ahora sume todos los digitos de su numero y apunte aqui el resultado, le llamaremos \"X\":\r\n");
            SendKeys.SendWait("\"X\" es igual a: \r\n\r\n");
            SendKeys.SendWait("Despues reste a su numero elegido, el resultado de \"x\". Al numero resultante le llamaremos \"Y\" \r\n\r\n");
            SendKeys.SendWait("Si \"Y\" es un numero de 2 o mas digitos, sume éstos consecutivamente hasta que obtenga un solo digito\r\n\r\n");
            SendKeys.SendWait("Ya solo le queda comparar este digito con la prediccion del Oraculo.\r\n Hasta luego, y gracias por el pescado!");
        }

        /// <summary>
        /// metodo que recoge el evento de boton del formulario y que lee el archivo generado 
        /// por el servidor, o bien muestra un mensaje en caso de no haber sido generado todavia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirPrediccion_Click(object sender, EventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            string filepath = Path.Combine(folderPath, "prediccion.txt");
            if (File.Exists(filepath))
            {
                Process process2 = new Process();
                process2.StartInfo.FileName = filepath;
                process2.StartInfo.UseShellExecute = true;
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process2.Start();
            }
            else
            {
                mensajeEntrada.Text = "Prediccion aun no realizada";
            }
        }

        //evento para cerrar el programa
        private void apagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //evento de click  de boton que indica por texto la hora del momento de llamada al evento
        private void hora_Click(object sender, EventArgs e)
        {
            label1.Text = "La hora actual es " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
