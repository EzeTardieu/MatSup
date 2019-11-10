namespace MatSup
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
            this.Calcular = new System.Windows.Forms.Button();
            this.tablaPuntos = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.puntoY = new System.Windows.Forms.TextBox();
            this.puntoX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metodos = new System.Windows.Forms.ComboBox();
            this.mostrarPasosBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tablaPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.Pink;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(427, 215);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(145, 35);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Agregar";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // tablaPuntos
            // 
            this.tablaPuntos.AutoSize = true;
            this.tablaPuntos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablaPuntos.ColumnCount = 2;
            this.tablaPuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.Controls.Add(this.label2, 0, 0);
            this.tablaPuntos.Controls.Add(this.label5, 1, 0);
            this.tablaPuntos.Location = new System.Drawing.Point(103, 139);
            this.tablaPuntos.Name = "tablaPuntos";
            this.tablaPuntos.RowCount = 2;
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.Size = new System.Drawing.Size(212, 50);
            this.tablaPuntos.TabIndex = 1;
            this.tablaPuntos.Tag = "tablaPuntos";
            this.tablaPuntos.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "X:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // puntoY
            // 
            this.puntoY.Location = new System.Drawing.Point(458, 176);
            this.puntoY.Name = "puntoY";
            this.puntoY.Size = new System.Drawing.Size(100, 20);
            this.puntoY.TabIndex = 4;
            this.puntoY.TextChanged += new System.EventHandler(this.PuntoY_TextChanged);
            // 
            // puntoX
            // 
            this.puntoX.Location = new System.Drawing.Point(458, 139);
            this.puntoX.Name = "puntoX";
            this.puntoX.Size = new System.Drawing.Size(100, 20);
            this.puntoX.TabIndex = 5;
            this.puntoX.TextChanged += new System.EventHandler(this.PuntoX_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MatSup.Properties.Resources.finter;
            this.pictureBox1.Location = new System.Drawing.Point(186, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elegir método: ";
            // 
            // metodos
            // 
            this.metodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodos.FormattingEnabled = true;
            this.metodos.Items.AddRange(new object[] {
            "Lagrange",
            "Newton Gregory progresivo",
            "Newton Gregory regresivo"});
            this.metodos.Location = new System.Drawing.Point(477, 306);
            this.metodos.Name = "metodos";
            this.metodos.Size = new System.Drawing.Size(163, 21);
            this.metodos.TabIndex = 9;
            this.metodos.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // mostrarPasosBox
            // 
            this.mostrarPasosBox.AutoSize = true;
            this.mostrarPasosBox.Location = new System.Drawing.Point(426, 362);
            this.mostrarPasosBox.Name = "mostrarPasosBox";
            this.mostrarPasosBox.Size = new System.Drawing.Size(92, 17);
            this.mostrarPasosBox.TabIndex = 10;
            this.mostrarPasosBox.Text = "Mostrar pasos";
            this.mostrarPasosBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crear polinomio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mostrarPasosBox);
            this.Controls.Add(this.metodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntoX);
            this.Controls.Add(this.puntoY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaPuntos);
            this.Controls.Add(this.Calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Finter";
            this.tablaPuntos.ResumeLayout(false);
            this.tablaPuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TableLayoutPanel tablaPuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox puntoY;
        private System.Windows.Forms.TextBox puntoX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox metodos;
        private System.Windows.Forms.CheckBox mostrarPasosBox;
        private System.Windows.Forms.Button button1;
    }
}

