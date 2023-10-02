namespace ProyectoExamen
{
    partial class FormOperario
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            lstVStock = new ListView();
            lstVMaterial = new ColumnHeader();
            lsvtVCantidad = new ColumnHeader();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Location = new Point(17, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lstVStock
            // 
            lstVStock.BackColor = SystemColors.ActiveCaption;
            lstVStock.Columns.AddRange(new ColumnHeader[] { lstVMaterial, lsvtVCantidad });
            lstVStock.GridLines = true;
            lstVStock.Location = new Point(822, 26);
            lstVStock.Name = "lstVStock";
            lstVStock.Size = new Size(366, 216);
            lstVStock.TabIndex = 1;
            lstVStock.UseCompatibleStateImageBehavior = false;
            lstVStock.View = View.Details;
            // 
            // lstVMaterial
            // 
            lstVMaterial.Text = "Material";
            lstVMaterial.Width = 150;
            // 
            // lsvtVCantidad
            // 
            lsvtVCantidad.Text = "Cantidad";
            lsvtVCantidad.Width = 80;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(1059, 489);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(129, 63);
            btnPrueba.TabIndex = 2;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // FormOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 564);
            Controls.Add(btnPrueba);
            Controls.Add(lstVStock);
            Controls.Add(groupBox1);
            Name = "FormOperario";
            Text = "FormOperario";
            FormClosing += FormOperario_FormClosing;
            Load += FormOperario_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private ListView lstVStock;
        private ColumnHeader lstVMaterial;
        private ColumnHeader lsvtVCantidad;
        private Button btnPrueba;
    }
}