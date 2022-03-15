namespace Bascula_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DatosRecibidos = new System.Windows.Forms.GroupBox();
            this.TxtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.Conexion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Puertos = new System.Windows.Forms.GroupBox();
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.CmbPuertos = new System.Windows.Forms.ComboBox();
            this.DatosRecibidos.SuspendLayout();
            this.Conexion.SuspendLayout();
            this.Puertos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosRecibidos
            // 
            this.DatosRecibidos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DatosRecibidos.Controls.Add(this.TxtDatosRecibidos);
            this.DatosRecibidos.ForeColor = System.Drawing.Color.Black;
            this.DatosRecibidos.Location = new System.Drawing.Point(65, 208);
            this.DatosRecibidos.Name = "DatosRecibidos";
            this.DatosRecibidos.Size = new System.Drawing.Size(474, 179);
            this.DatosRecibidos.TabIndex = 3;
            this.DatosRecibidos.TabStop = false;
            this.DatosRecibidos.Text = "Datos";
            // 
            // TxtDatosRecibidos
            // 
            this.TxtDatosRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(29, 35);
            this.TxtDatosRecibidos.Multiline = true;
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(415, 119);
            this.TxtDatosRecibidos.TabIndex = 0;
            this.TxtDatosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Conexion
            // 
            this.Conexion.Controls.Add(this.label1);
            this.Conexion.Controls.Add(this.BtnConectar);
            this.Conexion.ForeColor = System.Drawing.Color.Black;
            this.Conexion.Location = new System.Drawing.Point(65, 126);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(474, 75);
            this.Conexion.TabIndex = 2;
            this.Conexion.TabStop = false;
            this.Conexion.Text = "Conexion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conectar Puerto RS 232";
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnConectar.ForeColor = System.Drawing.Color.Black;
            this.BtnConectar.Location = new System.Drawing.Point(285, 27);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(87, 27);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1200;
            this.serialPort1.DataBits = 7;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.serialPort1.Parity = System.IO.Ports.Parity.Odd;
            this.serialPort1.ReadTimeout = 10;
            this.serialPort1.WriteTimeout = 10;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_Received);
            // 
            // Puertos
            // 
            this.Puertos.Controls.Add(this.BtnBuscarPuertos);
            this.Puertos.Controls.Add(this.CmbPuertos);
            this.Puertos.ForeColor = System.Drawing.Color.Black;
            this.Puertos.Location = new System.Drawing.Point(65, 29);
            this.Puertos.Name = "Puertos";
            this.Puertos.Size = new System.Drawing.Size(474, 74);
            this.Puertos.TabIndex = 4;
            this.Puertos.TabStop = false;
            this.Puertos.Text = "Puertos Disponibles";
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnBuscarPuertos.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(285, 22);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(115, 24);
            this.BtnBuscarPuertos.TabIndex = 4;
            this.BtnBuscarPuertos.Text = "Buscar Puertos";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = false;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // CmbPuertos
            // 
            this.CmbPuertos.FormattingEnabled = true;
            this.CmbPuertos.Location = new System.Drawing.Point(100, 22);
            this.CmbPuertos.Name = "CmbPuertos";
            this.CmbPuertos.Size = new System.Drawing.Size(119, 23);
            this.CmbPuertos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(605, 417);
            this.Controls.Add(this.Puertos);
            this.Controls.Add(this.DatosRecibidos);
            this.Controls.Add(this.Conexion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DatosRecibidos.ResumeLayout(false);
            this.DatosRecibidos.PerformLayout();
            this.Conexion.ResumeLayout(false);
            this.Conexion.PerformLayout();
            this.Puertos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosRecibidos;
        private System.Windows.Forms.TextBox TxtDatosRecibidos;
        private System.Windows.Forms.GroupBox Conexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox Puertos;
        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.ComboBox CmbPuertos;
    }
}

