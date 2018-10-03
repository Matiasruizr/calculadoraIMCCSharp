using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Transaccion
    {
        string rut_paciente;
        string nom_paciente;
        float estatura;
        int peso;
        float IMC;
        string estado;

        public Transaccion(string rut_paciente, string nom_paciente, float estatura, int peso, float iMC, string estado)
        {
            this.Rut_paciente = rut_paciente;
            this.Nom_paciente = nom_paciente;
            this.Estatura = estatura;
            this.Peso = peso;
            IMC1 = iMC;
            this.Estado = estado;
        }

        public Transaccion()
        {

        }
        public string Rut_paciente { get => rut_paciente; set => rut_paciente = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public int Peso { get => peso; set => peso = value; }
        public float IMC1 { get => IMC; set => IMC = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
