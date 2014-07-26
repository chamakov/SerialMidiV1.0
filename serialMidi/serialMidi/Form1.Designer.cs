namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.botonConectar = new System.Windows.Forms.Button();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.seleccionSerial = new System.Windows.Forms.ComboBox();
            this.seleccionBaudrate = new System.Windows.Forms.ComboBox();
            this.registroEventos = new System.Windows.Forms.RichTextBox();
            this.etiquetaSerial = new System.Windows.Forms.Label();
            this.etiquetaBaudrate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.etiquetaMidi = new System.Windows.Forms.Label();
            this.seleccionMidi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(12, 81);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(121, 41);
            this.botonConectar.TabIndex = 0;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Location = new System.Drawing.Point(347, 81);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(121, 41);
            this.botonDesconectar.TabIndex = 1;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // seleccionSerial
            // 
            this.seleccionSerial.FormattingEnabled = true;
            this.seleccionSerial.Location = new System.Drawing.Point(12, 29);
            this.seleccionSerial.Name = "seleccionSerial";
            this.seleccionSerial.Size = new System.Drawing.Size(121, 21);
            this.seleccionSerial.Sorted = true;
            this.seleccionSerial.TabIndex = 2;
            this.seleccionSerial.SelectedIndexChanged += new System.EventHandler(this.seleccionSerial_SelectedIndexChanged);
            // 
            // seleccionBaudrate
            // 
            this.seleccionBaudrate.FormattingEnabled = true;
            this.seleccionBaudrate.Location = new System.Drawing.Point(177, 29);
            this.seleccionBaudrate.Name = "seleccionBaudrate";
            this.seleccionBaudrate.Size = new System.Drawing.Size(121, 21);
            this.seleccionBaudrate.TabIndex = 3;
            // 
            // registroEventos
            // 
            this.registroEventos.Location = new System.Drawing.Point(12, 128);
            this.registroEventos.Name = "registroEventos";
            this.registroEventos.Size = new System.Drawing.Size(456, 159);
            this.registroEventos.TabIndex = 4;
            this.registroEventos.Text = "";
            // 
            // etiquetaSerial
            // 
            this.etiquetaSerial.AutoSize = true;
            this.etiquetaSerial.Location = new System.Drawing.Point(12, 13);
            this.etiquetaSerial.Name = "etiquetaSerial";
            this.etiquetaSerial.Size = new System.Drawing.Size(65, 13);
            this.etiquetaSerial.TabIndex = 5;
            this.etiquetaSerial.Text = "Puerto Serie";
            // 
            // etiquetaBaudrate
            // 
            this.etiquetaBaudrate.AutoSize = true;
            this.etiquetaBaudrate.Location = new System.Drawing.Point(174, 13);
            this.etiquetaBaudrate.Name = "etiquetaBaudrate";
            this.etiquetaBaudrate.Size = new System.Drawing.Size(50, 13);
            this.etiquetaBaudrate.TabIndex = 6;
            this.etiquetaBaudrate.Text = "Baudrate";
            // 
            // etiquetaMidi
            // 
            this.etiquetaMidi.AutoSize = true;
            this.etiquetaMidi.Location = new System.Drawing.Point(344, 13);
            this.etiquetaMidi.Name = "etiquetaMidi";
            this.etiquetaMidi.Size = new System.Drawing.Size(64, 13);
            this.etiquetaMidi.TabIndex = 7;
            this.etiquetaMidi.Text = "Puerto MIDI";
            // 
            // seleccionMidi
            // 
            this.seleccionMidi.FormattingEnabled = true;
            this.seleccionMidi.Location = new System.Drawing.Point(347, 29);
            this.seleccionMidi.Name = "seleccionMidi";
            this.seleccionMidi.Size = new System.Drawing.Size(121, 21);
            this.seleccionMidi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.seleccionMidi);
            this.Controls.Add(this.etiquetaMidi);
            this.Controls.Add(this.etiquetaBaudrate);
            this.Controls.Add(this.etiquetaSerial);
            this.Controls.Add(this.registroEventos);
            this.Controls.Add(this.seleccionBaudrate);
            this.Controls.Add(this.seleccionSerial);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.botonConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.ComboBox seleccionSerial;
        private System.Windows.Forms.ComboBox seleccionBaudrate;
        private System.Windows.Forms.Label etiquetaSerial;
        private System.Windows.Forms.Label etiquetaBaudrate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label etiquetaMidi;
        public System.Windows.Forms.RichTextBox registroEventos;
        public System.Windows.Forms.ComboBox seleccionMidi;
    }
}

