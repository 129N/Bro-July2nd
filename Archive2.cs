using System;

public class Class1
{
    public Class1()
    {
        /* Rnadom number 
		 Console.WriteLine(bar);
            Console.WriteLine("Test of Random number");
            Console.WriteLine(bar);


            Random rnd = new Random();
            Xspeed = rnd.Next(2) == 0 ? 2 : -2;
            Yspeed = rnd.Next(2) == 0 ? 2 : -2;

            Console.WriteLine(Xspeed);
            Console.WriteLine(Yspeed);
		 */
        /*
        Xspeed = rnd.Next(2) == 0 ? 2 : -2;: This line sets the horizontal speed(Xspeed) of the ball.
            rnd.Next(2) generates a random number, either 0 or 1.
           If the number is 0, Xspeed is set to 2;
        if the number is 1, Xspeed is set to - 2.
           This ensures the ball moves either to the left or right randomly.

            In most of the case, Switch is better but the this code's choice was either 0 or 1. 
        */

        // Rnadom number with loop 
        /*int randomsped1;

            Console.WriteLine(bar);
            Console.WriteLine("Here is the loop");
            Console.WriteLine(bar);

            randomsped1 = rnd.Next(9);

            for (int i = 0; i < randomsped1; i++)
            {
                int randomsped2 = rnd.Next(4);
                Console.WriteLine( "This time number was "+ randomsped2);
            }*/

        //Constructor and object arguments and pass method
        /* 
            Laptop lp = new Laptop("Intel i11\n", "16GB\n", "1TB\n", "RTX-3000\n", "爆速クーラー改\n", "Power Unit Jp outlet type\n");

            Console.WriteLine(lp.CPU + " " +lp.Memory + " " + lp.SSD_Storage + " " + lp.GPU + " " + lp.CPU_Cooler + " " + lp.Power_Unit );
        
           //getter and setter 
        public class Laptop
        {
            public string CPU { get; set; }
            public string Memory { get; set; }
            public string SSD_Storage { get; set; }
            public string GPU { get; set; }
            public string CPU_Cooler { get; set; }
            public string Power_Unit { get; set; }


            //Constructor 
            public Laptop(String CPU, String Memory, String SSD_Storage, String GPU, String CPU_Cooler, String Power_Unit)
            {
                this.CPU = CPU;
                this.Memory = Memory;
                this.SSD_Storage = SSD_Storage;
                this.GPU = GPU;
                this.CPU_Cooler = CPU_Cooler;
                this.Power_Unit = Power_Unit;
            }

        }
         
         
         */

        // Object arguments and change method of written one.
        /*
         * Car car = new Car("Toyota", "This is a famouos brand among the car industries.", "The fuels cunsumption efficiency is really stunning");

            Console.WriteLine(car.Name + " \n" + car.Description);
            

            change_mode(car, "The fuels cunsumption efficiency is really stunning. \nHowever, THe maintainance cost will be much more expensive than any other car company's one.");
            Console.WriteLine(car.Tip);
            Console.ReadKey();


        public class Car
        {
            public string Name { get; set; }
            public string Description { get; set; } 
            public string Tip { get; set; }

            public Car(string Name, string Description, string Tip)
            {
                this.Name = Name;
                this.Description = Description;
                this.Tip = Tip;
            }

        }

        public static void change_mode(Car car,string Tip )
        {
            car.Tip = Tip;
        }

         */

        // Array of Objects 

        /*
         * Star_Rail[] HSR = {new Star_Rail("Caelus"), new Star_Rail("Firefly"), new Star_Rail("Ingetsu"), new Star_Rail("Pam & 7th"), new Star_Rail("Himeko & Welt") };

            for (int i = 0; i < HSR.Length; i++)
            {
                Console.WriteLine(HSR[i].character);
            }
            

        public class Star_Rail
        {
            public string character;

            public Star_Rail(string character)
            {
                this.character = character;
            }
        }

         */

        //ToString 
        /*
            Informations inf = new Informations(129, "Itsuku", "Taitou 2-90-139", 176.5);

            Console.WriteLine(inf);
            //The words written in the class are already converted to at the override method.
        
         class Informations
        {
            int ID;
            string name;
            string address;
            double height;

            public   Informations(int ID, string name, string address, double height)
            {
                this.ID = ID;
                this.name = name;
                this.address = address;
                this.height = height;
            }

            public override string ToString()
            {
                string msg = "The name is  " + name +"\nThe address is" + address + " \nID:" + ID + "\n" + height + "cm";
                return msg;
            }
        }
         
    
         */

        // Polymorphism 

        /*
         *   
            Car car = new Car();
            Speeder speeder = new Speeder();
            Cruiser cruiser = new Cruiser();


            Vehichle[] vechicles = { car, speeder, cruiser };

            for (int i = 0; i < vechicles.Length; i++)
            {
                vechicles[i].Go();
            }


         class Vehichle
        {
            public virtual void Go()
            {
                Console.WriteLine("This is Vehicle class. Which means Mother class");
            }
        }
        class Car : Vehichle
        {
            public override void Go()
            {
                Console.WriteLine("Car is moving forward to the office.");
            }
        }
        class Speeder : Vehichle
        {
            public override void Go()
            {
                Console.WriteLine("Speeder is a vehivle which is appering in StarWars.");
            }
        }
        class Cruiser : Vehichle
        {
            public override void Go()
            {
                Console.WriteLine("Cruiser is a vehivle which is appering in StarWars.");
            }
        }
         */

        // Interface Hawk and Rabbit 

        /*
          Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();

            rabbit.FLee();
            hawk.Hunt();
        
         
         
          interface IPrey
        {
            void FLee();

        }
        interface Ipredator {
            void Hunt();

        }
       class Rabbit : IPrey
        {
            public void FLee()
            {
                Console.WriteLine("The rabbit is running and cahsing the monster ");
            }
        }
        class Hawk : Ipredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is flying across the sky and dawn.");
            }
        }
        
         
         
        :*/

        // Interface Audio and Player 

        /*
            VideoPlugin video = new VideoPlugin();
          AudioPlugin audioPlugin = new AudioPlugin();

            video.play();
            audioPlugin.play();

        public interface Mediaplugin
        {
            void play();
            void stop();
        }

        public class AudioPlugin : Mediaplugin
        {
            public void play()
            {
                Console.WriteLine("The Audio is connected.....");
            }

            public void stop()
            {
                Console.WriteLine("The Audio was terminated..... ");
            }
        } 
        public class VideoPlugin : Mediaplugin
        {
            public void play()
            {
                Console.WriteLine("The Video is connected..... ");
            }
            public void stop()
            {
                Console.WriteLine("The Video was terminated..... ");
            }
        }
         
         */


        // Interface and using the switch 

        /* Console.WriteLine(bar);
            Console.WriteLine("Here is the Scanner with interface action.");
            Console.WriteLine(bar);

            Console.WriteLine("The Current system status");
            video.Set_Down();
            display.Set_Down();
            Console.WriteLine("1:Change\n" + "2:Continue\n" + "3:End");

           


            while (!isValidInput)
            {
                Console.WriteLine("Please enter a number between 1 and 5, or the word 'exit':");      
                string response = Console.ReadLine();
             

                switch (response)
                {
                    case "1":
                        Console.WriteLine("----The " + response + " has been typed.----");
                        Console.ReadKey();
                        Console.WriteLine("Would you like to on those?");
                        video.Set_Down();
                        display.Set_Down();
                        Console.WriteLine("1:Change Video\n" + "2:Change Display \n" + "3:Change both\n" + "4:End");
                        string resp = Console.ReadLine();

                        switch (resp)
                        {
                            case "1":
                                Console.WriteLine("----The " + resp + " has been typed.----");
                                video.Set_Up();
                                Console.WriteLine("The Video system has been turned on");
                                break;
                            case "2":
                                Console.WriteLine("----The " + resp + " has been typed.----");
                                display.Set_Up();
                                Console.WriteLine("The Video system has been turned on");
                                break;
                            case "3":
                                Console.WriteLine("----The " + resp + " has been typed.----");
                                display.Set_Up();
                                video.Set_Up();
                                Console.WriteLine("----The Video and Display system has been turned on----");
                                break;

                        }
                        Console.WriteLine("Here is the End");
                        isValidInput = true;
                        Console.ReadKey();
                        break;


                    case "2":
                        Console.WriteLine("----The " + response + " has been typed.----");
                        video.Set_Down();
                        display.Set_Down();
                        isValidInput = true;
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("----The " + response + " has been typed.----");
                        Console.WriteLine("---The processes were terminated.---");
                        isValidInput = true;
                        Console.ReadKey();
                        break;

                    case "exit":
                        Console.WriteLine("----The " + response + " has been typed.----");
                        Console.WriteLine("---The processes were terminated.---");
                        isValidInput = true;
                        Console.ReadKey();
                        break;
                 
                }   
            }
        }


        interface Audio
        {
            void Set_Up();
            void Set_Down();

        }

        class Video : Audio
        {
            public void Set_Up()
            {
                Console.WriteLine("The Video machine is activating....");
            }
            public void Set_Down()
            {
                Console.WriteLine("The Video machine is shutting down....");
            }
        }

        class Display : Audio
        {
            public void Set_Up()
            {
                Console.WriteLine("The Display machine is activating....");
            }
            public void Set_Down()
            {
                Console.WriteLine("The Display machine is shutting down....");
            }
        }
        */


        // List 
        /*
         
            String[] food = { "bar, bar ", "Food1", "Food2", "nvsdkl", "Pizza", "pasokn" };


            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            List<string> Oil = new List<string>();

            Oil.Add("Royal");
            Oil.Add("Hojjiblanca");
            Oil.Add("Picual");
            Oil.Add("Picud");
            Oil.Add("null");

            Oil.Insert(4, "Laguna");

            //Oil.RemoveAt(4);
            //Oil.Clear();
            Console.WriteLine ("The num of oils are " + Oil.Count );
            Console.WriteLine(Oil.Contains("Picual"));
            Console.WriteLine("The Index of " + Oil[0] + " is " + Oil.IndexOf("Royal")) ;

            for (int i = 0;i < Oil.Count;i++)
            {
                //Oil.Insert(4, "Laguna");
           
                Console.WriteLine(Oil[i]);
            }

*/


    }
}


