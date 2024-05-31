namespace ÖdevMyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary <int,string> myDictionary = new MyDictionary <int,string>();

            //Veri ekleme
            myDictionary.Add(38, "Kayseri");
            myDictionary.Add(60, "Tokat");
            myDictionary.Add(35, "İzmir");

            // Eklenen verileri ekrana yazdırma
            for (int i = 0; i < myDictionary.Length;i++)
            {
                Console.WriteLine("Anahtar: " + myDictionary.keys[i] + ", Değer: " + myDictionary.values[i]);
            }
        }
    }
}
