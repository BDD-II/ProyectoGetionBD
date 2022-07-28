
namespace GestionBD
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbGestion = new System.Windows.Forms.TabControl();
            this.tbpEspacioBD = new System.Windows.Forms.TabPage();
            this.btnConsultarEspacio = new System.Windows.Forms.Button();
            this.chtAlmacenamiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEspacioBD = new System.Windows.Forms.DataGridView();
            this.EspacioLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspacioOcupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpRestricionesBD = new System.Windows.Forms.TabPage();
            this.btnConsultarRestric = new System.Windows.Forms.Button();
            this.txtConsultaRest = new System.Windows.Forms.TextBox();
            this.dgvRestricciones = new System.Windows.Forms.DataGridView();
            this.tbpParticionTablas = new System.Windows.Forms.TabPage();
            this.btnConsultarParticionado = new System.Windows.Forms.Button();
            this.chtParticionado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpParticiones = new System.Windows.Forms.TabPage();
            this.btnConsultaParticiones = new System.Windows.Forms.Button();
            this.txtConsultaParticiones = new System.Windows.Forms.TextBox();
            this.chtParticiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvParticiones = new System.Windows.Forms.DataGridView();
            this.tbGestion.SuspendLayout();
            this.tbpEspacioBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacioBD)).BeginInit();
            this.tbpRestricionesBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestricciones)).BeginInit();
            this.tbpParticionTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtParticionado)).BeginInit();
            this.tbpParticiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtParticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticiones)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGestion
            // 
            this.tbGestion.Controls.Add(this.tbpEspacioBD);
            this.tbGestion.Controls.Add(this.tbpRestricionesBD);
            this.tbGestion.Controls.Add(this.tbpParticionTablas);
            this.tbGestion.Controls.Add(this.tbpParticiones);
            this.tbGestion.Location = new System.Drawing.Point(34, 39);
            this.tbGestion.Name = "tbGestion";
            this.tbGestion.SelectedIndex = 0;
            this.tbGestion.Size = new System.Drawing.Size(730, 377);
            this.tbGestion.TabIndex = 0;
            // 
            // tbpEspacioBD
            // 
            this.tbpEspacioBD.Controls.Add(this.btnConsultarEspacio);
            this.tbpEspacioBD.Controls.Add(this.chtAlmacenamiento);
            this.tbpEspacioBD.Controls.Add(this.dgvEspacioBD);
            this.tbpEspacioBD.Location = new System.Drawing.Point(4, 22);
            this.tbpEspacioBD.Name = "tbpEspacioBD";
            this.tbpEspacioBD.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEspacioBD.Size = new System.Drawing.Size(722, 351);
            this.tbpEspacioBD.TabIndex = 0;
            this.tbpEspacioBD.Text = "Espacio de la base de Datos";
            this.tbpEspacioBD.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEspacio
            // 
            this.btnConsultarEspacio.Location = new System.Drawing.Point(29, 29);
            this.btnConsultarEspacio.Name = "btnConsultarEspacio";
            this.btnConsultarEspacio.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEspacio.TabIndex = 2;
            this.btnConsultarEspacio.Text = "Consultar";
            this.btnConsultarEspacio.UseVisualStyleBackColor = true;
            this.btnConsultarEspacio.Click += new System.EventHandler(this.btnConsultarEspacio_Click);
            // 
            // chtAlmacenamiento
            // 
            chartArea4.Name = "ChartArea1";
            this.chtAlmacenamiento.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtAlmacenamiento.Legends.Add(legend4);
            this.chtAlmacenamiento.Location = new System.Drawing.Point(301, 45);
            this.chtAlmacenamiento.Name = "chtAlmacenamiento";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtAlmacenamiento.Series.Add(series4);
            this.chtAlmacenamiento.Size = new System.Drawing.Size(382, 300);
            this.chtAlmacenamiento.TabIndex = 1;
            this.chtAlmacenamiento.Text = "chart1";
            // 
            // dgvEspacioBD
            // 
            this.dgvEspacioBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspacioBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EspacioLibre,
            this.EspacioOcupado});
            this.dgvEspacioBD.Location = new System.Drawing.Point(15, 66);
            this.dgvEspacioBD.Name = "dgvEspacioBD";
            this.dgvEspacioBD.Size = new System.Drawing.Size(241, 279);
            this.dgvEspacioBD.TabIndex = 0;
            // 
            // EspacioLibre
            // 
            this.EspacioLibre.HeaderText = "Espacio Libre";
            this.EspacioLibre.Name = "EspacioLibre";
            // 
            // EspacioOcupado
            // 
            this.EspacioOcupado.HeaderText = "Espacio Ocupado";
            this.EspacioOcupado.Name = "EspacioOcupado";
            // 
            // tbpRestricionesBD
            // 
            this.tbpRestricionesBD.Controls.Add(this.btnConsultarRestric);
            this.tbpRestricionesBD.Controls.Add(this.txtConsultaRest);
            this.tbpRestricionesBD.Controls.Add(this.dgvRestricciones);
            this.tbpRestricionesBD.Location = new System.Drawing.Point(4, 22);
            this.tbpRestricionesBD.Name = "tbpRestricionesBD";
            this.tbpRestricionesBD.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRestricionesBD.Size = new System.Drawing.Size(722, 351);
            this.tbpRestricionesBD.TabIndex = 1;
            this.tbpRestricionesBD.Text = "Restricciones de la tablas";
            this.tbpRestricionesBD.UseVisualStyleBackColor = true;
            // 
            // btnConsultarRestric
            // 
            this.btnConsultarRestric.Location = new System.Drawing.Point(215, 25);
            this.btnConsultarRestric.Name = "btnConsultarRestric";
            this.btnConsultarRestric.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarRestric.TabIndex = 2;
            this.btnConsultarRestric.Text = "Consultar";
            this.btnConsultarRestric.UseVisualStyleBackColor = true;
            this.btnConsultarRestric.Click += new System.EventHandler(this.btnConsultarRestric_Click);
            // 
            // txtConsultaRest
            // 
            this.txtConsultaRest.Location = new System.Drawing.Point(56, 27);
            this.txtConsultaRest.Name = "txtConsultaRest";
            this.txtConsultaRest.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaRest.TabIndex = 1;
            // 
            // dgvRestricciones
            // 
            this.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestricciones.Location = new System.Drawing.Point(44, 67);
            this.dgvRestricciones.Name = "dgvRestricciones";
            this.dgvRestricciones.Size = new System.Drawing.Size(444, 264);
            this.dgvRestricciones.TabIndex = 0;
            // 
            // tbpParticionTablas
            // 
            this.tbpParticionTablas.Controls.Add(this.btnConsultarParticionado);
            this.tbpParticionTablas.Controls.Add(this.chtParticionado);
            this.tbpParticionTablas.Location = new System.Drawing.Point(4, 22);
            this.tbpParticionTablas.Name = "tbpParticionTablas";
            this.tbpParticionTablas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpParticionTablas.Size = new System.Drawing.Size(722, 351);
            this.tbpParticionTablas.TabIndex = 2;
            this.tbpParticionTablas.Text = "Tablas particionadas y no particionadas ";
            this.tbpParticionTablas.UseVisualStyleBackColor = true;
            // 
            // btnConsultarParticionado
            // 
            this.btnConsultarParticionado.Location = new System.Drawing.Point(44, 34);
            this.btnConsultarParticionado.Name = "btnConsultarParticionado";
            this.btnConsultarParticionado.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarParticionado.TabIndex = 1;
            this.btnConsultarParticionado.Text = "Consultar";
            this.btnConsultarParticionado.UseVisualStyleBackColor = true;
            this.btnConsultarParticionado.Click += new System.EventHandler(this.btnConsultarParticionado_Click);
            // 
            // chtParticionado
            // 
            chartArea5.Name = "ChartArea1";
            this.chtParticionado.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtParticionado.Legends.Add(legend5);
            this.chtParticionado.Location = new System.Drawing.Point(101, 34);
            this.chtParticionado.Name = "chtParticionado";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chtParticionado.Series.Add(series5);
            this.chtParticionado.Size = new System.Drawing.Size(495, 300);
            this.chtParticionado.TabIndex = 0;
            this.chtParticionado.Text = "chart1";
            // 
            // tbpParticiones
            // 
            this.tbpParticiones.Controls.Add(this.btnConsultaParticiones);
            this.tbpParticiones.Controls.Add(this.txtConsultaParticiones);
            this.tbpParticiones.Controls.Add(this.chtParticiones);
            this.tbpParticiones.Controls.Add(this.dgvParticiones);
            this.tbpParticiones.Location = new System.Drawing.Point(4, 22);
            this.tbpParticiones.Name = "tbpParticiones";
            this.tbpParticiones.Padding = new System.Windows.Forms.Padding(3);
            this.tbpParticiones.Size = new System.Drawing.Size(722, 351);
            this.tbpParticiones.TabIndex = 3;
            this.tbpParticiones.Text = "Particiones y Subparticiones";
            this.tbpParticiones.UseVisualStyleBackColor = true;
            // 
            // btnConsultaParticiones
            // 
            this.btnConsultaParticiones.Location = new System.Drawing.Point(222, 22);
            this.btnConsultaParticiones.Name = "btnConsultaParticiones";
            this.btnConsultaParticiones.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaParticiones.TabIndex = 3;
            this.btnConsultaParticiones.Text = "Consultar";
            this.btnConsultaParticiones.UseVisualStyleBackColor = true;
            this.btnConsultaParticiones.Click += new System.EventHandler(this.btnConsultaParticiones_Click);
            // 
            // txtConsultaParticiones
            // 
            this.txtConsultaParticiones.Location = new System.Drawing.Point(87, 24);
            this.txtConsultaParticiones.Name = "txtConsultaParticiones";
            this.txtConsultaParticiones.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaParticiones.TabIndex = 2;
            // 
            // chtParticiones
            // 
            chartArea6.Name = "ChartArea1";
            this.chtParticiones.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtParticiones.Legends.Add(legend6);
            this.chtParticiones.Location = new System.Drawing.Point(372, 65);
            this.chtParticiones.Name = "chtParticiones";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chtParticiones.Series.Add(series6);
            this.chtParticiones.Size = new System.Drawing.Size(344, 280);
            this.chtParticiones.TabIndex = 1;
            this.chtParticiones.Text = "chart1";
            // 
            // dgvParticiones
            // 
            this.dgvParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticiones.Location = new System.Drawing.Point(57, 65);
            this.dgvParticiones.Name = "dgvParticiones";
            this.dgvParticiones.Size = new System.Drawing.Size(240, 280);
            this.dgvParticiones.TabIndex = 0;
            this.dgvParticiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticiones_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGestion);
            this.Name = "Form1";
            this.Text = "Gestion de la Base de Datos";
            this.tbGestion.ResumeLayout(false);
            this.tbpEspacioBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacioBD)).EndInit();
            this.tbpRestricionesBD.ResumeLayout(false);
            this.tbpRestricionesBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestricciones)).EndInit();
            this.tbpParticionTablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtParticionado)).EndInit();
            this.tbpParticiones.ResumeLayout(false);
            this.tbpParticiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtParticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbGestion;
        private System.Windows.Forms.TabPage tbpEspacioBD;
        private System.Windows.Forms.TabPage tbpRestricionesBD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAlmacenamiento;
        private System.Windows.Forms.DataGridView dgvEspacioBD;
        private System.Windows.Forms.Button btnConsultarRestric;
        private System.Windows.Forms.TextBox txtConsultaRest;
        private System.Windows.Forms.DataGridView dgvRestricciones;
        private System.Windows.Forms.TabPage tbpParticionTablas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtParticionado;
        private System.Windows.Forms.TabPage tbpParticiones;
        private System.Windows.Forms.Button btnConsultaParticiones;
        private System.Windows.Forms.TextBox txtConsultaParticiones;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtParticiones;
        private System.Windows.Forms.DataGridView dgvParticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspacioLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspacioOcupado;
        private System.Windows.Forms.Button btnConsultarEspacio;
        private System.Windows.Forms.Button btnConsultarParticionado;
    }
}

