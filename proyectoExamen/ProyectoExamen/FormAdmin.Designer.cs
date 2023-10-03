namespace ProyectoExamen
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            lstVProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            lblCantidad = new Label();
            gbNewProduct = new GroupBox();
            numCantidadAgregar = new NumericUpDown();
            label3 = new Label();
            txtCantidadActual = new TextBox();
            txtProducto = new TextBox();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            gbNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lstVProductos
            // 
            lstVProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstVProductos.ForeColor = SystemColors.WindowText;
            lstVProductos.FullRowSelect = true;
            lstVProductos.GridLines = true;
            lstVProductos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstVProductos.Location = new Point(1144, 9);
            lstVProductos.Name = "lstVProductos";
            lstVProductos.Size = new Size(385, 343);
            lstVProductos.TabIndex = 0;
            lstVProductos.UseCompatibleStateImageBehavior = false;
            lstVProductos.View = View.Details;
            lstVProductos.Click += lstVProductos_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(6, 135);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(109, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad a Agregar";
            // 
            // gbNewProduct
            // 
            gbNewProduct.BackColor = SystemColors.Info;
            gbNewProduct.Controls.Add(label2);
            gbNewProduct.Controls.Add(numCantidadAgregar);
            gbNewProduct.Controls.Add(label3);
            gbNewProduct.Controls.Add(txtCantidadActual);
            gbNewProduct.Controls.Add(txtProducto);
            gbNewProduct.Controls.Add(label1);
            gbNewProduct.Controls.Add(lblCantidad);
            gbNewProduct.Location = new Point(18, 22);
            gbNewProduct.Name = "gbNewProduct";
            gbNewProduct.Size = new Size(440, 167);
            gbNewProduct.TabIndex = 9;
            gbNewProduct.TabStop = false;
            gbNewProduct.Text = "Modificacion productos";
            // 
            // numCantidadAgregar
            // 
            numCantidadAgregar.Location = new Point(121, 133);
            numCantidadAgregar.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numCantidadAgregar.Name = "numCantidadAgregar";
            numCantidadAgregar.Size = new Size(120, 23);
            numCantidadAgregar.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 30);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 10;
            label3.Text = "Cantidad Actual";
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Location = new Point(291, 27);
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.ReadOnly = true;
            txtCantidadActual.Size = new Size(121, 23);
            txtCantidadActual.TabIndex = 11;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(65, 27);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(121, 23);
            txtProducto.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.Location = new Point(75, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 52);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Info;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 52);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(75, 283);
            button1.Name = "button1";
            button1.Size = new Size(102, 52);
            button1.TabIndex = 13;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 135);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 13;
            label2.Text = "MAX 9999";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Info;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(208, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 52);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(265, 210);
            button2.Name = "button2";
            button2.Size = new Size(102, 52);
            button2.TabIndex = 14;
            button2.Text = "Agregar Producto";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1541, 694);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregar);
            Controls.Add(gbNewProduct);
            Controls.Add(lstVProductos);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            gbNewProduct.ResumeLayout(false);
            gbNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lstVProductos;
        private Label label1;
        private Label lblCantidad;
        private GroupBox gbNewProduct;
        private Button btnAgregar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtCantidadActual;
        private NumericUpDown numCantidadAgregar;
        private Label label2;
        private PictureBox pictureBox3;
        private Button button2;
    }
}