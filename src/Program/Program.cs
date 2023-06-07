using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, "Paul",80);
            Node n2 = new Node(2,"Ana",74);
            Node n3 = new Node(3,"Germán",56);
            Node n4 = new Node(4,"Sol",45);
            Node n5 = new Node(5,"Gabriela",29);
            Node n6 = new Node(6,"Dikran",19);
            Node n7 = new Node(7,"Martín",12);
            Node n8 = new Node(7,"Anush",7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // Edad de la familia 
            TotalAgeContent visitor = new TotalAgeContent(n1);
            Console.WriteLine(visitor.GetTotalAges());
            // Nombre más largo de la familia
            NameContest visitor1 = new NameContest(n1);
            Console.WriteLine(visitor1.GetLargestName());
            // Hijo más grande
            VisitorOldestSon visitor2 = new VisitorOldestSon();
            Console.WriteLine(visitor2.Content(n1));



        }
    }
}
