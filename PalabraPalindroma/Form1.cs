/*
 * Héctor Daniel Díaz Rodríguez
 * 07 / 02 / 18
 * Algoritmo para saber si una palabra es palíndroma
 * danieldiaz3000@gmail.com
 * DíazSystems®
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalabraPalindroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblNo.Hide();   //  Ocultamos los dos labels "Si" y "No"
            lblSi.Hide();
            String palabra = txtIngreso.Text;   //  Guardamos la palabra ingresada
            if (txtIngreso.Text == "" || txtIngreso.Text == "")
                MessageBox.Show("Por favor ingresa una palabra.");
            else
            {
                if (convertirMinusculas(palabra))   //  Si es palíndroma se muestra el label de "Sí"
                    lblSi.Show();
                else
                    lblNo.Show();   //  Si no es palíndroma se muestra el label de "No"
            }
        }

        private static Boolean isPolindromo(String palabra)     //      Función para comprobar si es palídromo
        {
            if (palabra == null)    //  Condición si la palabra no contiene caracteres
                return false;

            int i = 0;  //  Variable que recorrera la palabra de el primer caracter al último
            int j = palabra.Length - 1;     //  Variable que recorrera la palabra de el último caracter al primer

            while (i < j)   //  Mientras que el el indice para las primeras letras sea menor se ejecuta el bloque
            {
                if (palabra[i++] != palabra[j--])   //  Si las letras son desiguales retorna false
                    return false;
            }
            return true;    // Si se acabo el ciclo quiere decir que es una palabra palíndroma
        }

        private static Boolean convertirMinusculas(String palabra)  //  Función que convierte las mayusculas en minusculas
        {
            String letras = palabra.Replace("[^a-zA-Z]", " ").ToLower();
            return isPolindromo(letras);
        }

        //  Se ejecuta el mismo bloque de código del boton cuando la tecla enter es pulsada
        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)    
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                lblNo.Hide();   //  Ocultamos los dos labels "Si" y "No"
                lblSi.Hide();
                String palabra = txtIngreso.Text;   //  Guardamos la palabra ingresada
                if (txtIngreso.Text == "" || txtIngreso.Text == "")
                    MessageBox.Show("Por favor ingresa una palabra.");
                else
                {
                    if (convertirMinusculas(palabra))   //  Si es palíndroma se muestra el label de "Sí"
                        lblSi.Show();
                    else
                        lblNo.Show();   //  Si no es palíndroma se muestra el label de "No"
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //  Link de GitHub
        {
            try
            {
                VisitarGit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el link.");
            }
        }

        private void VisitarGit()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/DanitoxMX");
        }
    }

}
