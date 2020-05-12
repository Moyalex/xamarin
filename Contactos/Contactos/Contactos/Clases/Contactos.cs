using System;
using System.Collections.Generic;
using System.Text;

namespace Contactos.Clases
{
	public class Contacto
	{
		private string id;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string appellido;

		public string Apellido
		{
			get { return appellido; }
			set { appellido = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string telefono;

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}
	}
}
