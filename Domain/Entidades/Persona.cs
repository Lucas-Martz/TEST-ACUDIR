using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Profesion { get; set; }
    }
}
/* Propuesta de clase
public class Persona
    {
        public long Id { get; private set; }
        public string NombreCompleto { get; private set; }
        public int Edad { get; private set; }
        public string Domicilio { get; private set; }
        public string Telefono { get; private set; }
        public string Profesion { get; private set; }

        // Constructor
        public Persona(string nombreCompleto, int edad, string domicilio, string telefono, string profesion)
        {
            CambiarNombre(nombreCompleto);
            CambiarEdad(edad);
            CambiarDomicilio(domicilio);
            CambiarTelefono(telefono);
            CambiarProfesion(profesion);
        }

        // Métodos de dominio (encapsulan reglas)
        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Nombre requerido", nameof(nombre));
            NombreCompleto = nombre.Trim();
        }

        public void CambiarEdad(int edad)
        {
            if (edad < 0)
                throw new ArgumentOutOfRangeException(nameof(edad), "Edad inválida");
            Edad = edad;
        }

        public void CambiarDomicilio(string domicilio)
        {
            if (string.IsNullOrWhiteSpace(domicilio) || domicilio.Length > 50)
                throw new ArgumentException("Domicilio requerido (<= 50)", nameof(domicilio));
            Domicilio = domicilio.Trim();
        }

        public void CambiarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length > 20)
                throw new ArgumentException("Teléfono inválido (<= 20)", nameof(telefono));
            Telefono = telefono.Trim();
        }

        public void CambiarProfesion(string profesion)
        {
            if (string.IsNullOrWhiteSpace(profesion) || profesion.Length > 50)
                throw new ArgumentException("Profesión requerida (<= 50)", nameof(profesion));
            Profesion = profesion.Trim();
        }

        public void SetId(long id)
        {
            if (id < 0)// Tambien haria un buscar en la base de datos para ver si se repite el id
                throw new ArgumentException("Id Incorrecta" ,nameof(id));
            Id = id;
        }

    }*/
