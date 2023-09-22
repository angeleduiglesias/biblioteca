namespace Biblioteca.Presentacion
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAccesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCCESOToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.prestamosLibrosToolStripMenuItem,
            this.registrarAccesoToolStripMenuItem,
            this.examinarToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // prestamosLibrosToolStripMenuItem
            // 
            this.prestamosLibrosToolStripMenuItem.Name = "prestamosLibrosToolStripMenuItem";
            this.prestamosLibrosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.prestamosLibrosToolStripMenuItem.Text = "Prestamos libros";
            this.prestamosLibrosToolStripMenuItem.Click += new System.EventHandler(this.prestamosLibrosToolStripMenuItem_Click);
            // 
            // registrarAccesoToolStripMenuItem
            // 
            this.registrarAccesoToolStripMenuItem.Name = "registrarAccesoToolStripMenuItem";
            this.registrarAccesoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.registrarAccesoToolStripMenuItem.Text = "Registrar Acceso";
            // 
            // examinarToolStripMenuItem
            // 
            this.examinarToolStripMenuItem.Name = "examinarToolStripMenuItem";
            this.examinarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.examinarToolStripMenuItem.Text = "Examinar";
            this.examinarToolStripMenuItem.Click += new System.EventHandler(this.examinarToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaFechaToolStripMenuItem,
            this.consultaAñoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // consultaFechaToolStripMenuItem
            // 
            this.consultaFechaToolStripMenuItem.Name = "consultaFechaToolStripMenuItem";
            this.consultaFechaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.consultaFechaToolStripMenuItem.Text = "Consulta fecha";
            this.consultaFechaToolStripMenuItem.Click += new System.EventHandler(this.consultaFechaToolStripMenuItem_Click);
            // 
            // consultaAñoToolStripMenuItem
            // 
            this.consultaAñoToolStripMenuItem.Name = "consultaAñoToolStripMenuItem";
            this.consultaAñoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.consultaAñoToolStripMenuItem.Text = "Consulta año";
            this.consultaAñoToolStripMenuItem.Click += new System.EventHandler(this.consultaAñoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // aCCESOToolStripMenuItem
            // 
            this.aCCESOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aCCESOToolStripMenuItem.Image")));
            this.aCCESOToolStripMenuItem.Name = "aCCESOToolStripMenuItem";
            this.aCCESOToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.aCCESOToolStripMenuItem.Text = "ACCESO";
            this.aCCESOToolStripMenuItem.Click += new System.EventHandler(this.aCCESOToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(445, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 214);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarAccesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem consultaFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCCESOToolStripMenuItem;
    }
}