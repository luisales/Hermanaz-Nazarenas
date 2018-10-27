namespace Hermanas_nazario
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burcarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarIngresoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEgresoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constanciaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.documentosMedicosToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(895, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.burcarPacienteToolStripMenuItem,
            this.modificarPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar paciente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // burcarPacienteToolStripMenuItem
            // 
            this.burcarPacienteToolStripMenuItem.Name = "burcarPacienteToolStripMenuItem";
            this.burcarPacienteToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.burcarPacienteToolStripMenuItem.Text = "Buscar paciente";
            this.burcarPacienteToolStripMenuItem.Click += new System.EventHandler(this.burcarPacienteToolStripMenuItem_Click);
            // 
            // modificarPacienteToolStripMenuItem
            // 
            this.modificarPacienteToolStripMenuItem.Name = "modificarPacienteToolStripMenuItem";
            this.modificarPacienteToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.modificarPacienteToolStripMenuItem.Text = "Modificar paciente";
            this.modificarPacienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPacienteToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarIngresoDeMedicamentosToolStripMenuItem,
            this.registrarEgresoDeMedicamentosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarIngresoDeMedicamentosToolStripMenuItem
            // 
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Name = "registrarIngresoDeMedicamentosToolStripMenuItem";
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.registrarIngresoDeMedicamentosToolStripMenuItem.Text = "Registrar ingreso de medicamentos";
            // 
            // registrarEgresoDeMedicamentosToolStripMenuItem
            // 
            this.registrarEgresoDeMedicamentosToolStripMenuItem.Name = "registrarEgresoDeMedicamentosToolStripMenuItem";
            this.registrarEgresoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(376, 30);
            this.registrarEgresoDeMedicamentosToolStripMenuItem.Text = "Registrar egreso de medicamentos";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // documentosMedicosToolStripMenuItem
            // 
            this.documentosMedicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constanciaMedicaToolStripMenuItem,
            this.referenciaMedicaToolStripMenuItem});
            this.documentosMedicosToolStripMenuItem.Name = "documentosMedicosToolStripMenuItem";
            this.documentosMedicosToolStripMenuItem.Size = new System.Drawing.Size(198, 29);
            this.documentosMedicosToolStripMenuItem.Text = "Documentos Medicos";
            // 
            // constanciaMedicaToolStripMenuItem
            // 
            this.constanciaMedicaToolStripMenuItem.Name = "constanciaMedicaToolStripMenuItem";
            this.constanciaMedicaToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.constanciaMedicaToolStripMenuItem.Text = "Constancia Medica";
            // 
            // referenciaMedicaToolStripMenuItem
            // 
            this.referenciaMedicaToolStripMenuItem.Name = "referenciaMedicaToolStripMenuItem";
            this.referenciaMedicaToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.referenciaMedicaToolStripMenuItem.Text = "Referencia Medica";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar usuario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 599);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menu";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burcarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarIngresoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEgresoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constanciaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}