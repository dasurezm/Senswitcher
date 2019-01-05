namespace Senswitcher
{
    partial class Modulo_Formas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulo_Formas));
            this.gbFiguras = new System.Windows.Forms.GroupBox();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.gbColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiguras
            // 
            this.gbFiguras.Location = new System.Drawing.Point(188, 149);
            this.gbFiguras.Name = "gbFiguras";
            this.gbFiguras.Size = new System.Drawing.Size(537, 120);
            this.gbFiguras.TabIndex = 0;
            this.gbFiguras.TabStop = false;
            this.gbFiguras.Text = "groupBox1";
            // 
            // gbColores
            // 
            this.gbColores.Controls.Add(this.btn6);
            this.gbColores.Controls.Add(this.btn5);
            this.gbColores.Controls.Add(this.btn3);
            this.gbColores.Controls.Add(this.btn2);
            this.gbColores.Controls.Add(this.btn4);
            this.gbColores.Controls.Add(this.btn1);
            this.gbColores.Location = new System.Drawing.Point(188, 23);
            this.gbColores.Name = "gbColores";
            this.gbColores.Size = new System.Drawing.Size(537, 120);
            this.gbColores.TabIndex = 1;
            this.gbColores.TabStop = false;
            this.gbColores.Text = "groupBox2";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(57, 215);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(18, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 4;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(141, 19);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "Ejecutar";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(59, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Ejecutar";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(100, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Ejecutar";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(182, 19);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "Ejecutar";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(223, 19);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 35);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "Ejecutar";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // Modulo_Formas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 281);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.gbColores);
            this.Controls.Add(this.gbFiguras);
            this.Name = "Modulo_Formas";
            this.Text = "Módulo de Figuras Geométricas";
            this.gbColores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiguras;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

