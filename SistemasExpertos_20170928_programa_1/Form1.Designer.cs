namespace SistemasExpertos_20170928_programa_1
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
            this.cbA = new System.Windows.Forms.ComboBox();
            this.cbOperacionLadoA = new System.Windows.Forms.ComboBox();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.cbOperacionLadoB = new System.Windows.Forms.ComboBox();
            this.cbConectores = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbLogica = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "(";
            // 
            // cbA
            // 
            this.cbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbA.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA.FormattingEnabled = true;
            this.cbA.Items.AddRange(new object[] {
            "A",
            "!A",
            "B",
            "!B",
            "C",
            "!C",
            "D",
            "!D"});
            this.cbA.Location = new System.Drawing.Point(37, 38);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(78, 45);
            this.cbA.TabIndex = 1;
            // 
            // cbOperacionLadoA
            // 
            this.cbOperacionLadoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacionLadoA.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacionLadoA.FormattingEnabled = true;
            this.cbOperacionLadoA.Items.AddRange(new object[] {
            "&&",
            "||"});
            this.cbOperacionLadoA.Location = new System.Drawing.Point(121, 38);
            this.cbOperacionLadoA.Name = "cbOperacionLadoA";
            this.cbOperacionLadoA.Size = new System.Drawing.Size(71, 45);
            this.cbOperacionLadoA.TabIndex = 2;
            // 
            // cbB
            // 
            this.cbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.FormattingEnabled = true;
            this.cbB.Items.AddRange(new object[] {
            "A",
            "!A",
            "B",
            "!B",
            "C",
            "!C",
            "D",
            "!D"});
            this.cbB.Location = new System.Drawing.Point(198, 38);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(75, 45);
            this.cbB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = ")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = ")";
            // 
            // cbC
            // 
            this.cbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC.FormattingEnabled = true;
            this.cbC.Items.AddRange(new object[] {
            "A",
            "!A",
            "B",
            "!B",
            "C",
            "!C",
            "D",
            "!D"});
            this.cbC.Location = new System.Drawing.Point(432, 38);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(66, 45);
            this.cbC.TabIndex = 5;
            // 
            // cbD
            // 
            this.cbD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbD.FormattingEnabled = true;
            this.cbD.Items.AddRange(new object[] {
            "A",
            "!A",
            "B",
            "!B",
            "C",
            "!C",
            "D",
            "!D"});
            this.cbD.Location = new System.Drawing.Point(581, 37);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(79, 45);
            this.cbD.TabIndex = 7;
            // 
            // cbOperacionLadoB
            // 
            this.cbOperacionLadoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacionLadoB.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacionLadoB.FormattingEnabled = true;
            this.cbOperacionLadoB.Items.AddRange(new object[] {
            "&&",
            "||"});
            this.cbOperacionLadoB.Location = new System.Drawing.Point(504, 38);
            this.cbOperacionLadoB.Name = "cbOperacionLadoB";
            this.cbOperacionLadoB.Size = new System.Drawing.Size(71, 45);
            this.cbOperacionLadoB.TabIndex = 6;
            // 
            // cbConectores
            // 
            this.cbConectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConectores.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConectores.FormattingEnabled = true;
            this.cbConectores.Items.AddRange(new object[] {
            "->",
            "<->"});
            this.cbConectores.Location = new System.Drawing.Point(313, 37);
            this.cbConectores.Name = "cbConectores";
            this.cbConectores.Size = new System.Drawing.Size(75, 45);
            this.cbConectores.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(200, 89);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 46);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRespuesta.Location = new System.Drawing.Point(40, 146);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(0, 25);
            this.lbRespuesta.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Elegir lógica";
            // 
            // cbLogica
            // 
            this.cbLogica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogica.FormattingEnabled = true;
            this.cbLogica.Items.AddRange(new object[] {
            "PP",
            "PT",
            "TT",
            "TP"});
            this.cbLogica.Location = new System.Drawing.Point(104, 103);
            this.cbLogica.Name = "cbLogica";
            this.cbLogica.Size = new System.Drawing.Size(88, 24);
            this.cbLogica.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 221);
            this.Controls.Add(this.cbLogica);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbConectores);
            this.Controls.Add(this.cbOperacionLadoB);
            this.Controls.Add(this.cbOperacionLadoA);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbA;
        private System.Windows.Forms.ComboBox cbOperacionLadoA;
        private System.Windows.Forms.ComboBox cbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.ComboBox cbD;
        private System.Windows.Forms.ComboBox cbOperacionLadoB;
        private System.Windows.Forms.ComboBox cbConectores;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbRespuesta;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbLogica;
    }
}

