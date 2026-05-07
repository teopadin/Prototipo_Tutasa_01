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
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label4 = new Label();
            textBox1 = new TextBox();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 49);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 47);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 181);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 12;
            label2.Text = "Guias";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 600);
            label3.Name = "label3";
            label3.Size = new Size(1328, 41);
            label3.TabIndex = 14;
            label3.Text = "Servicios disponibles (criterio: almacenamiento disponible que se selecciono arriba y el CD destino)";
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
            // HojaDeRutaDeTransporte_v2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 1052);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(lvGuiasPendientes);
            Controls.Add(label1);
            Controls.Add(comboBox1);
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
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label4;
        private TextBox textBox1;
        private ColumnHeader columnHeader4;
        private Button button1;
        private ColumnHeader columnHeader5;
    }
}