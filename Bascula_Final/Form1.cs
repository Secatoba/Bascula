using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;



namespace Bascula_Final
{
    public partial class Form1 : Form
    {
        string strBufferIn;
        string Linea = "";

        public Form1()
        {

            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            TxtDatosRecibidos.Text = "";
            strBufferIn = "";


        }

        private void BtnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            CmbPuertos.Items.Clear();

            foreach (string Puerto_simple in PuertosDisponibles)
            {
                CmbPuertos.Items.Add(Puerto_simple);
            }

            if (CmbPuertos.Items.Count > 0)
            {
                CmbPuertos.SelectedItem = 0;
                MessageBox.Show("SELECCIONAR PUERTO DE TRABAJO");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY NINGUN PUERTO CONECTADO");
                CmbPuertos.Items.Clear();
                CmbPuertos.Text = "";
            }
        }


        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (BtnConectar.Text == "Conectar")
            {

                serialPort1.BaudRate = 1200;
                serialPort1.DataBits = 7;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.Odd;
                serialPort1.PortName = CmbPuertos.Text;
                serialPort1.Handshake = Handshake.None;
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;


                serialPort1.DataReceived += new SerialDataReceivedEventHandler(Port_Received);




                if (!serialPort1.IsOpen)
                {
                    try
                    {

                        serialPort1.Open();

                        BtnConectar.Text = "Desconectar";

                    }
                    catch (System.Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            else
            {

                serialPort1.Close();

                BtnConectar.Text = "Conectar";
            }

        }

        private void Port_Received(object sender, SerialDataReceivedEventArgs EvtArgs)
        {

            strBufferIn = "";

            Thread.Sleep(250);
            strBufferIn += serialPort1.ReadExisting();
            if (serialPort1.BytesToRead >= 0)
            {
                strBufferIn += serialPort1.ReadExisting();

                Linea = "";
                Linea = strBufferIn;
                Linea.Replace('.', ',');
                this.Invoke(new EventHandler(Actualiza_Textbox));

            }

        }


        private void Actualiza_Textbox(object s, EventArgs e)
        {


            string dato = Linea;

            char[] Quitar = { 'N', '+', ' ', 'g', ':', '\t', 'n', '\r', '\n' };
            string StrInicial = dato.Trim(Quitar);
            string StrFin = StrInicial.TrimEnd(Quitar);
            string StrLimpio = StrFin.Replace('.', ',');

            TxtDatosRecibidos.Text += StrLimpio;
            string EnviarDato = TxtDatosRecibidos.Text;
            Clipboard.SetText(EnviarDato);

        }

    }


}

    

