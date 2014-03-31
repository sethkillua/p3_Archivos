using System;
using System.IO;

namespace p3_archivos
{
	public class Observador
	{
		public Observador ()
		{
		}
		
		public void inicia(){
			// ver los cambios en el directorio de la aplicación y sobre todos los archivos
	        FileSystemWatcher observador = 
				new FileSystemWatcher(Environment.CurrentDirectory, "*.*");
	
	        // ver el nombre del archivo y tamaño cambiado
	        observador.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;
	        observador.Changed += new FileSystemEventHandler(OnChange);
	        observador.Created += new FileSystemEventHandler(OnChange);
	        observador.Deleted += new FileSystemEventHandler(OnChange);
	        observador.Renamed += new RenamedEventHandler(OnChange);
	        observador.EnableRaisingEvents = true;
	
	        // espera por una tecla para terminar la aplicación
	        Console.ReadLine();
		}
		
		private static void OnChange(object sender, FileSystemEventArgs e)
	    {
	        Console.WriteLine("File: {0} - change type: {1}", e.FullPath, e.ChangeType);
	    }
		
	    private static void OnChange(object sender, RenamedEventArgs e)
	    {
	        Console.WriteLine("File: {0} renamed to {1}", e.OldName, e.Name);
	    }
	}
}

