using System;
using System.Collections.Generic;
using System.Text;

namespace AlumnosFunciones
{
    class Alumno
    {
        Notas notas;
        public string NombreApellido { get; set; }
        public string Dni { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Alumno()
        {
            NombreApellido = "";
            Dni = "";
            Ciudad = "";
            FechaNacimiento = new DateTime(01/01/2000);
            notas = new Notas();
        }

        public Alumno(string nombre, string dni, string ciudad, DateTime fechaNacimiento,
            float parcial1, float parcial2, float parcial3, float parcial4, float parcial5, float parcial6,
            float examen1, float examen2, float examen3, float notaFinal)
        {
            NombreApellido = nombre;
            Dni = dni;
            Ciudad = ciudad;
            FechaNacimiento = fechaNacimiento;
            notas = new Notas(parcial1, parcial2, parcial3, parcial4, parcial5, parcial6, examen1, examen2,
                examen3, notaFinal);
        }

        public void SetParcial1(float parcial)
        {
            notas.Parcial1 = parcial;
        }
        public void SetParcial2(float parcial)
        {
            notas.Parcial1 = parcial;
        }
        public void SetParcial3(float parcial)
        {
            notas.Parcial3 = parcial;
        }
        public void SetParcial4(float parcial)
        {
            notas.Parcial4 = parcial;
        }
        public void SetParcial5(float parcial)
        {
            notas.Parcial5 = parcial;
        }
        public void SetParcial6(float parcial)
        {
            notas.Parcial6 = parcial;
        }
        public void SetExamen1(float examen)
        {
            notas.Examen1 = examen;
        }
        public void SetExamen2(float examen)
        {
            notas.Examen2 = examen;
        }
        public void SetExamen3(float examen)
        {
            notas.Examen3 = examen;
        }
        public float GetNotaFinal()
        {
            return notas.NotaFinal;
        }
        public void CalcularNotas()
        {
            float notaEva1;
            float notaEva2;
            float notaEva3;

            notaEva1 = ((30 * (notas.Parcial1 + notas.Parcial2) / 100) / 2) +
                    (70 * (notas.Examen1) / 100);

            notaEva2 = ((30 * (notas.Parcial3 + notas.Parcial4) / 100) / 2) +
                (70 * (notas.Examen2) / 100);

            notaEva3 = ((30 * (notas.Parcial5 + notas.Parcial6) / 100) / 2) +
                (70 * (notas.Examen3) / 100);

            notas.NotaFinal = (20 * (notaEva1 / 100)) + (30 * (notaEva2 / 100)) +
            (50 * (notaEva3 / 100));
        }
        public override string ToString()
        {
            return NombreApellido + ";" + Dni + ";" + Ciudad + ";" + FechaNacimiento + ";" + notas;
        }
    }
}
