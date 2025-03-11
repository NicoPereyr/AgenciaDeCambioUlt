namespace AgenciaDeCambioPOO.Windows
{
    partial class frmAgencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbCompra = new ToolStripButton();
            tsbVenta = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbNuevaDivisa = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            splitContainer1 = new SplitContainer();
            dgvDivisas = new DataGridView();
            colDivisa = new DataGridViewTextBoxColumn();
            colAbreviatura = new DataGridViewTextBoxColumn();
            colCantidadDivisa = new DataGridViewTextBoxColumn();
            colPrecioCompra = new DataGridViewTextBoxColumn();
            colPrecioVenta = new DataGridViewTextBoxColumn();
            dgvOperaciones = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colDivisaOp = new DataGridViewTextBoxColumn();
            colOperacion = new DataGridViewTextBoxColumn();
            Cotización = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDivisas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOperaciones).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbCompra, tsbVenta, toolStripSeparator1, tsbNuevaDivisa, tsbActualizar, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbCompra
            // 
            tsbCompra.Image = Properties.Resources.add_shopping_cart_48px;
            tsbCompra.ImageScaling = ToolStripItemImageScaling.None;
            tsbCompra.ImageTransparentColor = Color.Magenta;
            tsbCompra.Name = "tsbCompra";
            tsbCompra.Size = new Size(54, 67);
            tsbCompra.Text = "Compra";
            tsbCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCompra.Click += tsbCompra_Click;
            // 
            // tsbVenta
            // 
            tsbVenta.Image = Properties.Resources.checkout_48px;
            tsbVenta.ImageScaling = ToolStripItemImageScaling.None;
            tsbVenta.ImageTransparentColor = Color.Magenta;
            tsbVenta.Name = "tsbVenta";
            tsbVenta.Size = new Size(52, 67);
            tsbVenta.Text = "Venta";
            tsbVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbVenta.Click += tsbVenta_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsbNuevaDivisa
            // 
            tsbNuevaDivisa.Image = Properties.Resources.stack_of_money_48px;
            tsbNuevaDivisa.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevaDivisa.ImageTransparentColor = Color.Magenta;
            tsbNuevaDivisa.Name = "tsbNuevaDivisa";
            tsbNuevaDivisa.Size = new Size(79, 67);
            tsbNuevaDivisa.Text = "Nueva Divisa";
            tsbNuevaDivisa.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.refresh_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 70);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDivisas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOperaciones);
            splitContainer1.Size = new Size(982, 485);
            splitContainer1.SplitterDistance = 390;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDivisas
            // 
            dgvDivisas.AllowUserToAddRows = false;
            dgvDivisas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDivisas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDivisas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDivisas.Columns.AddRange(new DataGridViewColumn[] { colDivisa, colAbreviatura, colCantidadDivisa, colPrecioCompra, colPrecioVenta });
            dgvDivisas.Dock = DockStyle.Fill;
            dgvDivisas.Location = new Point(0, 0);
            dgvDivisas.MultiSelect = false;
            dgvDivisas.Name = "dgvDivisas";
            dgvDivisas.ReadOnly = true;
            dgvDivisas.RowHeadersVisible = false;
            dgvDivisas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDivisas.Size = new Size(390, 485);
            dgvDivisas.TabIndex = 0;
            // 
            // colDivisa
            // 
            colDivisa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDivisa.HeaderText = "Divisa";
            colDivisa.Name = "colDivisa";
            colDivisa.ReadOnly = true;
            // 
            // colAbreviatura
            // 
            colAbreviatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colAbreviatura.HeaderText = "Abr.";
            colAbreviatura.Name = "colAbreviatura";
            colAbreviatura.ReadOnly = true;
            colAbreviatura.Width = 54;
            // 
            // colCantidadDivisa
            // 
            colCantidadDivisa.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCantidadDivisa.DefaultCellStyle = dataGridViewCellStyle2;
            colCantidadDivisa.HeaderText = "Cantidad";
            colCantidadDivisa.Name = "colCantidadDivisa";
            colCantidadDivisa.ReadOnly = true;
            colCantidadDivisa.Width = 80;
            // 
            // colPrecioCompra
            // 
            colPrecioCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle3;
            colPrecioCompra.HeaderText = "Compra";
            colPrecioCompra.Name = "colPrecioCompra";
            colPrecioCompra.ReadOnly = true;
            colPrecioCompra.Width = 75;
            // 
            // colPrecioVenta
            // 
            colPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPrecioVenta.DefaultCellStyle = dataGridViewCellStyle4;
            colPrecioVenta.HeaderText = "Venta";
            colPrecioVenta.Name = "colPrecioVenta";
            colPrecioVenta.ReadOnly = true;
            colPrecioVenta.Width = 61;
            // 
            // dgvOperaciones
            // 
            dgvOperaciones.AllowUserToAddRows = false;
            dgvOperaciones.AllowUserToDeleteRows = false;
            dgvOperaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperaciones.Columns.AddRange(new DataGridViewColumn[] { colFecha, colDivisaOp, colOperacion, Cotización, colCantidad, colTotal });
            dgvOperaciones.Dock = DockStyle.Fill;
            dgvOperaciones.Location = new Point(0, 0);
            dgvOperaciones.MultiSelect = false;
            dgvOperaciones.Name = "dgvOperaciones";
            dgvOperaciones.ReadOnly = true;
            dgvOperaciones.RowHeadersVisible = false;
            dgvOperaciones.Size = new Size(588, 485);
            dgvOperaciones.TabIndex = 0;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colDivisaOp
            // 
            colDivisaOp.HeaderText = "Divisa";
            colDivisaOp.Name = "colDivisaOp";
            colDivisaOp.ReadOnly = true;
            // 
            // colOperacion
            // 
            colOperacion.HeaderText = "Operación";
            colOperacion.Name = "colOperacion";
            colOperacion.ReadOnly = true;
            // 
            // Cotización
            // 
            Cotización.HeaderText = "Cotización";
            Cotización.Name = "Cotización";
            Cotización.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // frmAgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 555);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmAgencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agencia de Cambios";
            Load += frmAgencia_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDivisas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOperaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private DataGridView dgvDivisas;
        private ToolStripButton tsbCompra;
        private DataGridView dgvOperaciones;
        private ToolStripButton tsbVenta;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbNuevaDivisa;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colDivisaOp;
        private DataGridViewTextBoxColumn colOperacion;
        private DataGridViewTextBoxColumn Cotización;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colDivisa;
        private DataGridViewTextBoxColumn colAbreviatura;
        private DataGridViewTextBoxColumn colCantidadDivisa;
        private DataGridViewTextBoxColumn colPrecioCompra;
        private DataGridViewTextBoxColumn colPrecioVenta;
    }
}
