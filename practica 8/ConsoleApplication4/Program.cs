using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            for (int i = 0; i < 5; i++)
            {
              pila.Push(i);
           

            }
            int itemsPila = pila.Count;



            for (int i = 0; i < itemsPila; i++)
            {
                Console.Write(pila.Pop());


            }
            Console.Read();





            Queue cola = new Queue();

            for (int i = 0; i < 5; i++)
            {
              cola.Enqueue(i);
           

            }

            int itemsCola = cola.Count;



            for (int i = 0; i < itemsCola; i++)
            {
                Console.Write(cola.Dequeue());


            }
            Console.Read();
            Console.Read();





            Tempera Uno = new Tempera(ConsoleColor.Blue, "Faber",5);
            Tempera Dos = new Tempera(ConsoleColor.Red, "Rivadavia",3);
            Tempera Tres = new Tempera(ConsoleColor.Cyan, "Bic",2);


            pila.Push(Uno);
            pila.Push(Dos);
            pila.Push(Tres);

             itemsPila = pila.Count;

            for (int i = 0; i < itemsPila; i++)
            {
                //Console.WriteLine((String)(Tempera)pila.Pop);
                
            }

            ArrayList Lista = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Lista.Add(i);
            }
            Console.WriteLine(Lista[4]);


            Lista.Reverse();
            Console.WriteLine();

            Lista.Sort();

            foreach (int i in Lista)
            {
                Console.WriteLine(i);
                
            }
            Console.Read();
            Console.Read();

            Hashtable HT = new Hashtable();

            HT.Add("Valor1", 1);
            HT.Add("Valor2", 2);
            HT.Add("Valor3", 3);
            HT.Add("Valor4", 4);

            int cuenta = HT.Count;

            for (int i = 0; i <cuenta; i++)
            {
                System.Write(HT[i]);
                
            }


            




            



















 

        }
    }
}
