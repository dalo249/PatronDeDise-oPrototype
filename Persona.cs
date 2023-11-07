using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPrototype
{

    abstract public class Persona : ICloneable
    {
        public int Edad;
        public DateTime FechaNacimiento;
        public string Nombre;
        public InfoId InfoId;

        public Persona() { }
        public abstract object Clone();

    }
    abstract public class PersonaSuperficial: Persona
    {
        public int Edad;
        public DateTime FechaNacimiento;
        public string Nombre;
        public InfoId InfoId;

        public override object Clone()
        {
            return (Persona)this.MemberwiseClone();
        }

    }

    public class PersonaProfunda: Persona
    {
        public int Edad;
        public DateTime FechaNacimiento;
        public string Nombre;
        public InfoId InfoId;

        public override object Clone()
        {
            Persona clon = (Persona)this.MemberwiseClone();
            clon.InfoId = new InfoId(InfoId.NumeroId);
            clon.Nombre = String.Copy(Nombre);
            return clon;
        }
    }

    public class InfoId
    {
        public int NumeroId;

        public InfoId(int numeroId)
        {
            this.NumeroId = numeroId;
        }
    }
}