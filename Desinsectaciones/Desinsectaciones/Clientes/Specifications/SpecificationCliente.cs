using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desinsectaciones.Clientes.Specifications
{
    public class SpecificationCliente : ISpecificationCliente
    {
        public bool IsValid(ICliente cliente)
        {
            if (cliente is null) return false;
            if (IsvalidNombre(cliente) && IsValidEmail(cliente) &&
                IsValidPhone(cliente) && IsValidCodigoPostal(cliente))
            {
                return true;
            }

            return false;
        }

        
        private bool IsvalidNombre(ICliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                return false;
            }
            var patternRegex = new Regex(@"^[a-zA-Z]+$");
            if (patternRegex.IsMatch(cliente.Nombre))
            {
                return true;
            }

            return false;
        }
        private bool IsValidEmail(ICliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Email))
            {
                return false;
            }
            try
            {
                MailAddress mailAddress = new MailAddress(cliente.Email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool IsValidPhone(ICliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Telefono))
            {
                return false;
            }
            var patternRegex = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            return patternRegex.IsMatch(cliente.Telefono);
        }

        private bool IsValidCodigoPostal(ICliente cliente)
        {
            if (cliente.CodigoPostal > 0 && cliente.CodigoPostal < 99999)
            {
                return true;
            }

            return false;
        }

        
    }
}
