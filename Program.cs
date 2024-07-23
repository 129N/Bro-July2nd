using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Brocode_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;

            const string bar = "----------------------";
            Console.WriteLine(bar);
            Console.WriteLine("Revise polymorphism ");
            Console.WriteLine(bar);


            List<Player> players = new List<Player>();
            Player player = new Player ("person");
            Player player1 = new Player("people");
            Player player2 = new Player("Fellows");
            Player player3 = new Player("Bros");
            Console.WriteLine (player);
            Console.WriteLine (player1);
            Console.WriteLine (player2);
            Console.WriteLine (player3);

            List<Character> characters = new List<Character>();
            characters.Add(new Character("ch1"));
            characters.Add(new Character("ch2"));
            characters.Add(new Character("ch3"));
            characters.Add(new Character("ch4"));

            foreach (Character character in characters)
            {
                Console.WriteLine(character.name);
            }
            Console.ReadKey();

        }



        class Player
        {
            public string username;

            public Player (string username)
            {
                this.username = username;
            }

            public override string ToString()
            {
                return username;

            }
        }

        class Character
        {
            public string name;
            public Character(string name)
            {
                this.name = name;
            }
        }

    }

}

   

