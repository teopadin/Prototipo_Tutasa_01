namespace Prototipos_TUTASA.HojaDeRutaDeTransporte_v2
{
    partial class HojaDeRutaDeTransporte_v2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            lvGuiasPendientes = new ListView();
            colNumeroGuia = new ColumnHeader();
            colTipoBultoLista = new ColumnHeader();
            colFechaGuia = new ColumnHeader();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label4 = new Label();
            textBox1 = new TextBox();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 49);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 1;
            label1.Text = "CD Destino";
            // 
            // lvGuiasPendientes
            // 
            lvGuiasPendientes.Columns.AddRange(new ColumnHeader[] { colNumeroGuia, colFechaGuia, colTipoBultoLista });
            lvGuiasPendientes.FullRowSelect = true;
            lvGuiasPendientes.Location = new Point(54, 230);
            lvGuiasPendientes.Margin = new Padding(7, 8, 7, 8);
            lvGuiasPendientes.Name = "lvGuiasPendientes";
            lvGuiasPendientes.Size = new Size(1430, 256);
            lvGuiasPendientes.TabIndex = 11;
            lvGuiasPendientes.UseCompatibleStateImageBehavior = false;
            lvGuiasPendientes.View = View.Details;
            lvGuiasPendientes.SelectedIndexChanged += lvGuiasPendientes_SelectedIndexChanged;
            // 
            // colNumeroGuia
            // 
            colNumeroGuia.Text = "Nro Guia";
            colNumeroGuia.Width = 200;
            // 
            // colTipoBultoLista
            // 
            colTipoBultoLista.Text = "Tipo de Bulto";
            colTipoBultoLista.Width = 200;
            // 
            // colFechaGuia
            // 
            colFechaGuia.Text = "Fecha";
            colFechaGuia.Width = 200;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(54, 659);
            listView1.Margin = new Padding(7, 8, 7, 8);
            listView1.Name = "listView1";
            listView1.Size = new Size(1430, 256);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID Servicio";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Empresa ";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Capacidad disp. (en tamano S)";
            columnHeader3.Width = 400;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 516);
            label4.Name = "label4";
            label4.Size = new Size(464, 41);
            label4.TabIndex = 15;
            label4.Text = "Bultos seleccionados (equiv. en S)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(524, 516);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 47);
            textBox1.TabIndex = 16;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Horario salida";
            columnHeader4.Width = 300;
            // 
            // button1
            // 
            button1.Location = new Point(1214, 960);
            button1.Name = "button1";
            button1.Size = new Size(270, 70);
            button1.TabIndex = 17;
            button1.Text = "Generar HDR";
            button1.UseVisualStyleBackColor = true;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Tipo de Servicio";
            columnHeader5.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1516, 395);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guias";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 600);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1516, 340);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios disponibles (criterio: almacenamiento disponible que se selecciono arriba y el CD destino)";
            // 
            // HojaDeRutaDeTransporte_v2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 1052);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(lvGuiasPendientes);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "HojaDeRutaDeTransporte_v2";
            Text = "HojaDeRutaDeTransporte_v2";
            Load += HojaDeRutaDeTransporte_v2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ListView lvGuiasPendientes;
        private ColumnHeader colNumeroGuia;
        private ColumnHeader colTipoBultoLista;
        private ColumnHeader colFechaGuia;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label4;
        private TextBox textBox1;
        private ColumnHeader columnHeader4;
        private Button button1;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}