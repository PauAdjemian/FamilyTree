using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        private Person person;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }
       public string Name
        {
            get
            {
                return this.person.Name;
            }
        }

        public int Edad {
            get
            {
                return this.person.Age;
            }
        }

        public Person Person
        {
            get
            {
                return this.person;
            }
        } 

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number,string name,int age )
        {
            this.number = number;
            person= new Person(name,age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
