using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_ejercicio02
{
    public partial class Ejercicio02 : Form
    {
        public Ejercicio02()
        {
            InitializeComponent();
        }

        private void btnClacular_Click(object sender, EventArgs e)
        {
           //valido si el usuario ingreso una frase
           if (this.txtFrase.Text.Length==0)
            {
                MessageBox.Show("Por favor ingrese una frase...");
                //ubica el cursor en el cuadro de texto txtfrase
                this.txtFrase.Focus();
            }
            //creo el array de palabras
            string[] palabras = this.txtFrase.Text.Split(' ');
            this.IstPalabras.Items.Clear();

            //lleno el lisbox  con las palbras 
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                    this.IstPalabras.Items.Add(palabras[i] + "-->" + palabras[i].Length + "caracteres...");
            }
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, Felices fiestas");
        }
    }
}
