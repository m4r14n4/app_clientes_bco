using System;

namespace Ejemplo
{
    /// <summary>
    /// Clase Cliente, que hereda de Persona
    /// Un Cliente es una Persona
    /// </summary>
    public class Cliente : Persona
    {
        public decimal Sueldo { get; set; }

        /// <summary>
        /// Este método sobreescribe el ToString()
        /// que tiene definido la clase object
        /// Toda Clase hereda de Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Cliente: {0} ({1})",
                    this.NombreCompleto(), this.DNI);
        }
    }
}