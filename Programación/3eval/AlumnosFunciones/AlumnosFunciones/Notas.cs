using System;
using System.Collections.Generic;
using System.Text;

namespace AlumnosFunciones
{
    class Notas
    {
        public float Parcial1 { get; set; }
        public float Parcial2 { get; set; }
        public float Parcial3 { get; set; }
        public float Parcial4 { get; set; }
        public float Parcial5 { get; set; }
        public float Parcial6 { get; set; }
        public float Examen1 { get; set; }
        public float Examen2 { get; set; }
        public float Examen3 { get; set; }
        public float NotaFinal { get; set; }

        public Notas()
        {
            Parcial1 = 0;
            Parcial2 = 0;
            Parcial3 = 0;
            Parcial4 = 0;
            Parcial5 = 0;
            Parcial6 = 0;
            Examen1 = 0;
            Examen2 = 0;
            Examen3 = 0;
            NotaFinal = 0;
        }

        public Notas(float parcial1, float parcial2, float parcial3, float parcial4, float parcial5, float parcial6,
            float examen1, float examen2, float examen3, float notaFinal)
        {
            Parcial1 = parcial1;
            Parcial2 = parcial2;
            Parcial3 = parcial3;
            Parcial4 = parcial4;
            Parcial5 = parcial5;
            Parcial6 = parcial6;
            Examen1 = examen1;
            Examen2 = examen2;
            Examen3 = examen3;
            NotaFinal = notaFinal;
        }
        public override string ToString()
        {
            return Parcial1 + ";" + Parcial2 + ";" + Parcial3 + ";" + Parcial4 + ";" + Parcial5 + ";" + Parcial6 + 
                ";" + Examen1 + ";" + Examen2 + ";" + Examen3 + ";" + NotaFinal;
        }

    }
}
