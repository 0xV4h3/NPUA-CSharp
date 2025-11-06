using System;

namespace Laborator12
{
    public class FileHolderDemo
    {
        public static void Run()
        {
            using (var fh = new FileHolder("StoicPrinciples.txt"))
            {
                fh.Write("amor fati");
                fh.Write("\ncarpe diem");
                fh.Write("\nmemento mori");
                fh.Write("\nAlea iacta est");
                fh.Write("\nPremeditatio malorum");
                Console.WriteLine("File written.");
            }
        }
    }
}