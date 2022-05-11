namespace App
{
    partial class FrmInicio
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSeleccion = new System.Windows.Forms.TableLayoutPanel();
            this.tlpObjeto = new System.Windows.Forms.TableLayoutPanel();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.cboObjeto = new System.Windows.Forms.ComboBox();
            this.tlpTipo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.numDato1 = new System.Windows.Forms.NumericUpDown();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.numDato2 = new System.Windows.Forms.NumericUpDown();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.numDato3 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tlpSeleccion.SuspendLayout();
            this.tlpObjeto.SuspendLayout();
            this.tlpTipo.SuspendLayout();
            this.tlpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato3)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpSeleccion, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tlpDatos, 0, 1);
            this.tlpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(360, 167);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpSeleccion
            // 
            this.tlpSeleccion.ColumnCount = 2;
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeleccion.Controls.Add(this.tlpObjeto, 0, 0);
            this.tlpSeleccion.Controls.Add(this.tlpTipo, 0, 0);
            this.tlpSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeleccion.Location = new System.Drawing.Point(3, 3);
            this.tlpSeleccion.Name = "tlpSeleccion";
            this.tlpSeleccion.RowCount = 1;
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeleccion.Size = new System.Drawing.Size(354, 34);
            this.tlpSeleccion.TabIndex = 0;
            // 
            // tlpObjeto
            // 
            this.tlpObjeto.ColumnCount = 2;
            this.tlpObjeto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpObjeto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjeto.Controls.Add(this.lblObjeto, 0, 0);
            this.tlpObjeto.Controls.Add(this.cboObjeto, 1, 0);
            this.tlpObjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpObjeto.Location = new System.Drawing.Point(180, 3);
            this.tlpObjeto.Name = "tlpObjeto";
            this.tlpObjeto.RowCount = 1;
            this.tlpObjeto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpObjeto.Size = new System.Drawing.Size(171, 28);
            this.tlpObjeto.TabIndex = 1;
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObjeto.Location = new System.Drawing.Point(3, 0);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(44, 28);
            this.lblObjeto.TabIndex = 0;
            this.lblObjeto.Text = "Objeto";
            this.lblObjeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboObjeto
            // 
            this.cboObjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjeto.Enabled = false;
            this.cboObjeto.FormattingEnabled = true;
            this.cboObjeto.Location = new System.Drawing.Point(53, 3);
            this.cboObjeto.Name = "cboObjeto";
            this.cboObjeto.Size = new System.Drawing.Size(115, 23);
            this.cboObjeto.TabIndex = 2;
            this.cboObjeto.SelectedIndexChanged += new System.EventHandler(this.cboObjeto_SelectedIndexChanged);
            // 
            // tlpTipo
            // 
            this.tlpTipo.ColumnCount = 2;
            this.tlpTipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTipo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTipo.Controls.Add(this.lblTipo, 0, 0);
            this.tlpTipo.Controls.Add(this.cboTipo, 1, 0);
            this.tlpTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTipo.Location = new System.Drawing.Point(3, 3);
            this.tlpTipo.Name = "tlpTipo";
            this.tlpTipo.RowCount = 1;
            this.tlpTipo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTipo.Size = new System.Drawing.Size(171, 28);
            this.tlpTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Location = new System.Drawing.Point(3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 28);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTipo
            // 
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Figura",
            "Sólido"});
            this.cboTipo.Location = new System.Drawing.Point(53, 3);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(115, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 2;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatos.Controls.Add(this.lblDato1, 0, 0);
            this.tlpDatos.Controls.Add(this.numDato1, 1, 0);
            this.tlpDatos.Controls.Add(this.lblDato2, 0, 1);
            this.tlpDatos.Controls.Add(this.numDato2, 1, 1);
            this.tlpDatos.Controls.Add(this.lblDato3, 0, 2);
            this.tlpDatos.Controls.Add(this.numDato3, 1, 2);
            this.tlpDatos.Controls.Add(this.btnCalcular, 1, 3);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(3, 43);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 4;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatos.Size = new System.Drawing.Size(354, 121);
            this.tlpDatos.TabIndex = 1;
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDato1.Location = new System.Drawing.Point(3, 0);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(94, 30);
            this.lblDato1.TabIndex = 0;
            this.lblDato1.Text = "Dato 1";
            this.lblDato1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDato1.Visible = false;
            // 
            // numDato1
            // 
            this.numDato1.DecimalPlaces = 2;
            this.numDato1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDato1.Location = new System.Drawing.Point(103, 3);
            this.numDato1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDato1.Name = "numDato1";
            this.numDato1.Size = new System.Drawing.Size(248, 23);
            this.numDato1.TabIndex = 1;
            this.numDato1.ThousandsSeparator = true;
            this.numDato1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDato1.Visible = false;
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDato2.Location = new System.Drawing.Point(3, 30);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(94, 30);
            this.lblDato2.TabIndex = 2;
            this.lblDato2.Text = "Dato 2";
            this.lblDato2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDato2.Visible = false;
            // 
            // numDato2
            // 
            this.numDato2.DecimalPlaces = 2;
            this.numDato2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDato2.Location = new System.Drawing.Point(103, 33);
            this.numDato2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDato2.Name = "numDato2";
            this.numDato2.Size = new System.Drawing.Size(248, 23);
            this.numDato2.TabIndex = 2;
            this.numDato2.ThousandsSeparator = true;
            this.numDato2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDato2.Visible = false;
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDato3.Location = new System.Drawing.Point(3, 60);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(94, 30);
            this.lblDato3.TabIndex = 4;
            this.lblDato3.Text = "Dato 3";
            this.lblDato3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDato3.Visible = false;
            // 
            // numDato3
            // 
            this.numDato3.DecimalPlaces = 2;
            this.numDato3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDato3.Location = new System.Drawing.Point(103, 63);
            this.numDato3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDato3.Name = "numDato3";
            this.numDato3.Size = new System.Drawing.Size(248, 23);
            this.numDato3.TabIndex = 3;
            this.numDato3.ThousandsSeparator = true;
            this.numDato3.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDato3.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcular.Location = new System.Drawing.Point(103, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(248, 25);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras & Sólidos";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpSeleccion.ResumeLayout(false);
            this.tlpObjeto.ResumeLayout(false);
            this.tlpObjeto.PerformLayout();
            this.tlpTipo.ResumeLayout(false);
            this.tlpTipo.PerformLayout();
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpSeleccion;
        private TableLayoutPanel tlpTipo;
        private Label lblTipo;
        private ComboBox cboTipo;
        private TableLayoutPanel tlpObjeto;
        private Label lblObjeto;
        private ComboBox cboObjeto;
        private TableLayoutPanel tlpDatos;
        private Label lblDato1;
        private NumericUpDown numDato1;
        private Label lblDato2;
        private NumericUpDown numDato2;
        private Label lblDato3;
        private NumericUpDown numDato3;
        private Button btnCalcular;
    }
}