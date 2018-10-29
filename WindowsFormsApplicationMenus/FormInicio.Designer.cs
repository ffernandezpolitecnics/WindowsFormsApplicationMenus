namespace WindowsFormsApplicationMenus
{
    partial class FormInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarSoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarAnálisisDeCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.administradorDeLaConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosDeInterrupciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.iniciarDepuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarConexionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCompilar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilarToolStripMenuItem,
            this.depurarToolStripMenuItem,
            this.equipoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilarSoluciónToolStripMenuItem,
            this.ejecutarAnálisisDeCódigoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.administradorDeLaConfiguraciónToolStripMenuItem});
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // compilarSoluciónToolStripMenuItem
            // 
            this.compilarSoluciónToolStripMenuItem.Image = global::WindowsFormsApplicationMenus.Properties.Resources.download;
            this.compilarSoluciónToolStripMenuItem.Name = "compilarSoluciónToolStripMenuItem";
            this.compilarSoluciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.compilarSoluciónToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.compilarSoluciónToolStripMenuItem.Text = "Compilar solución";
            this.compilarSoluciónToolStripMenuItem.Click += new System.EventHandler(this.compilarSoluciónToolStripMenuItem_Click);
            // 
            // ejecutarAnálisisDeCódigoToolStripMenuItem
            // 
            this.ejecutarAnálisisDeCódigoToolStripMenuItem.Name = "ejecutarAnálisisDeCódigoToolStripMenuItem";
            this.ejecutarAnálisisDeCódigoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.ejecutarAnálisisDeCódigoToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.ejecutarAnálisisDeCódigoToolStripMenuItem.Text = "Ejecutar análisis de código";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 6);
            // 
            // administradorDeLaConfiguraciónToolStripMenuItem
            // 
            this.administradorDeLaConfiguraciónToolStripMenuItem.Name = "administradorDeLaConfiguraciónToolStripMenuItem";
            this.administradorDeLaConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.administradorDeLaConfiguraciónToolStripMenuItem.Text = "Administrador de la configuración";
            // 
            // depurarToolStripMenuItem
            // 
            this.depurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.iniciarDepuraciónToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.depurarToolStripMenuItem.Name = "depurarToolStripMenuItem";
            this.depurarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.depurarToolStripMenuItem.Text = "Depurar";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntosDeInterrupciónToolStripMenuItem,
            this.resultadosToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // puntosDeInterrupciónToolStripMenuItem
            // 
            this.puntosDeInterrupciónToolStripMenuItem.Name = "puntosDeInterrupciónToolStripMenuItem";
            this.puntosDeInterrupciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.puntosDeInterrupciónToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.puntosDeInterrupciónToolStripMenuItem.Text = "Puntos de interrupción";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // iniciarDepuraciónToolStripMenuItem
            // 
            this.iniciarDepuraciónToolStripMenuItem.Image = global::WindowsFormsApplicationMenus.Properties.Resources.play_button;
            this.iniciarDepuraciónToolStripMenuItem.Name = "iniciarDepuraciónToolStripMenuItem";
            this.iniciarDepuraciónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.iniciarDepuraciónToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.iniciarDepuraciónToolStripMenuItem.Text = "Iniciar depuración";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Image = global::WindowsFormsApplicationMenus.Properties.Resources.settings;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.opcionesToolStripMenuItem.Text = "Opciones ...";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarConexionesToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // administrarConexionesToolStripMenuItem
            // 
            this.administrarConexionesToolStripMenuItem.Image = global::WindowsFormsApplicationMenus.Properties.Resources.server;
            this.administrarConexionesToolStripMenuItem.Name = "administrarConexionesToolStripMenuItem";
            this.administrarConexionesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.administrarConexionesToolStripMenuItem.Text = "Administrar conexiones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCompilar,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(858, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCompilar
            // 
            this.toolStripButtonCompilar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCompilar.Image = global::WindowsFormsApplicationMenus.Properties.Resources.download;
            this.toolStripButtonCompilar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCompilar.Name = "toolStripButtonCompilar";
            this.toolStripButtonCompilar.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonCompilar.Text = "Compilar";
            this.toolStripButtonCompilar.Click += new System.EventHandler(this.toolStripButtonCompilar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApplicationMenus.Properties.Resources.play_button;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApplicationMenus.Properties.Resources.settings;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WindowsFormsApplicationMenus.Properties.Resources.server;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 314);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarSoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarAnálisisDeCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administradorDeLaConfiguraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntosDeInterrupciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iniciarDepuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarConexionesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCompilar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

