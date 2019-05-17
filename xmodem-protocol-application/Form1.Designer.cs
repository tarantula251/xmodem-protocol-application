namespace xmodem_protocol_application
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.labelPort1 = new System.Windows.Forms.Label();
            this.labelPort2 = new System.Windows.Forms.Label();
            this.textBoxPort1 = new System.Windows.Forms.TextBox();
            this.textBoxPort2 = new System.Windows.Forms.TextBox();
            this.listBoxReceivedDataPort1 = new System.Windows.Forms.ListBox();
            this.listBoxReceivedDataPort2 = new System.Windows.Forms.ListBox();
            this.labelReceivedDataPort1 = new System.Windows.Forms.Label();
            this.labelReceivedDataPort2 = new System.Windows.Forms.Label();
            this.textBoxInputData1 = new System.Windows.Forms.TextBox();
            this.textBoxInputData2 = new System.Windows.Forms.TextBox();
            this.buttonOpenConnection1 = new System.Windows.Forms.Button();
            this.buttonOpenConnection2 = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.buttonBrowseData2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelChooseByteControl = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // labelPort1
            // 
            this.labelPort1.AutoSize = true;
            this.labelPort1.Location = new System.Drawing.Point(38, 50);
            this.labelPort1.Name = "labelPort1";
            this.labelPort1.Size = new System.Drawing.Size(96, 13);
            this.labelPort1.TabIndex = 0;
            this.labelPort1.Text = "Port 1  Transmitter:";
            // 
            // labelPort2
            // 
            this.labelPort2.AutoSize = true;
            this.labelPort2.Location = new System.Drawing.Point(336, 50);
            this.labelPort2.Name = "labelPort2";
            this.labelPort2.Size = new System.Drawing.Size(84, 13);
            this.labelPort2.TabIndex = 1;
            this.labelPort2.Text = "Port 2 Receiver:";
            // 
            // textBoxPort1
            // 
            this.textBoxPort1.Location = new System.Drawing.Point(41, 68);
            this.textBoxPort1.Name = "textBoxPort1";
            this.textBoxPort1.Size = new System.Drawing.Size(175, 20);
            this.textBoxPort1.TabIndex = 2;
            // 
            // textBoxPort2
            // 
            this.textBoxPort2.Location = new System.Drawing.Point(339, 68);
            this.textBoxPort2.Name = "textBoxPort2";
            this.textBoxPort2.Size = new System.Drawing.Size(175, 20);
            this.textBoxPort2.TabIndex = 3;
            // 
            // listBoxReceivedDataPort1
            // 
            this.listBoxReceivedDataPort1.FormattingEnabled = true;
            this.listBoxReceivedDataPort1.Location = new System.Drawing.Point(41, 138);
            this.listBoxReceivedDataPort1.Name = "listBoxReceivedDataPort1";
            this.listBoxReceivedDataPort1.Size = new System.Drawing.Size(254, 134);
            this.listBoxReceivedDataPort1.TabIndex = 4;
            // 
            // listBoxReceivedDataPort2
            // 
            this.listBoxReceivedDataPort2.FormattingEnabled = true;
            this.listBoxReceivedDataPort2.Location = new System.Drawing.Point(339, 138);
            this.listBoxReceivedDataPort2.Name = "listBoxReceivedDataPort2";
            this.listBoxReceivedDataPort2.Size = new System.Drawing.Size(254, 134);
            this.listBoxReceivedDataPort2.TabIndex = 5;
            // 
            // labelReceivedDataPort1
            // 
            this.labelReceivedDataPort1.AutoSize = true;
            this.labelReceivedDataPort1.Location = new System.Drawing.Point(38, 108);
            this.labelReceivedDataPort1.Name = "labelReceivedDataPort1";
            this.labelReceivedDataPort1.Size = new System.Drawing.Size(123, 13);
            this.labelReceivedDataPort1.TabIndex = 6;
            this.labelReceivedDataPort1.Text = "Data received on Port 1:";
            // 
            // labelReceivedDataPort2
            // 
            this.labelReceivedDataPort2.AutoSize = true;
            this.labelReceivedDataPort2.Location = new System.Drawing.Point(336, 108);
            this.labelReceivedDataPort2.Name = "labelReceivedDataPort2";
            this.labelReceivedDataPort2.Size = new System.Drawing.Size(123, 13);
            this.labelReceivedDataPort2.TabIndex = 7;
            this.labelReceivedDataPort2.Text = "Data received on Port 2:";
            // 
            // textBoxInputData1
            // 
            this.textBoxInputData1.Location = new System.Drawing.Point(41, 13);
            this.textBoxInputData1.Name = "textBoxInputData1";
            this.textBoxInputData1.Size = new System.Drawing.Size(175, 20);
            this.textBoxInputData1.TabIndex = 8;
            // 
            // textBoxInputData2
            // 
            this.textBoxInputData2.Location = new System.Drawing.Point(339, 12);
            this.textBoxInputData2.Name = "textBoxInputData2";
            this.textBoxInputData2.Size = new System.Drawing.Size(175, 20);
            this.textBoxInputData2.TabIndex = 9;
            // 
            // buttonOpenConnection1
            // 
            this.buttonOpenConnection1.Location = new System.Drawing.Point(222, 67);
            this.buttonOpenConnection1.Name = "buttonOpenConnection1";
            this.buttonOpenConnection1.Size = new System.Drawing.Size(73, 20);
            this.buttonOpenConnection1.TabIndex = 10;
            this.buttonOpenConnection1.Text = "Connect";
            this.buttonOpenConnection1.UseVisualStyleBackColor = true;
            this.buttonOpenConnection1.Click += new System.EventHandler(this.buttonOpenConnection1_Click);
            // 
            // buttonOpenConnection2
            // 
            this.buttonOpenConnection2.Location = new System.Drawing.Point(520, 68);
            this.buttonOpenConnection2.Name = "buttonOpenConnection2";
            this.buttonOpenConnection2.Size = new System.Drawing.Size(73, 20);
            this.buttonOpenConnection2.TabIndex = 11;
            this.buttonOpenConnection2.Text = "Connect";
            this.buttonOpenConnection2.UseVisualStyleBackColor = true;
            this.buttonOpenConnection2.Click += new System.EventHandler(this.buttonOpenConnection2_Click);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(222, 13);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(73, 20);
            this.buttonBrowseFile.TabIndex = 12;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // buttonBrowseData2
            // 
            this.buttonBrowseData2.Location = new System.Drawing.Point(520, 12);
            this.buttonBrowseData2.Name = "buttonBrowseData2";
            this.buttonBrowseData2.Size = new System.Drawing.Size(73, 20);
            this.buttonBrowseData2.TabIndex = 13;
            this.buttonBrowseData2.Text = "Save as";
            this.buttonBrowseData2.UseVisualStyleBackColor = true;
            this.buttonBrowseData2.Click += new System.EventHandler(this.buttonBrowseData2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(613, 138);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Checksum";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelChooseByteControl
            // 
            this.labelChooseByteControl.AutoSize = true;
            this.labelChooseByteControl.Location = new System.Drawing.Point(610, 108);
            this.labelChooseByteControl.Name = "labelChooseByteControl";
            this.labelChooseByteControl.Size = new System.Drawing.Size(104, 13);
            this.labelChooseByteControl.TabIndex = 15;
            this.labelChooseByteControl.Text = "Choose byte control:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(613, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CRC16";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 321);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.labelChooseByteControl);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonBrowseData2);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.buttonOpenConnection2);
            this.Controls.Add(this.buttonOpenConnection1);
            this.Controls.Add(this.textBoxInputData2);
            this.Controls.Add(this.textBoxInputData1);
            this.Controls.Add(this.labelReceivedDataPort2);
            this.Controls.Add(this.labelReceivedDataPort1);
            this.Controls.Add(this.listBoxReceivedDataPort2);
            this.Controls.Add(this.listBoxReceivedDataPort1);
            this.Controls.Add(this.textBoxPort2);
            this.Controls.Add(this.textBoxPort1);
            this.Controls.Add(this.labelPort2);
            this.Controls.Add(this.labelPort1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPort1;
        private System.Windows.Forms.Label labelPort2;
        private System.Windows.Forms.TextBox textBoxPort1;
        private System.Windows.Forms.TextBox textBoxPort2;
        private System.Windows.Forms.ListBox listBoxReceivedDataPort1;
        private System.Windows.Forms.ListBox listBoxReceivedDataPort2;
        private System.Windows.Forms.Label labelReceivedDataPort1;
        private System.Windows.Forms.Label labelReceivedDataPort2;
        private System.Windows.Forms.TextBox textBoxInputData1;
        private System.Windows.Forms.TextBox textBoxInputData2;
        private System.Windows.Forms.Button buttonOpenConnection1;
        private System.Windows.Forms.Button buttonOpenConnection2;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Button buttonBrowseData2;
        public System.IO.Ports.SerialPort serialPort1;
        public System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelChooseByteControl;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

