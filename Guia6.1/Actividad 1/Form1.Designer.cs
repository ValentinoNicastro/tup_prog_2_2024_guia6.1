namespace Actividad_1
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
            this.tbVer = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver";
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(16, 30);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.Size = new System.Drawing.Size(335, 156);
            this.tbVer.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(373, 30);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(96, 55);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Location = new System.Drawing.Point(373, 102);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(52, 17);
            this.rbString.TabIndex = 3;
            this.rbString.TabStop = true;
            this.rbString.Text = "String";
            this.rbString.UseVisualStyleBackColor = true;
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(373, 143);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(56, 17);
            this.rbRegex.TabIndex = 4;
            this.rbRegex.TabStop = true;
            this.rbRegex.Text = "Regex";
            this.rbRegex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(483, 204);
            this.Controls.Add(this.rbRegex);
            this.Controls.Add(this.rbString);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbRegex;
    }
}

