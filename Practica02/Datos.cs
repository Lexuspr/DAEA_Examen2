using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    static class Datos
    {
        private static string codigo_paciente = "";

        public static string cod_p
        {
            get { return codigo_paciente; }
            set { codigo_paciente = value; }
        }

        private static string nombre_paciente = "";

        public static string nom_p
        {
            get { return nombre_paciente; }
            set { nombre_paciente = value; }
        }

        private static string codigo_enfermera = "";

        public static string cod_e
        {
            get { return codigo_enfermera; }
            set { codigo_enfermera = value; }
        }

        private static string nombre_enfermera = "";

        public static string nom_e
        {
            get { return nombre_enfermera; }
            set { nombre_enfermera = value; }
        }

        private static string codigo_triaje = "";

        public static string cod_t
        {
            get { return codigo_triaje; }
            set { codigo_triaje = value; }
        }

        private static string codigo_consultorio = "";

        public static string cod_c
        {
            get { return codigo_consultorio; }
            set { codigo_consultorio = value; }
        }

        private static string nombre_consultorio = "";

        public static string nom_c
        {
            get { return nombre_consultorio; }
            set { nombre_consultorio = value; }
        }

        private static string codigo_medico = "";

        public static string cod_m
        {
            get { return codigo_medico; }
            set { codigo_medico = value; }
        }

        private static string nombre_medico = "";

        public static string nom_m
        {
            get { return nombre_medico; }
            set { nombre_medico = value; }
        }
    }
}
