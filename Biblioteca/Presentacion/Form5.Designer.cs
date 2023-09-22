namespace Biblioteca.Presentacion
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.LblLibro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DTfechaD = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(60, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(784, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 158);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IdLibro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Existencia";
            // 
            // lbld
            // 
            this.lbld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbld.Location = new System.Drawing.Point(65, 37);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(125, 24);
            this.lbld.TabIndex = 6;
            this.lbld.Click += new System.EventHandler(this.LblidLibro_Click);
            // 
            // LblLibro
            // 
            this.LblLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLibro.Location = new System.Drawing.Point(241, 38);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(183, 23);
            this.LblLibro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Autor";
            // 
            // LblAutor
            // 
            this.LblAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAutor.Location = new System.Drawing.Point(241, 74);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(183, 23);
            this.LblAutor.TabIndex = 9;
            this.LblAutor.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Libro";
            // 
            // LblExistencia
            // 
            this.LblExistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblExistencia.Location = new System.Drawing.Point(65, 72);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(125, 23);
            this.LblExistencia.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha_Devolucion";
            // 
            // LblFecha
            // 
            this.LblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFecha.Location = new System.Drawing.Point(516, 46);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(134, 22);
            this.LblFecha.TabIndex = 14;
            this.LblFecha.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(661, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "label14";
            // 
            // DTfechaD
            // 
            this.DTfechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfechaD.Location = new System.Drawing.Point(558, 82);
            this.DTfechaD.Name = "DTfechaD";
            this.DTfechaD.Size = new System.Drawing.Size(92, 20);
            this.DTfechaD.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 59);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 57);
            this.button2.TabIndex = 18;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DTfechaD);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LblExistencia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LblAutor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LblLibro);
            this.panel1.Controls.Add(this.lbld);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 122);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.Libro,
            this.Autor,
            this.Fecha_Devolucion});
            this.dataGridView2.Location = new System.Drawing.Point(5, 330);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 179);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Width = 245;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 245;
            // 
            // Fecha_Devolucion
            // 
            this.Fecha_Devolucion.HeaderText = "Fecha_Devolucion";
            this.Fecha_Devolucion.Name = "Fecha_Devolucion";
            this.Fecha_Devolucion.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(751, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 40);
            this.button3.TabIndex = 21;
            this.button3.Text = "Nuevo Prestamo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(751, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 34);
            this.button4.TabIndex = 22;
            this.button4.Text = "Buscar Prestamo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(746, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Total libros prestados";
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotal.Location = new System.Drawing.Point(760, 462);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(84, 27);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.Click += new System.EventHandler(this.label16_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 509);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label LblLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DTfechaD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Devolucion;
    }
}