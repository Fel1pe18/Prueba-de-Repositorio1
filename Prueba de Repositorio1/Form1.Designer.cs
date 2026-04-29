namespace Prueba_de_Repositorio1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCRIPCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARRERASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGMECANICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(518, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 192);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.dESCRIPCIONToolStripMenuItem,
            this.cARRERASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // dESCRIPCIONToolStripMenuItem
            // 
            this.dESCRIPCIONToolStripMenuItem.Name = "dESCRIPCIONToolStripMenuItem";
            this.dESCRIPCIONToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dESCRIPCIONToolStripMenuItem.Text = "DESCRIPCION";
            // 
            // cARRERASToolStripMenuItem
            // 
            this.cARRERASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGMECANICAToolStripMenuItem,
            this.iNGToolStripMenuItem});
            this.cARRERASToolStripMenuItem.Name = "cARRERASToolStripMenuItem";
            this.cARRERASToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cARRERASToolStripMenuItem.Text = "CARRERAS";
            // 
            // iNGMECANICAToolStripMenuItem
            // 
            this.iNGMECANICAToolStripMenuItem.Name = "iNGMECANICAToolStripMenuItem";
            this.iNGMECANICAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNGMECANICAToolStripMenuItem.Text = "ING MECANICA";
            // 
            // iNGToolStripMenuItem
            // 
            this.iNGToolStripMenuItem.Name = "iNGToolStripMenuItem";
            this.iNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNGToolStripMenuItem.Text = "ING  SOFTWARE";
            this.iNGToolStripMenuItem.Click += new System.EventHandler(this.iNGToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Practiva 1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCRIPCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARRERASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNGMECANICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNGToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

