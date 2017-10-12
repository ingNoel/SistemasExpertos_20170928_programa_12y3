namespace SistemasExpertos_20170928_programa_1
{
    partial class Segundo
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
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.cbLógica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(15, 13);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(610, 22);
            this.txtEcuacion.TabIndex = 0;
            this.txtEcuacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEcuacion_KeyPress);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(15, 41);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(1175, 28);
            this.txtRespuesta.TabIndex = 1;
            // 
            // cbLógica
            // 
            this.cbLógica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLógica.FormattingEnabled = true;
            this.cbLógica.Items.AddRange(new object[] {
            "PP",
            "PT",
            "TT",
            "TP"});
            this.cbLógica.Location = new System.Drawing.Point(685, 10);
            this.cbLógica.Name = "cbLógica";
            this.cbLógica.Size = new System.Drawing.Size(96, 24);
            this.cbLógica.TabIndex = 2;
            this.cbLógica.SelectedIndexChanged += new System.EventHandler(this.cbLógica_SelectedIndexChanged);
            this.cbLógica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLógica_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lógica";
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(28, 372);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(0, 17);
            this.lblEjemplo.TabIndex = 6;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(107, 75);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 7;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(201, 75);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 669);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLógica);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtEcuacion);
            this.Name = "Segundo";
            this.Text = "Segundo";
            this.Load += new System.EventHandler(this.Segundo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.ComboBox cbLógica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCerrar;
    }
}