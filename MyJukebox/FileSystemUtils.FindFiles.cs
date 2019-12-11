using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Addison_Wesley.Codebook.FileSystem
{
   /// <summary>
   /// Klasse mit statischen Utility-Methoden für das Dateisystem
   /// </summary>
   public static partial class FileSystemUtils
   {
       //bool cancel = false;

       //public bool Cancel
       //{
       //    set { cancel = value; }
       //    get { return cancel; }
       //}

      /// <summary>
      /// Sucht alle Dateien, die dem angegebenen Muster entsprechen
      /// </summary>
      /// <param name="startDirectory">Pfad zu dem Verzeichnis, dem gesucht werden soll</param>
      /// <param name="filePattern">Das Such-Muster (z. B. *.txt)</param>
      /// <param name="recursive">Gibt an, ob auch in den Unterordnern gesucht werden soll</param>
      /// <returns>Gibt ein ReadOnlyCollection vom Typ FileInfo zurück, die die 
      /// gefundenen Dateien repräsentiert</returns>
      public static ReadOnlyCollection<FileInfo> FindFiles(
         string startDirectory, string filePattern, bool recursive)
      {
         // Basis-Auflistung erzeugen
         List<FileInfo> fileList = new List<FileInfo>();

         // Die rekursive private Methode aufrufen
         FindFiles(new DirectoryInfo(startDirectory), filePattern, recursive, fileList);

         // Ergebnis-Collection zurückgeben
         return new ReadOnlyCollection<FileInfo>(fileList);
      }

      /// <summary>
      /// Sucht alle Dateien, die dem angegebenen Muster entsprechen
      /// </summary>
      /// <param name="directory">Das Verzeichnis, in dem gesucht werden soll</param>
      /// <param name="filePattern">Das Such-Muster (z. B. *.txt)</param>
      /// <param name="recursive">Gibt an, ob auch in den Unterordnern gesucht werden soll</param>
      /// <param name="fileList">Referenz auf eine List-Auflistung, die die 
      /// Pfade zu den gefundenen Dateien aufnimmt</param>
      private static void FindFiles(DirectoryInfo directory,
         string filePattern, bool recursive, List<FileInfo> fileList)
      {
         if (filePattern != null && filePattern.Length > 0)
         {
            // Das Dateimuster splitten
            string[] filePatterns = filePattern.Split(';');

            // Alle Dateimuster durchgehen und in dem übergebenen Verzeichnis suchen
            foreach (string partPattern in filePatterns)
            {
               try
               {
                  foreach (FileInfo fileInfo in directory.GetFiles(partPattern))
                  {
                     fileList.Add(fileInfo);
                  }
               }
               catch (UnauthorizedAccessException)
               {
                  // Der Zugriff wurde verweigert: Ignorieren
               }
            }
         }
         else
         {
            try
            {
               // Kein Suchmuster angegeben: Alle Dateien durchgehen 
               foreach (FileInfo fileInfo in directory.GetFiles())
               {
                  fileList.Add(fileInfo);
               }
            }
            catch (UnauthorizedAccessException)
            {
               // Der Zugriff wurde verweigert: Ignorieren
            }
         }

         if (recursive)
         {
            // Wenn rekursiv gesucht werden soll:
            // Die Methode für alle Unterordner aufrufen
            try
            {
               foreach (DirectoryInfo subDirectory in directory.GetDirectories())
               {
                  FindFiles(subDirectory, filePattern, recursive, fileList);
               }
            }
            catch (UnauthorizedAccessException)
            {
               // Der Zugriff wurde verweigert: Ignorieren
            }
         }
      }
   }
}
