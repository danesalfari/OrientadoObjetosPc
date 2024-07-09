namespace pc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnApp3 = new System.Windows.Forms.Button();
            this.btnApp4 = new System.Windows.Forms.Button();
            this.btnApp2 = new System.Windows.Forms.Button();
            this.btnApp1 = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(12, 75);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(89, 35);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(107, 35);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(89, 75);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnApp3
            // 
            this.btnApp3.Location = new System.Drawing.Point(682, 214);
            this.btnApp3.Name = "btnApp3";
            this.btnApp3.Size = new System.Drawing.Size(68, 63);
            this.btnApp3.TabIndex = 3;
            this.btnApp3.Text = "Aplicacion 3";
            this.btnApp3.UseVisualStyleBackColor = true;
            this.btnApp3.Click += new System.EventHandler(this.btnApp3_Click);
            // 
            // btnApp4
            // 
            this.btnApp4.Location = new System.Drawing.Point(682, 312);
            this.btnApp4.Name = "btnApp4";
            this.btnApp4.Size = new System.Drawing.Size(68, 63);
            this.btnApp4.TabIndex = 4;
            this.btnApp4.Text = "Aplicacion 4 ";
            this.btnApp4.UseVisualStyleBackColor = true;
            this.btnApp4.Click += new System.EventHandler(this.btnApp4_Click);
            // 
            // btnApp2
            // 
            this.btnApp2.Location = new System.Drawing.Point(682, 125);
            this.btnApp2.Name = "btnApp2";
            this.btnApp2.Size = new System.Drawing.Size(68, 63);
            this.btnApp2.TabIndex = 5;
            this.btnApp2.Text = "Aplicacion 2";
            this.btnApp2.UseVisualStyleBackColor = true;
            this.btnApp2.Click += new System.EventHandler(this.btnApp2_Click);
            // 
            // btnApp1
            // 
            this.btnApp1.Location = new System.Drawing.Point(682, 35);
            this.btnApp1.Name = "btnApp1";
            this.btnApp1.Size = new System.Drawing.Size(68, 63);
            this.btnApp1.TabIndex = 6;
            this.btnApp1.Text = "Aplicacion 1";
            this.btnApp1.UseVisualStyleBackColor = true;
            this.btnApp1.Click += new System.EventHandler(this.btnApp1_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(12, 35);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(89, 35);
            this.btnEncender.TabIndex = 7;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Garantia restante:";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(107, 418);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(119, 20);
            this.txtGarantia.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sistema Operativo: VENTANAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.btnApp1);
            this.Controls.Add(this.btnApp2);
            this.Controls.Add(this.btnApp4);
            this.Controls.Add(this.btnApp3);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnApp3;
        private System.Windows.Forms.Button btnApp4;
        private System.Windows.Forms.Button btnApp2;
        private System.Windows.Forms.Button btnApp1;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label label3;
    }
}

