using System;

namespace p3_archivos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String[] contenido = new String[]{"linea1","linea2"};
			string url = "ejemplo.txt";
			Archivo archivo = new Archivo(url);
			archivo.leer();
			archivo.escribir(contenido);
			archivo.leer();
			
			Observador observador = new Observador();
			observador.inicia();
		}
	}
}
