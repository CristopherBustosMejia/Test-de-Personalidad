using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HTTPupt;
using Newtonsoft;

namespace Test_de_Personalidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Questions> Test = new List<Questions>();
        public int[] CodeNe = { 2, 4, 7, 9, 11, 14, 16, 19, 21, 23, 26, 28, 31, 33, 35, 38, 40, 43, 45, 47, 50, 52, 55, 57 };
        public int[] CodeConf = { 6, 12, 18, 24, 30, 36, 42, 48, 54 };
        public int[] CodeMin = { 29,32,37,51};
        public int ExPoints;
        public int NePoints;
        public int ConfPoints;
        public int QuestionMark;
        private static void LoadTest(List<Questions> Test)
        {
            Questions question = new Questions();
            FileStream File = new FileStream(@".\Test.txt", FileMode.Open, FileAccess.Read);
            StreamReader Read = new StreamReader(File);
            String Text;

            while ((Text = Read.ReadLine()) != null)
            {
                question = JsonConvertidor.Json_Objeto<Questions>(Text);
                Test.Add(question);
            }
            File.Close();
            Read.Close();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            ClearInst();
            TitleANDQuestions.BackColor = Color.White;
            RunTest(QuestionMark,Test);
        }
        private void ClearInst()
        {
            LabelInst.Text = "";
            LabelInst.BackColor = SystemColors.Window;
            LabelInst.AutoSize = true;
            LabelInst.Location = new System.Drawing.Point(1,1);
            BtnStart.Text = "";
            BtnStart.BackColor = SystemColors.Window;
            BtnStart.Size = new System.Drawing.Size(1, 1);
            BtnStart.Location = new System.Drawing.Point(1, 1);
        }
        private void RunTest(int QuestionMark, List<Questions>Test)
        {
            LoadTest(Test);
            TitleANDQuestions.Font = new Font("Cosntantia", 28, FontStyle.Bold);
            TitleANDQuestions.TextAlign = ContentAlignment.TopLeft;
            TitleANDQuestions.Text = Test[QuestionMark].question;
            BtnYes.Location = new System.Drawing.Point(151, 286);
            BtnYes.Text = "Si";
            BtnYes.Size = new System.Drawing.Size(124, 73);
            BtnNo.Location = new System.Drawing.Point(536, 286);
            BtnNo.Text = "No";
            BtnNo.Size = new System.Drawing.Size(124, 73);
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            bool Ex = true, Ne = false, Conf = false;
            for (int i = 0; i < CodeNe.Length; i++)
            {
                if ((Test[QuestionMark].order) - 1 == CodeNe[i])
                {
                    Ne = true;
                    Ex = false;
                }
            }
            for (int i = 0; i < CodeConf.Length; i++)
            {
                if ((Test[QuestionMark].order)-1 == CodeNe[i])
                {
                    Conf = true;
                    Ex = false;
                }
            }
            if (Ex == true)
            {
                ExPoints++;
            }
            if (Ne == true)
            {
                NePoints++;
            }
            if (Conf == true)
            {
                ConfPoints++;
            }

            if (QuestionMark < (Test.Count)-1)
            {
                QuestionMark++;
                TitleANDQuestions.Text = Test[QuestionMark].question;
            }
            else
            {
                TitleANDQuestions.Text = "Finalizaste el test, tus resultados son:";
                LabelResult.Location = new Point(12, 235);
                LabelResult.Size = new Size(776, 206);
                ShowResult(ExPoints, NePoints);
                if (ConfPoints > 5)
                {
                    TitleANDQuestions.Text = "Finalizaste el test, tus resultados son: \nTus puntos de confiabilidad superaron el umbral, este resultado tiene poco fiabiliadad";
                }
            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            bool minus = false;
            for(int i = 0; i < CodeMin.Length; i++)
            {
                if(Test[QuestionMark].order == CodeMin[i])
                {
                    minus = true;
                }
            }
            if(minus == true)
            {
                ExPoints++;
            }
            if (QuestionMark < (Test.Count)-1)
            {
                QuestionMark++;
                TitleANDQuestions.Text = Test[QuestionMark].question;
            }
            else
            {
                TitleANDQuestions.Text = "Finalizaste el test, tus resultados son:";
                LabelResult.Location = new Point(12, 235);
                LabelResult.Size = new Size(776, 206);
                ShowResult(ExPoints, NePoints);
                if (ConfPoints > 5)
                {
                    TitleANDQuestions.Text = "Finalizaste el test, tus resultados son: \nTus puntos de confiabilidad superaron el umbral, este resultado tiene poco fiabiliadad";
                }
            }
        }
        private void ShowResult(int ExPoints,int NePoints)
        {
            bool Extro, Stab;
            if(ExPoints > 12)
            {
                Extro = true;
            }
            else { Extro = false;}
            if(NePoints > 12)
            {
                Stab = true;
            }
            else { Stab = false;}
            if(Extro == true && Stab == true)
            {
                LabelResult.Text = "Colérico (Extrovertido - Inestable): Sus procesos neuro dinámicos son muy fuertes, pero hay desequilibrio entre inhibición y excitación: son personas sensibles, intranquilas, agresivas, excitables, inconstantes, impulsivas, optimistas y activas, tienen dificultad para dormir, pero mucha facilidad para despertarse. Una alta tasa de extroversión y neurotismo, define a la persona histeropática (inmadurez sin control emocional) los coléricos son de respuestas enérgicas y rápidas.";
            }
            if(Extro == false && Stab == false)
            {
                LabelResult.Text = "Flemático (Introvertido - estable): Sus procesos neuro dinámicos son fuertes, equilibrados y lentos, son personas pacíficas, cuidadosas y tercas, pasivas, controladas y formales, uniformes, calmadas, se fijan a una rutina y hábitos de vida bien estructurados, de ánimo estabilizado, grandemente productivo, reflexivo capaz de volver a sus objetivos, a pesar de las dificultades que se le presentan, vuelve a reestructurar  este aspecto, una alta tasa de introversión puede determinar cierta pereza y desapego al ambiente.";
            }
            if(Extro == true && Stab == false)
            {
                LabelResult.Text = "Sanguíneo: (Extrovertido - Estable): Sus procesos neuro dinámicos son fuertes, equilibrados y de movilidad rápida, son personas sociales, discordantes, locuaces, reactivas, vivaces despreocupadas, tienden a ser líderes de gran productividad, buena capacidad de trabajo, facilidad para adecuarse a situaciones nuevas, una alta tasa de dimensión extrovertida puede determinar el desperdigamiento (diseminación) y desorden de la actividad.";
            }
            if(Extro == false && Stab == true)
            {
                LabelResult.Text = "Melancólico (Introvertido - Inestable): Son sujetos de sistema nervioso débil, especialmente de los procesos inhibitorios, tienden a ser caprichosos, ansiosos, rígidos, soberbios, pesimistas, reservados, insociables, tranquilos y ensimismados. Una tasa muy elevada, determina la personalidad distímica con tendencia a las fobias y obsesiones, sus condicionamientos emocionales son muy rígidos y estables.";
            }
        }
    }
}
