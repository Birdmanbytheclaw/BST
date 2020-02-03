using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace BSTree
{
    public class Program
    {
       
        static void Main(string[] args)
        {            
                TR33 numbers = new TR33();
            numbers.PutInsideTheNodes(99);
            numbers.PutInsideTheNodes(76);
            numbers.PutInsideTheNodes(34);
            numbers.PutInsideTheNodes(23);
            numbers.PutInsideTheNodes(3);
            numbers.PutInsideTheNodes(7);
            numbers.PutInsideTheNodes(98);
            numbers.PutInsideTheNodes(56);
            numbers.PutInsideTheNodes(55);
            numbers.PutInsideTheNodes(4);
            numbers.PutInsideTheNodes(8);
            numbers.PutInsideTheNodes(15);
            numbers.PutInsideTheNodes(16);
            numbers.PutInsideTheNodes(23);
            numbers.PutInsideTheNodes(42);
            numbers.PutInsideTheNodes(13);
            numbers.PutInsideTheNodes(63);
            numbers.PutInsideTheNodes(45);
            numbers.PutInsideTheNodes(54);

            numbers.display();

            Console.ReadLine();
        }
    }
}
