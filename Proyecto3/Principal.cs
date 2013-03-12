using System;
using System.Collections;

namespace Tarea_clase_Persona
{
	class Principal{
		public Hashtable Tabla;
		Persona persona=new Persona();
		
		public void GuardarDatos (){
			for (int i=0; i<=4; i++) {
				this.Proceso (new Persona());
			}
		}
		
		public void Proceso (Persona persona){
			Console.WriteLine ("Dame tu nombre");
			persona.nombre = Console.ReadLine ();
			Console.WriteLine ("Dame tu telefono");
			persona.telefono = Console.ReadLine ();
			Console.WriteLine ("Dame tu email");
			persona.email = Console.ReadLine ();
			Console.WriteLine ("Dame tu domicilio");
			persona.domicilio = Console.ReadLine ();
			Console.Clear ();
		}
		
		public void ImprimeDatos (){
			Console.WriteLine ("Nombre:" + (persona.nombre) + "\nTelefono:" + (persona.telefono)+"\nEmail:"+
			                   (persona.email)+"\nDomicilio:"+(persona.domicilio));
		}
		public static void Main (string[] args)
		{
			Principal Correr = new Principal ();
			Correr.GuardarDatos ();
			Correr.ImprimeDatos ();
			
			
		}
	}
}
