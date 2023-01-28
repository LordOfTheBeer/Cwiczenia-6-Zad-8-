namespace Cwiczenia_6_zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adres = "Cyryl Kwiecien\nul. Mokra 1/9\nTychy 40-321";
            
            Console.WriteLine(adres);

            int i = 0;

            do
            {
                if (adres[i] != '\n')
                    
                    Console.Write(adres[i]);
                else
                    Console.Write(" ");

                i++;

            }while (i < adres.Length);

        }
    }
}