//The revise tasks are objects argumetns passing and method overridng and Tostring, polymorphism, Interface


/*
            Mediaplugin2 playerInstance = new Player();
            Mediaplugin2 recordPlayerInstance = new RecordPlayer();

            MediaPlayer mediaPlayer = new MediaPlayer(playerInstance);

            mediaPlayer.PlayMedia();
            mediaPlayer.StopMedia();

            MediaPlayer mediaPlayerRec = new MediaPlayer(recordPlayerInstance);

            mediaPlayerRec.PlayMedia();
            mediaPlayerRec.StopMedia();


        public interface Mediaplugin2
        {
            void play_mode2();
            void Stop_mode2();
        }

        public class Player : Mediaplugin2
        {

            public void play_mode2()
            {
                Console.WriteLine("----------The player is activated----------");
            }

            public void Stop_mode2()
            {
                Console.WriteLine("----------The player was logged off---------- ");
            }
        }

        public class RecordPlayer : Mediaplugin2
        {
            public void play_mode2()
            {
                Console.WriteLine("----------The RecordPlayer is activated----------");
            }

            public void Stop_mode2()
            {
                Console.WriteLine("----------The RecordPlayer was logged off---------- ");
            }
        }


        // Main application
        public class MediaPlayer
        {
            private Mediaplugin2 _plugin;

            public MediaPlayer(Mediaplugin2 plugin)
            {
                _plugin = plugin;
            }

            public void PlayMedia()
            {
                _plugin.play_mode2();
            }

            public void StopMedia()
            {
                _plugin.Stop_mode2();
            }
        }
*/