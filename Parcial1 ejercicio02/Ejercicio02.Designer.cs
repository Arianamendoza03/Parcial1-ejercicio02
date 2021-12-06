
namespace Parcial1_ejercicio02
{
    partial class Ejercicio02
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnClacular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IstPalabras = new System.Windows.Forms.ListBox();
            this.btnsaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la frase ";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(264, 56);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(327, 73);
            this.txtFrase.TabIndex = 1;
            // 
            // btnClacular
            // 
            this.btnClacular.Location = new System.Drawing.Point(640, 56);
            this.btnClacular.Name = "btnClacular";
            this.btnClacular.Size = new System.Drawing.Size(116, 67);
            this.btnClacular.TabIndex = 2;
            this.btnClacular.Text = "CALCULAR";
            this.btnClacular.UseVisualStyleBackColor = true;
            this.btnClacular.Click += new System.EventHandler(this.btnClacular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // IstPalabras
            // 
            this.IstPalabras.FormattingEnabled = true;
            this.IstPalabras.Location = new System.Drawing.Point(120, 193);
            this.IstPalabras.Name = "IstPalabras";
            this.IstPalabras.Size = new System.Drawing.Size(161, 121);
            this.IstPalabras.TabIndex = 4;
            // 
            // btnsaludar
            // 
            this.btnsaludar.Location = new System.Drawing.Point(436, 194);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(178, 82);
            this.btnsaludar.TabIndex = 5;
            this.btnsaludar.Text = "SALUDAR ";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.btnsaludar_Click);
            // 
            // Ejercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsaludar);
            this.Controls.Add(this.IstPalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClacular);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio02";
            this.Text = "Cuenta palabras con su respectiva longitud ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnClacular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox IstPalabras;
        private System.Windows.Forms.Button btnsaludar;
    }
}

