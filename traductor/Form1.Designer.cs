namespace traductor
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
            this.textBoxEspanol = new System.Windows.Forms.TextBox();
            this.textBoxIngles = new System.Windows.Forms.TextBox();
            this.labelEspañol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEsp = new System.Windows.Forms.Button();
            this.buttonIng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traductor";
            // 
            // textBoxEspanol
            // 
            this.textBoxEspanol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEspanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspanol.Location = new System.Drawing.Point(85, 53);
            this.textBoxEspanol.Name = "textBoxEspanol";
            this.textBoxEspanol.Size = new System.Drawing.Size(100, 26);
            this.textBoxEspanol.TabIndex = 1;
            // 
            // textBoxIngles
            // 
            this.textBoxIngles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngles.Location = new System.Drawing.Point(85, 97);
            this.textBoxIngles.Name = "textBoxIngles";
            this.textBoxIngles.Size = new System.Drawing.Size(100, 26);
            this.textBoxIngles.TabIndex = 2;
            // 
            // labelEspañol
            // 
            this.labelEspañol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEspañol.AutoSize = true;
            this.labelEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspañol.Location = new System.Drawing.Point(12, 56);
            this.labelEspañol.Name = "labelEspañol";
            this.labelEspañol.Size = new System.Drawing.Size(67, 20);
            this.labelEspañol.TabIndex = 3;
            this.labelEspañol.Text = "Español";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingles";
            // 
            // buttonEsp
            // 
            this.buttonEsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEsp.Location = new System.Drawing.Point(191, 55);
            this.buttonEsp.Name = "buttonEsp";
            this.buttonEsp.Size = new System.Drawing.Size(96, 23);
            this.buttonEsp.TabIndex = 5;
            this.buttonEsp.Text = "Español / Ingles";
            this.buttonEsp.UseVisualStyleBackColor = true;
            this.buttonEsp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEsp_MouseClick);
            // 
            // buttonIng
            // 
            this.buttonIng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIng.Location = new System.Drawing.Point(191, 99);
            this.buttonIng.Name = "buttonIng";
            this.buttonIng.Size = new System.Drawing.Size(96, 23);
            this.buttonIng.TabIndex = 6;
            this.buttonIng.Text = "Ingles / Español";
            this.buttonIng.UseVisualStyleBackColor = true;
            this.buttonIng.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonIng_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 154);
            this.Controls.Add(this.buttonIng);
            this.Controls.Add(this.buttonEsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEspañol);
            this.Controls.Add(this.textBoxIngles);
            this.Controls.Add(this.textBoxEspanol);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Traductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEspanol;
        private System.Windows.Forms.TextBox textBoxIngles;
        private System.Windows.Forms.Label labelEspañol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEsp;
        private System.Windows.Forms.Button buttonIng;
    }
}

