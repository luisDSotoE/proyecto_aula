namespace Presentacion
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
            this.panelMenuL = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_INICIO = new System.Windows.Forms.Button();
            this.panelSudMenuInicio = new System.Windows.Forms.Panel();
            this.btn_FA = new System.Windows.Forms.Button();
            this.btn_SM = new System.Windows.Forms.Button();
            this.btn_Maquinaria = new System.Windows.Forms.Button();
            this.btn_Fact = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Mercancia = new System.Windows.Forms.Button();
            this.btn_Despachar = new System.Windows.Forms.Button();
            this.panel_SudMenuFact = new System.Windows.Forms.Panel();
            this.btn_costos = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panelMenuL.SuspendLayout();
            this.panelSudMenuInicio.SuspendLayout();
            this.panel_SudMenuFact.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuL
            // 
            this.panelMenuL.AutoScroll = true;
            this.panelMenuL.BackColor = System.Drawing.Color.ForestGreen;
            this.panelMenuL.Controls.Add(this.btn_Salir);
            this.panelMenuL.Controls.Add(this.panel_SudMenuFact);
            this.panelMenuL.Controls.Add(this.btn_Fact);
            this.panelMenuL.Controls.Add(this.panelSudMenuInicio);
            this.panelMenuL.Controls.Add(this.btn_INICIO);
            this.panelMenuL.Controls.Add(this.panelLogo);
            this.panelMenuL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuL.Location = new System.Drawing.Point(0, 0);
            this.panelMenuL.Name = "panelMenuL";
            this.panelMenuL.Size = new System.Drawing.Size(250, 653);
            this.panelMenuL.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_INICIO
            // 
            this.btn_INICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_INICIO.FlatAppearance.BorderSize = 0;
            this.btn_INICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INICIO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INICIO.Location = new System.Drawing.Point(0, 100);
            this.btn_INICIO.Name = "btn_INICIO";
            this.btn_INICIO.Size = new System.Drawing.Size(229, 45);
            this.btn_INICIO.TabIndex = 1;
            this.btn_INICIO.Text = "INICIO";
            this.btn_INICIO.UseVisualStyleBackColor = true;
            this.btn_INICIO.Click += new System.EventHandler(this.btn_INICIO_Click);
            // 
            // panelSudMenuInicio
            // 
            this.panelSudMenuInicio.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSudMenuInicio.Controls.Add(this.btn_Maquinaria);
            this.panelSudMenuInicio.Controls.Add(this.btn_SM);
            this.panelSudMenuInicio.Controls.Add(this.btn_FA);
            this.panelSudMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSudMenuInicio.Location = new System.Drawing.Point(0, 145);
            this.panelSudMenuInicio.Name = "panelSudMenuInicio";
            this.panelSudMenuInicio.Size = new System.Drawing.Size(229, 152);
            this.panelSudMenuInicio.TabIndex = 2;
            // 
            // btn_FA
            // 
            this.btn_FA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FA.FlatAppearance.BorderSize = 0;
            this.btn_FA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_FA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_FA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FA.Location = new System.Drawing.Point(0, 0);
            this.btn_FA.Name = "btn_FA";
            this.btn_FA.Size = new System.Drawing.Size(229, 56);
            this.btn_FA.TabIndex = 0;
            this.btn_FA.Text = "Fertilizantes y agroquímicos.";
            this.btn_FA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FA.UseVisualStyleBackColor = true;
            // 
            // btn_SM
            // 
            this.btn_SM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SM.FlatAppearance.BorderSize = 0;
            this.btn_SM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_SM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SM.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SM.Location = new System.Drawing.Point(0, 56);
            this.btn_SM.Name = "btn_SM";
            this.btn_SM.Size = new System.Drawing.Size(229, 61);
            this.btn_SM.TabIndex = 1;
            this.btn_SM.Text = "Semillas y materiales para la siembra.";
            this.btn_SM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SM.UseVisualStyleBackColor = true;
            // 
            // btn_Maquinaria
            // 
            this.btn_Maquinaria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Maquinaria.FlatAppearance.BorderSize = 0;
            this.btn_Maquinaria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Maquinaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Maquinaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maquinaria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maquinaria.Location = new System.Drawing.Point(0, 117);
            this.btn_Maquinaria.Name = "btn_Maquinaria";
            this.btn_Maquinaria.Size = new System.Drawing.Size(229, 29);
            this.btn_Maquinaria.TabIndex = 2;
            this.btn_Maquinaria.Text = "Maquinaria y equipos.";
            this.btn_Maquinaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Maquinaria.UseVisualStyleBackColor = true;
            // 
            // btn_Fact
            // 
            this.btn_Fact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fact.FlatAppearance.BorderSize = 0;
            this.btn_Fact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fact.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fact.Location = new System.Drawing.Point(0, 297);
            this.btn_Fact.Name = "btn_Fact";
            this.btn_Fact.Size = new System.Drawing.Size(229, 79);
            this.btn_Fact.TabIndex = 3;
            this.btn_Fact.Text = "FACTURA Y CONTROL DE INVENTARIO";
            this.btn_Fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fact.UseVisualStyleBackColor = true;
            this.btn_Fact.Click += new System.EventHandler(this.btn_Fact_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Facturar.FlatAppearance.BorderSize = 0;
            this.btn_Facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.Location = new System.Drawing.Point(0, 0);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(229, 40);
            this.btn_Facturar.TabIndex = 0;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturar.UseVisualStyleBackColor = true;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(0, 40);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(229, 40);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Administrar pedidos";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.UseVisualStyleBackColor = true;
            // 
            // btn_Mercancia
            // 
            this.btn_Mercancia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Mercancia.FlatAppearance.BorderSize = 0;
            this.btn_Mercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Mercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Mercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mercancia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mercancia.Location = new System.Drawing.Point(0, 80);
            this.btn_Mercancia.Name = "btn_Mercancia";
            this.btn_Mercancia.Size = new System.Drawing.Size(229, 40);
            this.btn_Mercancia.TabIndex = 2;
            this.btn_Mercancia.Text = "Ingresar mercancia";
            this.btn_Mercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mercancia.UseVisualStyleBackColor = true;
            this.btn_Mercancia.Click += new System.EventHandler(this.btn_Mercancia_Click);
            // 
            // btn_Despachar
            // 
            this.btn_Despachar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Despachar.FlatAppearance.BorderSize = 0;
            this.btn_Despachar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Despachar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Despachar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Despachar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Despachar.Location = new System.Drawing.Point(0, 120);
            this.btn_Despachar.Name = "btn_Despachar";
            this.btn_Despachar.Size = new System.Drawing.Size(229, 40);
            this.btn_Despachar.TabIndex = 3;
            this.btn_Despachar.Text = "Despachar mercancia";
            this.btn_Despachar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Despachar.UseVisualStyleBackColor = true;
            // 
            // panel_SudMenuFact
            // 
            this.panel_SudMenuFact.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_SudMenuFact.Controls.Add(this.btn_costos);
            this.panel_SudMenuFact.Controls.Add(this.btn_Despachar);
            this.panel_SudMenuFact.Controls.Add(this.btn_Mercancia);
            this.panel_SudMenuFact.Controls.Add(this.btn_Admin);
            this.panel_SudMenuFact.Controls.Add(this.btn_Facturar);
            this.panel_SudMenuFact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SudMenuFact.Location = new System.Drawing.Point(0, 376);
            this.panel_SudMenuFact.Name = "panel_SudMenuFact";
            this.panel_SudMenuFact.Size = new System.Drawing.Size(229, 211);
            this.panel_SudMenuFact.TabIndex = 4;
            // 
            // btn_costos
            // 
            this.btn_costos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_costos.FlatAppearance.BorderSize = 0;
            this.btn_costos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_costos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_costos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_costos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_costos.Location = new System.Drawing.Point(0, 160);
            this.btn_costos.Name = "btn_costos";
            this.btn_costos.Size = new System.Drawing.Size(229, 40);
            this.btn_costos.TabIndex = 4;
            this.btn_costos.Text = "Costos por articulos";
            this.btn_costos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_costos.UseVisualStyleBackColor = true;
            this.btn_costos.Click += new System.EventHandler(this.btn_costos_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(0, 649);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 40);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panelMenuL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenuL.ResumeLayout(false);
            this.panelSudMenuInicio.ResumeLayout(false);
            this.panel_SudMenuFact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuL;
        private System.Windows.Forms.Panel panelSudMenuInicio;
        private System.Windows.Forms.Button btn_Maquinaria;
        private System.Windows.Forms.Button btn_SM;
        private System.Windows.Forms.Button btn_FA;
        private System.Windows.Forms.Button btn_INICIO;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Fact;
        private System.Windows.Forms.Panel panel_SudMenuFact;
        private System.Windows.Forms.Button btn_costos;
        private System.Windows.Forms.Button btn_Despachar;
        private System.Windows.Forms.Button btn_Mercancia;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

