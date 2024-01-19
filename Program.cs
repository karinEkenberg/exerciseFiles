namespace exerciseFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fileName = @"mytekst.txt";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.WriteLine("create a file with text and read the file:");
                Console.WriteLine("------------------------------------------");

                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine("Hello and welcome.. ");
                    fileStr.WriteLine("It is the first content.. ");
                    fileStr.WriteLine("of the text file mytekst.txt");
                }
                using (StreamReader sr  = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of my file mytekst.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception MyException)
            {
                Console.WriteLine(MyException.ToString());
            }
        }
    }
}
