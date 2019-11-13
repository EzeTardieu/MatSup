namespace MatSup
{
    partial class PolinomioView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.polinomioLbl = new System.Windows.Forms.Label();
            this.polK = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gradolbl = new System.Windows.Forms.Label();
            this.gradolblresultado = new System.Windows.Forms.Label();
            this.pasosLagrange1 = new MatSup.PasosLagrange();
            this.equiespaciadoslbl = new System.Windows.Forms.Label();
            this.equiespaciadoslblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polinomio: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especializar a valor: ";
            // 
            // valueBox
            // 
            this.valueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBox.Location = new System.Drawing.Point(219, 94);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(42, 29);
            this.valueBox.TabIndex = 2;
            this.valueBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Especializar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // polinomioLbl
            // 
            this.polinomioLbl.AutoSize = true;
            this.polinomioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polinomioLbl.Location = new System.Drawing.Point(153, 29);
            this.polinomioLbl.Name = "polinomioLbl";
            this.polinomioLbl.Size = new System.Drawing.Size(0, 24);
            this.polinomioLbl.TabIndex = 4;
            this.polinomioLbl.Click += new System.EventHandler(this.Label3_Click);
            // 
            // polK
            // 
            this.polK.AutoSize = true;
            this.polK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polK.Location = new System.Drawing.Point(68, 144);
            this.polK.Name = "polK";
            this.polK.Size = new System.Drawing.Size(193, 20);
            this.polK.TabIndex = 5;
            this.polK.Text = "Polinomio especializado ...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // gradolbl
            // 
            this.gradolbl.AutoSize = true;
            this.gradolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradolbl.Location = new System.Drawing.Point(43, 293);
            this.gradolbl.Name = "gradolbl";
            this.gradolbl.Size = new System.Drawing.Size(72, 24);
            this.gradolbl.TabIndex = 7;
            this.gradolbl.Text = "Grado: ";
            // 
            // gradolblresultado
            // 
            this.gradolblresultado.AutoSize = true;
            this.gradolblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradolblresultado.Location = new System.Drawing.Point(121, 293);
            this.gradolblresultado.Name = "gradolblresultado";
            this.gradolblresultado.Size = new System.Drawing.Size(0, 24);
            this.gradolblresultado.TabIndex = 8;
            // 
            // pasosLagrange1
            // 
            this.pasosLagrange1.AutoSize = true;
            this.pasosLagrange1.Location = new System.Drawing.Point(399, 96);
            this.pasosLagrange1.Name = "pasosLagrange1";
            this.pasosLagrange1.Size = new System.Drawing.Size(356, 400);
            this.pasosLagrange1.TabIndex = 6;
            this.pasosLagrange1.Load += new System.EventHandler(this.PasosLagrange1_Load);
            // 
            // equiespaciadoslbl
            // 
            this.equiespaciadoslbl.AutoSize = true;
            this.equiespaciadoslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equiespaciadoslbl.Location = new System.Drawing.Point(43, 358);
            this.equiespaciadoslbl.Name = "equiespaciadoslbl";
            this.equiespaciadoslbl.Size = new System.Drawing.Size(150, 24);
            this.equiespaciadoslbl.TabIndex = 9;
            this.equiespaciadoslbl.Text = "Equiespaciados:";
            // 
            // equiespaciadoslblresultado
            // 
            this.equiespaciadoslblresultado.AutoSize = true;
            this.equiespaciadoslblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equiespaciadoslblresultado.Location = new System.Drawing.Point(199, 358);
            this.equiespaciadoslblresultado.Name = "equiespaciadoslblresultado";
            this.equiespaciadoslblresultado.Size = new System.Drawing.Size(0, 24);
            this.equiespaciadoslblresultado.TabIndex = 10;
            // 
            // PolinomioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 552);
            this.Controls.Add(this.equiespaciadoslblresultado);
            this.Controls.Add(this.equiespaciadoslbl);
            this.Controls.Add(this.gradolblresultado);
            this.Controls.Add(this.gradolbl);
            this.Controls.Add(this.pasosLagrange1);
            this.Controls.Add(this.polK);
            this.Controls.Add(this.polinomioLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PolinomioView";
            this.Text = "PolinomioView";
            this.Load += new System.EventHandler(this.PolinomioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label polinomioLbl;
        private System.Windows.Forms.Label polK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PasosLagrange pasosLagrange1;
        private System.Windows.Forms.Label gradolbl;
        private System.Windows.Forms.Label gradolblresultado;
        private System.Windows.Forms.Label equiespaciadoslbl;
        private System.Windows.Forms.Label equiespaciadoslblresultado;
    }
}