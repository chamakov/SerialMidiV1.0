using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Midi;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Clock timeClock = new Clock(140);
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            /*Poblamos el combo del puerto serial*/
            string[] puerto = SerialPort.GetPortNames();
            foreach (string port in puerto)
            {
                seleccionSerial.Items.Add(port);
            }   

            /*Poblamos combo de baurates*/
            int[] baudrate = { 300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };
            foreach (int numero in baudrate)
            {
                seleccionBaudrate.Items.Add(numero);
            }

            /*Poblamos la tabla de puertos midi*/
            foreach (OutputDevice device in OutputDevice.InstalledDevices)
            {
                seleccionMidi.Items.Add(device.Name);            
            }

            /*Seleccionamos los valores por defecto de los combo box*/
            seleccionBaudrate.SelectedIndex = 4;
            seleccionSerial.SelectedIndex = 0;
            seleccionMidi.SelectedIndex = 0;

            /*Establecemos que el puerto reciba datos*/
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_dataRecieved);


        }
        

        /*Establecemos la rutina para poder leer los datos provenientes del puerto serial*/
        private void port_dataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            OutputDevice output = OutputDevice.InstalledDevices[seleccionMidi.SelectedIndex];
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            serialPort1.Read(buffer, 0, bytes);
            registroEventos.AppendText("\n");
            registroEventos.ScrollToCaret();
            registroEventos.AppendText(sendMidiMessage.sendMessage(output, buffer));
            /*Agregar aqui el append con motivos de debug*/
        }


        /*Tratamos y mostramos los datos en el richtextbox*/

        private void showSerialData(byte[] data)
        {
            foreach (byte ed in data)
            {
                int recibido = Convert.ToInt32(ed);
                registroEventos.AppendText(Convert.ToString(recibido) + " ");
            } 
            registroEventos.AppendText("\n");
            registroEventos.ScrollToCaret();

        
        }


        bool conectado = false;

        private void seleccionSerial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            if (!conectado)
            {
                try
                {
                    /*Inicializamos el puerto serial, esto cuando presionamos el boton conectar*/
                    int baudrate = int.Parse(seleccionBaudrate.Text);
                    serialPort1.PortName = seleccionSerial.Text;
                    serialPort1.BaudRate = baudrate;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    sendMidiMessage.openMidiPort(seleccionMidi.SelectedIndex);
                    conectado = true;
                    registroEventos.AppendText("Conectado\n");
                    registroEventos.ScrollToCaret();
                    botonConectar.Enabled = false;
                    botonDesconectar.Enabled = true;
                }
                catch (IOException ex)
                {
                    
                    MessageBox.Show(("Error en la conexión " + ex.Message),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    serialPort1.Close();
                    registroEventos.ScrollToCaret();
                
                }
            }
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                conectado = false;
                if (serialPort1 != null)
                {
                    serialPort1.Close();
                    sendMidiMessage.closeMidiPort(seleccionMidi.SelectedIndex);
                    registroEventos.AppendText("Desconectado\n");
                    registroEventos.ScrollToCaret();
                    botonConectar.Enabled = true;
                    botonDesconectar.Enabled = false;
                }
            }
        }

        private void enviarMensaje_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
            registroEventos.AppendText("Mensaje Enviado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
