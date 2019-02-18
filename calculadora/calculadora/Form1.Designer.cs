namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnpocentaje = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.bntlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pantalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(0, 0);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(341, 107);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = global::calculadora.Properties.Resources.igual;
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Location = new System.Drawing.Point(175, 315);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(74, 32);
            this.btnigual.TabIndex = 7;
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnmas
            // 
            this.btnmas.BackgroundImage = global::calculadora.Properties.Resources.mas;
            this.btnmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmas.FlatAppearance.BorderSize = 0;
            this.btnmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmas.Location = new System.Drawing.Point(251, 277);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(74, 72);
            this.btnmas.TabIndex = 7;
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackgroundImage = global::calculadora.Properties.Resources.menos;
            this.btnmenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenos.FlatAppearance.BorderSize = 0;
            this.btnmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenos.Location = new System.Drawing.Point(251, 239);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(74, 32);
            this.btnmenos.TabIndex = 7;
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackgroundImage = global::calculadora.Properties.Resources.por;
            this.btnmulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmulti.FlatAppearance.BorderSize = 0;
            this.btnmulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmulti.Location = new System.Drawing.Point(251, 201);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(74, 32);
            this.btnmulti.TabIndex = 7;
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnpocentaje
            // 
            this.btnpocentaje.BackgroundImage = global::calculadora.Properties.Resources.MOD;
            this.btnpocentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpocentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpocentaje.FlatAppearance.BorderSize = 0;
            this.btnpocentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpocentaje.Location = new System.Drawing.Point(95, 163);
            this.btnpocentaje.Name = "btnpocentaje";
            this.btnpocentaje.Size = new System.Drawing.Size(74, 32);
            this.btnpocentaje.TabIndex = 6;
            this.btnpocentaje.UseVisualStyleBackColor = true;
            this.btnpocentaje.Click += new System.EventHandler(this.btnpocentaje_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.BackgroundImage = global::calculadora.Properties.Resources.RAIZ;
            this.btnraiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnraiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnraiz.FlatAppearance.BorderSize = 0;
            this.btnraiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnraiz.Location = new System.Drawing.Point(175, 163);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(74, 32);
            this.btnraiz.TabIndex = 6;
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::calculadora.Properties.Resources._3;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(171, 277);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 32);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = global::calculadora.Properties.Resources._6;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(175, 239);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 32);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = global::calculadora.Properties.Resources._9;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(175, 201);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 32);
            this.btn9.TabIndex = 6;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImage = global::calculadora.Properties.Resources.div;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Location = new System.Drawing.Point(251, 163);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(74, 32);
            this.btndiv.TabIndex = 6;
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::calculadora.Properties.Resources._2;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(95, 277);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 32);
            this.btn2.TabIndex = 6;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.BackgroundImage = global::calculadora.Properties.Resources.dec;
            this.btnpunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpunto.FlatAppearance.BorderSize = 0;
            this.btnpunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpunto.Location = new System.Drawing.Point(95, 315);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(74, 32);
            this.btnpunto.TabIndex = 6;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = global::calculadora.Properties.Resources._5;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(95, 239);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 32);
            this.btn5.TabIndex = 6;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = global::calculadora.Properties.Resources._8;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(95, 201);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 32);
            this.btn8.TabIndex = 6;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = global::calculadora.Properties.Resources._0;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(12, 315);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 32);
            this.btn0.TabIndex = 5;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::calculadora.Properties.Resources._1;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(12, 277);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 32);
            this.btn1.TabIndex = 4;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::calculadora.Properties.Resources._4;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(12, 239);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 32);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = global::calculadora.Properties.Resources._7;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(15, 201);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 32);
            this.btn7.TabIndex = 2;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // bntlimpiar
            // 
            this.bntlimpiar.BackgroundImage = global::calculadora.Properties.Resources.C;
            this.bntlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntlimpiar.FlatAppearance.BorderSize = 0;
            this.bntlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlimpiar.Location = new System.Drawing.Point(15, 163);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(74, 32);
            this.bntlimpiar.TabIndex = 1;
            this.bntlimpiar.UseVisualStyleBackColor = true;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 396);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnpocentaje);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.pantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button bntlimpiar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnpocentaje;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnigual;
    }
}

