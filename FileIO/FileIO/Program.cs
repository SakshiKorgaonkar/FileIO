// See https://aka.ms/new-console-template for more information
namespace File
{
    internal class Fileio
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("e:\\b.txt",FileMode.OpenOrCreate);
            fileStream.WriteByte(65);
            fileStream.Close();
        }
    }
}
