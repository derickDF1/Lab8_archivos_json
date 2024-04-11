using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_archivos_json
{
    public partial class Form1 : Form
    {
        List<int> notasTemporales = new List<int>();
        List<Notas> listaNotas = new List<Notas>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_nota_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt16(txt_nota.Text);
            notasTemporales.Add(nota);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Notas notasAlumno = new Notas();

            notasAlumno.Nombre = txt_nombre.Text;
            notasAlumno.Nota = notasTemporales.GetRange(0, notasTemporales.Count);
            listaNotas.Add(notasAlumno);
            Grabar();
            notasTemporales.Clear();
        }

        private void Grabar ()
        {
            string json = JsonConvert.SerializeObject(listaNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}
