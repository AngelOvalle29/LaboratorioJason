using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LaboratorioJason
{
    public partial class Form1 : Form
    {
        List<int> notasTemporales = new List<int>();
        List<Notas> listaNotas = new List<Notas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(textBox2.Text);
            notasTemporales.Add(nota);

        }
        private void Grabar()
        {
            string json = JsonConvert.SerializeObject(listaNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Guarda un alumno con sus notas
            Notas notasAlumno = new Notas();

            notasAlumno.Nombre = textBox1.Text;
            notasAlumno.Score = notasTemporales.GetRange(0, notasTemporales.Count);

            //Lista donde serán agregados todos los datos del alumno
            listaNotas.Add(notasAlumno);
            
            Grabar();
            MessageBox.Show("Archivo Guardado con Exito!!");
            //Borra las notas temporales para el pròximo alumno
            notasTemporales.Clear();

        }
    }
}


