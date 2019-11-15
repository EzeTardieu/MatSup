using System.Windows.Forms;

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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.puntoY = new System.Windows.Forms.TextBox();
            this.puntoX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metodos = new System.Windows.Forms.ComboBox();
            this.mostrarPasosBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ContainerPasos = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ValorAEspecializar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ContainerGrado = new System.Windows.Forms.TextBox();
            this.ContainerEquiespaciados = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PolinomioEspecializado = new System.Windows.Forms.Label();
            this.ContainerPolinomioInterpolante = new System.Windows.Forms.TextBox();
            this.tablaPuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.Pink;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Calcular.Location = new System.Drawing.Point(158, 46);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(74, 25);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Agregar";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // tablaPuntos
            // 
            this.tablaPuntos.AutoScroll = true;
            this.tablaPuntos.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tablaPuntos.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.tablaPuntos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablaPuntos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablaPuntos.ColumnCount = 3;
            this.tablaPuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tablaPuntos.Controls.Add(this.label5, 1, 0);
            this.tablaPuntos.Controls.Add(this.label2, 0, 0);
            this.tablaPuntos.Location = new System.Drawing.Point(267, 21);
            this.tablaPuntos.MaximumSize = new System.Drawing.Size(240, 170);
            this.tablaPuntos.Name = "tablaPuntos";
            this.tablaPuntos.RowCount = 7;
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaPuntos.Size = new System.Drawing.Size(240, 170);
            this.tablaPuntos.TabIndex = 1;
            this.tablaPuntos.Tag = "tablaPuntos";
            this.tablaPuntos.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
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
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // puntoY
            // 
            this.puntoY.Location = new System.Drawing.Point(38, 64);
            this.puntoY.Name = "puntoY";
            this.puntoY.Size = new System.Drawing.Size(100, 20);
            this.puntoY.TabIndex = 4;
            this.puntoY.TextChanged += new System.EventHandler(this.PuntoY_TextChanged);
            // 
            // puntoX
            // 
            this.puntoX.Location = new System.Drawing.Point(37, 36);
            this.puntoX.Name = "puntoX";
            this.puntoX.Size = new System.Drawing.Size(100, 20);
            this.puntoX.TabIndex = 5;
            this.puntoX.TextChanged += new System.EventHandler(this.PuntoX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Método: ";
            // 
            // metodos
            // 
            this.metodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodos.FormattingEnabled = true;
            this.metodos.Items.AddRange(new object[] {
            "Lagrange",
            "Newton Gregory progresivo",
            "Newton Gregory regresivo"});
            this.metodos.Location = new System.Drawing.Point(66, 98);
            this.metodos.Name = "metodos";
            this.metodos.Size = new System.Drawing.Size(166, 21);
            this.metodos.TabIndex = 9;
            this.metodos.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // mostrarPasosBox
            // 
            this.mostrarPasosBox.AutoSize = true;
            this.mostrarPasosBox.Location = new System.Drawing.Point(15, 136);
            this.mostrarPasosBox.Name = "mostrarPasosBox";
            this.mostrarPasosBox.Size = new System.Drawing.Size(92, 17);
            this.mostrarPasosBox.TabIndex = 10;
            this.mostrarPasosBox.Text = "Mostrar pasos";
            this.mostrarPasosBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar polinomio interpolante";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ContainerPasos
            // 
            this.ContainerPasos.BackColor = System.Drawing.SystemColors.Window;
            this.ContainerPasos.Location = new System.Drawing.Point(15, 197);
            this.ContainerPasos.Name = "ContainerPasos";
            this.ContainerPasos.ReadOnly = true;
            this.ContainerPasos.Size = new System.Drawing.Size(492, 278);
            this.ContainerPasos.TabIndex = 12;
            this.ContainerPasos.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Finter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Polinomio interpolante:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Especializar:";
            // 
            // ValorAEspecializar
            // 
            this.ValorAEspecializar.Location = new System.Drawing.Point(80, 520);
            this.ValorAEspecializar.Name = "ValorAEspecializar";
            this.ValorAEspecializar.Size = new System.Drawing.Size(37, 20);
            this.ValorAEspecializar.TabIndex = 16;
            this.ValorAEspecializar.KeyDown += new KeyEventHandler(this.ValorAEspecializar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Grado:";
            // 
            // ContainerGrado
            // 
            this.ContainerGrado.Location = new System.Drawing.Point(237, 520);
            this.ContainerGrado.Name = "ContainerGrado";
            this.ContainerGrado.ReadOnly = true;
            this.ContainerGrado.Size = new System.Drawing.Size(37, 20);
            this.ContainerGrado.TabIndex = 18;
            // 
            // ContainerEquiespaciados
            // 
            this.ContainerEquiespaciados.Location = new System.Drawing.Point(447, 520);
            this.ContainerEquiespaciados.Name = "ContainerEquiespaciados";
            this.ContainerEquiespaciados.ReadOnly = true;
            this.ContainerEquiespaciados.Size = new System.Drawing.Size(36, 20);
            this.ContainerEquiespaciados.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Equiespaciados:";
            // 
            // PolinomioEspecializado
            // 
            this.PolinomioEspecializado.AutoSize = true;
            this.PolinomioEspecializado.Location = new System.Drawing.Point(17, 548);
            this.PolinomioEspecializado.Name = "PolinomioEspecializado";
            this.PolinomioEspecializado.Size = new System.Drawing.Size(0, 13);
            this.PolinomioEspecializado.TabIndex = 21;
            // 
            // ContainerPolinomioInterpolante
            // 
            this.ContainerPolinomioInterpolante.Location = new System.Drawing.Point(134, 488);
            this.ContainerPolinomioInterpolante.Name = "ContainerPolinomioInterpolante";
            this.ContainerPolinomioInterpolante.ReadOnly = true;
            this.ContainerPolinomioInterpolante.Size = new System.Drawing.Size(349, 20);
            this.ContainerPolinomioInterpolante.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 570);
            this.Controls.Add(this.ContainerPolinomioInterpolante);
            this.Controls.Add(this.PolinomioEspecializado);
            this.Controls.Add(this.ContainerEquiespaciados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ContainerGrado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValorAEspecializar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ContainerPasos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mostrarPasosBox);
            this.Controls.Add(this.metodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntoX);
            this.Controls.Add(this.puntoY);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox metodos;
        private System.Windows.Forms.CheckBox mostrarPasosBox;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox ContainerPasos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox ValorAEspecializar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ContainerGrado;
		private System.Windows.Forms.TextBox ContainerEquiespaciados;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label PolinomioEspecializado;
		private System.Windows.Forms.TextBox ContainerPolinomioInterpolante;
	}
}

