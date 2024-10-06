
namespace Ambientes_de_desarrollo_y_frameworks_Tarea04
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
            this.etNombre = new System.Windows.Forms.Label();
            this.etEcuacion = new System.Windows.Forms.Label();
            this.etValor = new System.Windows.Forms.Label();
            this.etResultado = new System.Windows.Forms.Label();
            this.ctValor = new System.Windows.Forms.TextBox();
            this.ctResultado = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etNombre
            // 
            this.etNombre.AutoSize = true;
            this.etNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNombre.Location = new System.Drawing.Point(50, 20);
            this.etNombre.Name = "etNombre";
            this.etNombre.Size = new System.Drawing.Size(700, 26);
            this.etNombre.TabIndex = 1;
            this.etNombre.Text = "Programa que convierte de Grados Fahrenheit a Grados Celcius.";
            // 
            // etEcuacion
            // 
            this.etEcuacion.AutoSize = true;
            this.etEcuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etEcuacion.Location = new System.Drawing.Point(310, 100);
            this.etEcuacion.Name = "etEcuacion";
            this.etEcuacion.Size = new System.Drawing.Size(220, 26);
            this.etEcuacion.TabIndex = 2;
            this.etEcuacion.Text = "C° = ((F° - 32) * (5/9))";
            // 
            // etValor
            // 
            this.etValor.AutoSize = true;
            this.etValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etValor.Location = new System.Drawing.Point(60, 200);
            this.etValor.Name = "etValor";
            this.etValor.Size = new System.Drawing.Size(361, 24);
            this.etValor.TabIndex = 3;
            this.etValor.Text = "Ingrese el valor de los Grados Fahrenheit:";
            // 
            // etResultado
            // 
            this.etResultado.AutoSize = true;
            this.etResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etResultado.Location = new System.Drawing.Point(115, 260);
            this.etResultado.Name = "etResultado";
            this.etResultado.Size = new System.Drawing.Size(306, 24);
            this.etResultado.TabIndex = 4;
            this.etResultado.Text = "La conversión a Grados Celcius es:";
            // 
            // ctValor
            // 
            this.ctValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctValor.Location = new System.Drawing.Point(460, 200);
            this.ctValor.Name = "ctValor";
            this.ctValor.Size = new System.Drawing.Size(260, 29);
            this.ctValor.TabIndex = 5;
            // 
            // ctResultado
            // 
            this.ctResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctResultado.Location = new System.Drawing.Point(460, 260);
            this.ctResultado.Name = "ctResultado";
            this.ctResultado.Size = new System.Drawing.Size(260, 29);
            this.ctResultado.TabIndex = 6;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(460, 360);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(150, 40);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ctResultado);
            this.Controls.Add(this.ctValor);
            this.Controls.Add(this.etResultado);
            this.Controls.Add(this.etValor);
            this.Controls.Add(this.etEcuacion);
            this.Controls.Add(this.etNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etNombre;
        private System.Windows.Forms.Label etEcuacion;
        private System.Windows.Forms.Label etValor;
        private System.Windows.Forms.Label etResultado;
        private System.Windows.Forms.TextBox ctValor;
        private System.Windows.Forms.TextBox ctResultado;
        private System.Windows.Forms.Button btCalcular;
    }
}

