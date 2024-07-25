namespace LINKEDLIST_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINKED LIST DESCRIBING

            var sehırler= new LinkedList<string>();
            sehırler.AddFirst("ankara");
            sehırler.AddFirst("istanbul");
            sehırler.AddLast("nevşehir");

            sehırler.AddBefore(sehırler.Find("istanbul"), "izmir");
            sehırler.AddAfter(sehırler.Last.Previous, "adıyaman");
            sehırler.AddBefore(sehırler.Last.Previous.Previous, "hatay");


            foreach (string s in sehırler)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine();

            Console.WriteLine("GİDİŞ GÜZEGAHI");
            var eleman=sehırler.First;
            while (eleman!=null)
            {
                Console.WriteLine(eleman.Value);
                eleman =eleman.Next;
            }



            Console.ReadKey();
        }
    }
}
