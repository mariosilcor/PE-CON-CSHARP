
namespace Aplicacion03_Ejemplo
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
            this.etNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNombre.Location = new System.Drawing.Point(210, 20);
            this.etNombre.Name = "etNombre";
            this.etNombre.Size = new System.Drawing.Size(427, 31);
            this.etNombre.TabIndex = 0;
            this.etNombre.Text = "Resuelve la siguiente ecuación:";
            // 
            // etEcuacion
            // 
            this.etEcuacion.AutoSize = true;
            this.etEcuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etEcuacion.Location = new System.Drawing.Point(320, 100);
            this.etEcuacion.Name = "etEcuacion";
            this.etEcuacion.Size = new System.Drawing.Size(200, 29);
            this.etEcuacion.TabIndex = 1;
            this.etEcuacion.Text = "X = (3Y^2) + Y - 5";
            // 
            // etValor
            // 
            this.etValor.AutoSize = true;
            this.etValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etValor.Location = new System.Drawing.Point(100, 200);
            this.etValor.Name = "etValor";
            this.etValor.Size = new System.Drawing.Size(203, 24);
            this.etValor.TabIndex = 2;
            this.etValor.Text = "Introduce el valor de Y:";
            // 
            // etResultado
            // 
            this.etResultado.AutoSize = true;
            this.etResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etResultado.Location = new System.Drawing.Point(155, 260);
            this.etResultado.Name = "etResultado";
            this.etResultado.Size = new System.Drawing.Size(148, 24);
            this.etResultado.TabIndex = 3;
            this.etResultado.Text = "El valor de X es:";
            // 
            // ctValor
            // 
            this.ctValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctValor.Location = new System.Drawing.Point(350, 200);
            this.ctValor.Name = "ctValor";
            this.ctValor.Size = new System.Drawing.Size(260, 29);
            this.ctValor.TabIndex = 4;
            // 
            // ctResultado
            // 
            this.ctResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctResultado.Location = new System.Drawing.Point(350, 260);
            this.ctResultado.Name = "ctResultado";
            this.ctResultado.Size = new System.Drawing.Size(260, 29);
            this.ctResultado.TabIndex = 5;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(350, 360);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(150, 40);
            this.btCalcular.TabIndex = 6;
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

