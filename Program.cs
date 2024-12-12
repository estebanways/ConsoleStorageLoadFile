using Azure.Storage.Blobs;
using System.IO;



namespace ConsoleStorageLoadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "";
            string containerName = "vector-graphics";
            string filePath = @"c:\dism.log";
            string sPath = @"c:\users\esteban\";

            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            BlobClient blob = container.GetBlobClient("archivo");

            blob.DownloadTo(sPath + blob.Name);

            Console.WriteLine("Archivo Bajado con exito");

            //blob.Upload(filePath, true);

            //Console.WriteLine("Archivo subido con exito");

        }
    }
}
