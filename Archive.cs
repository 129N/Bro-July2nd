using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brocode_2
{
    internal class Archive
    {




        // See https://aka.ms/new-console-template for more information





        /*
        Console.WriteLine("Hello, !");

        Console.WriteLine("I like pizza");
        Console.Write("Unko");
        Console.WriteLine("But i hate pizzza0");

        // This is how to do the comment out in the C#

        Console.WriteLine("\t Brocode");// \t creates the tab
        Console.ReadKey(); // type the enter key can segment
        */



        // Declaration
        //int x ;
        //x = 10;
        //int y = 10;

        //int z;

        //z = x + y;


        //Console.WriteLine(x + y);
        //Console.WriteLine("My rank is "+ z);

        //Console.ReadKey();

        const String bar = "---------------------------------";

        /*

        // Constant code
        Console.WriteLine(bar);
        Console.WriteLine("Constant code");
        Console.WriteLine(bar);

        Console.WriteLine("Next line Please type the Ration you preference");
        const double pi = 3.14;

        Console.WriteLine("Type the radius you want");
        double Ratio = Convert.ToDouble(Console.ReadLine());

        double AREA = pi * (Ratio*Ratio);

        Console.WriteLine("The are of this circle is " + AREA+"cm");
        Console.ReadKey();


        Console.WriteLine("Type casting");
        Console.ReadKey();

        double a = 114.514;
        int b = Convert.ToInt32(a);

        Console.WriteLine(b.GetType()); // Typecast shows what type it is on the console sentences.
        Console.WriteLine(b);
        Console.ReadKey();
        */


        /*
        // Math function
        Console.WriteLine(bar);
        Console.WriteLine("Math Function example");
        Console.WriteLine(bar);

        double c = 5;
        double pw = Math.Pow(c, 2);

        double q = -22;
        double Q = Math.Abs(q);

        Console.WriteLine(pw);
        Console.WriteLine(Q);
        Console.ReadKey();
        */

        /*

        // User input

        Console.WriteLine("What's your first name?");
        String name = Console.ReadLine();


        Console.WriteLine("What's your age?");
        int age = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Hello"+ name);
        Console.WriteLine("You are " + " " + age + "years old");
        Console.ReadKey();
        */

        /*

        //  arithmatic operator
        Console.WriteLine(bar);
        Console.WriteLine("Arithmatic operator");
        Console.WriteLine(bar);
        Console.ReadLine();

        int fr = 3;
        Console.WriteLine(fr);
        Console.ReadKey();

        //fr += 5;

        // fr++; // it increases the num in per. 

        Console.Write("The result of the arithmatic operator is \t" );
        Console.WriteLine(fr);
        */



        // hypotenuse triangle 
        /*
        Console.WriteLine("The hypotenuse");


        Console.WriteLine("Enter side A");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B");
        double B = Convert.ToDouble(Console.ReadLine());

        double S = Math.Sqrt((A * A) * (B * B));
        Console.WriteLine("The hypotenuse is: " + S);

        Console.ReadKey();
        */


        /*
        // String methods 
        Console.WriteLine(bar);
        Console.WriteLine("String Methods");
        Console.WriteLine(bar);

        String phonenum = "123-456-456";

        phonenum = phonenum.Replace("-","X");

        Console.WriteLine(phonenum);
        Console.ReadLine();

        String NAME = "Itsuku Nakano";


        String firstname = NAME.Substring(0, 6);
        String lastname = NAME.Substring(7,6);
        // .Substring(position_of_num_we want to pick up, length of num that will pick up)

        Console.WriteLine(NAME.Length);

        Console.WriteLine(NAME);
        Console.WriteLine(firstname);
        Console.WriteLine(lastname);
        Console.ReadLine();
        */



        /*
        // If statements
        Console.WriteLine(bar);
        Console.WriteLine("If statement");
        Console.WriteLine(bar);
        Console.ReadLine();

        Console.WriteLine("Enter Your born year");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 2000)
        {
            Console.WriteLine("You are millenium generation");

        }
        else if( 2005 > year)
        {
            Console.WriteLine("You are early Z Generation");
        }
        else if (year >= 2006)
        {
            Console.Write("You are later Z Generation");
            Console.WriteLine("You guys are so noob, go fuck your self");
        }
        else
        {
            Console.WriteLine("NULL"); 
        }

        Console.ReadKey();

        */

        /*
        // Conditional operator
        Console.WriteLine(bar);
        Console.WriteLine("Conditional Operator");
        Console.WriteLine(bar);
        Console.ReadLine();

        double temp = 21.0;
        string message;

        if(temp >= 20)
        {
            message = "The weather is warm and comfortable";
        }
        else
        {
            message = "It's cold outside";
        }

        message = (temp > 15) ? "The weather is warm and comfortable" : " It's cold outside";
        */


        /*
        // Switch 
        Console.WriteLine(bar);
        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("It is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("It is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("It is Wednesday");
                break;
            case "Thursday":
                Console.WriteLine("It is Thursday");
                break;
            case "Friday":
                Console.WriteLine("It is Friday");
                break;
            case "Saturday":
                Console.WriteLine("It is Saturday");
                break;
            case "Sunday":
                Console.WriteLine("It is Sunday");
                break;

            default:
                Console.WriteLine(day + " is not a day!");
                break;


        }
        Console.ReadKey();
        */



        /*
        // while loop
        Console.WriteLine(bar);
        Console.WriteLine("While Loop");
        Console.WriteLine(bar);


        Console.WriteLine("Enter your name");
        String name123 = Console.ReadLine();    

        while  (name123 == "")
        {
            Console.Write("You still have a blunk. Loop it again");
            Console.WriteLine("PLEASE ENTER YOUR NAME STUPID!!");
            name123 = Console.ReadLine();
        }
        Console.WriteLine("Hello" + " " +  name123);

        Console.ReadKey();
        */


        /*
        // for loops 
        Console.WriteLine(bar);
        Console.WriteLine("For Loops");
        Console.WriteLine(bar);
        Console.ReadLine();

        for (int i = 0; i < 19; i+=3) // increaee the num with 3 "i++" will increase the num in per num
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();
        */

        /*
        // nested loops 
        Console.WriteLine(bar);
        Console.WriteLine("Nested Loops");
        Console.WriteLine(bar); 
        Console.ReadLine();


        Console.WriteLine("How many rows do you want? ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many columns do you want?");
        int cols = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What symbol: ");
        String symbol =  Console.ReadLine();

        for (int i = 0;i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();

        } Console.ReadKey();
        */



        /*
        // Guess game with random function

        Random random =  new Random();
        bool playagain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;

        String response;

        while (playagain)
        {
            guess = 0;
            guesses = 0;
            response = "";

            number  = random.Next(min, max+1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + ":");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if(guess > number)
                {
                    Console.WriteLine(guess + " is too high");

                } else if(guess < number)
                {
                    Console.WriteLine(guess + " is too low");

                }

                guesses++;

            }
            Console.WriteLine("Number:" + number);
            Console.WriteLine("You win");
            Console.WriteLine("Guesses: " + guesses);

            Console.WriteLine("WOuld you like to play again(Y/N)");
            response = Console.ReadLine();
            response = response.ToUpper();
            if(response == "Y")
            {
                playagain = true;
            }
            else
            {
                playagain = false;

            }

            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
        */



        /*
        Random random1 = new Random();   
        bool playagain_p = true;
        String player_a;
        String computer_p;

        while(playagain_p)
        {
            player_a = "";
            computer_p = "";

            while (player_a != "ROCK" && player_a != "PAPER" && player_a != "SCISSORS")
            {
                Console.WriteLine("Enter ROCK,PAPER,SCISSORS");
                player_a = Console.ReadLine();
                player_a = player_a.ToUpper();
            }

            int randomnum = random.Next(1,4);
            switch (random.Next(1, 4))
            {
                case 1:
                    computer_p = "ROCK";
                    break;

                case 2:
                    computer_p = "PAPER";
                    break;
                case 3:
                    computer_p = "SCISSORS";

            }
        }
        Console.ReadKey();

        */


        //class 



        /*
        class Messages
        {
            void Hello()
            {
                Console.WriteLine("Hello, welocme.");
            }

            void Appreciate()
            {
                Console.WriteLine("Thank you for your cooperation. ");
            }
        }*/


        /*
        // Arrays 
        Console.WriteLine(bar);
        Console.WriteLine("Arrays");
        Console.WriteLine(bar);
        Console.ReadLine();

        String[] cars = { "BMW", "Mustang", "Toyoyta" };


        for(int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
            cars[1] = "!Updated!\nCorvette";
            cars[2] = "Toyota: Supra";
            Console.ReadLine();
        }
        */

        /*
        String[] cars_next = new string[10];
        cars_next[0] = "";
        cars_next[1] = "";
        cars_next[2] = "";
        cars_next[3] = "";
        cars_next[4] = "";
        cars_next[5] = "";
        cars_next[6] = "";
        cars_next[7] = "";
        cars_next[8] = "";
        cars_next[9] = "";
        cars_next[10] = "";
        */



        // methods
        /*
        Console.WriteLine(bar); 
        Console.WriteLine("Methods");
        Console.WriteLine(bar);


        string name = "Chihoko";

        int Parameter = 53;
        happybirthday(name, Parameter);

        Console.ReadKey();


        void happybirthday(String name, int Paramater )
        {

            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday dear" + name);
            Console.WriteLine("Happy Happy happy " + Parameter);
            Console.WriteLine();
        }
        */


        /*
        //return keyword"

        Console.WriteLine(bar);
        Console.WriteLine("return keyword");
        Console.WriteLine(bar);


        double x;
        double y;

        double result;

        Console.WriteLine("Enter a number of X");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter a number of Y");
        y = Convert.ToDouble(Console.ReadLine());

        result = Multiply(x, y);

        Console.WriteLine("the results of \n X is "+ x + "and Y is "+ y +"\n So, The reuslt is  "+result);

        double  Multiply(double x, double y)
        {

            double z = x * y;   
            return z;
        }
        */


        /*


        //Method Overloading ::: Method shares the same name, different parameters.
        Console.WriteLine(bar);
        Console.WriteLine("Method Overload");
        Console.WriteLine(bar);
        Console.ReadLine();


        double total_value;
        double total_value2;

        Console.WriteLine("Type the Atack value");
        double Atk_value = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Type the Defense Value");
        double Defense_value = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Type the Critical Rate Value");
        double Crit_value = Convert.ToDouble(Console.ReadLine());



        total_value = Calculate_method(Atk_value, Defense_value, Crit_value);

        total_value2 = Calculate_method_non(Atk_value, Defense_value);




        Console.WriteLine("The value including the Critical values artifact is" + total_value);
        Console.WriteLine("The value not including the Critical values artifact is" + total_value2);

        Console.ReadKey();  


        double Calculate_method(double At, double De, double Cr){

            return (At + De) + (Cr * 100);


            }

        double Calculate_method_non(double At, double De)
        {
            return At + De;
        }
        */



        /*
        // paramas Key word : a method parameter takes a variable number of arguments.
        Console.WriteLine(bar);
        Console.WriteLine("Paramas Key Word");
        Console.WriteLine(bar);
        Console.ReadLine();



        double total = check_out(1600, 600, 480, 1721, 580);

        Console.WriteLine(total + "Ft");

        double check_out(params double[] prices)
        {
            double total =0;

            foreach (double price in prices) {

                // total = price + price;
                total += price;
            }

            return total;

        }

        Console.ReadKey();
        */


        /*

        //execption 
        Console.WriteLine(bar);
        Console.WriteLine("exception handling  ");
        Console.WriteLine(bar);
        Console.ReadLine();



        // try: try some code that is considered dangerous.
        // catch:　catches and handles exception when they occur 
        // finally: always executes regardless if exception is caught or not.

        double X;
        double Y;
        double Result;

        try
        {
            Console.WriteLine("Enter num");
            X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter num");
            Y = Convert.ToDouble(Console.ReadLine());

            Result = X / Y;

            Console.WriteLine("The reuslt is " + Result);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Enter the number onlty please");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("You can't divide by zero");
        }

        catch (Exception e)
        {
            Console.WriteLine("Something went wrong");
        }

        finally
        {
            Console.WriteLine("tahnks for visiting");
        }
        Console.ReadKey();
        */





        /*
        double gg;
        double le;
        double rpjqgbvn;

        try
        {
            Console.WriteLine("Enter the num you like");
            gg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the num you hate");
            le = Convert.ToDouble(Console.ReadLine());

            rpjqgbvn = gg / le;

            Console.WriteLine("The reuslt is " + rpjqgbvn);
        }catch(FormatException e)
        {
            Console.WriteLine("Enter the number onlty please");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("You can't divide by zero");
        }

        catch (Exception e)
        {
            Console.WriteLine("Something went wrong");
        }

        finally
        {
            Console.WriteLine("tahnks for visiting");
        }*/




        /*
        // multidimenstional array 
        Console.WriteLine(bar);
        Console.WriteLine("multidimenstional array  ");
        Console.WriteLine(bar);
        Console.ReadLine();

        String[] car1 = { "Mustang", "Matsuda", "Macralen" };
        String[] car2 = {"Toyota", "Nissan","Mitsubishi" };
        String[] car3 = { "Toyota", "Nissan", "Mitsubishi" };


        String[,] parking = { { "Mustang", "Matsuda", "Macralen" }, 
                              { "Toyota", "Nissan", "Mitsubishi" } , 
                              { "Toyota", "Nissan", "Mitsubishi" } 
                            };


        parking[2, 0] = "Suzuki";
        parking[2, 1] = "Chevorret";
        parking[2, 2] = "Porche";

        for (int i = 0; i < parking.GetLength(0); i++)
        {
            for(int j = 0; j < parking.GetLength(1); j++)
            {
                Console.WriteLine(parking[i, j] + " ");

            }
        }
        Console.ReadKey();
        */


        /*
        // Objects  
        Console.WriteLine(bar);
        Console.WriteLine("Objects ");
        Console.WriteLine(bar);
        Console.ReadLine();

        human hm = new human();

        hm.Emp_name = "Harold kenjanochhi";
        hm.age = 29;
        hm.shag();

        human hm2 = new human();

        hm.Emp_name = "Martin";
        hm2.age = 1203;
        hm2.Eat();


        Console.ReadKey();
        class human
        {
            public string Emp_name;

            public int age;


            public void Eat()
            {
                Console.WriteLine($"This human called {Emp_name} who is {age} years old is just eating somthing");
            }

            public void shag() { Console.WriteLine($"This human{Emp_name} is just shagging with own hole."); }
        }

        */


        /*
        // Constructor   
        Console.WriteLine(bar);
        Console.WriteLine("Constructor ");
        Console.WriteLine(bar);
        Console.ReadLine();



        status st = new status("irish", 177.3, 68.4, 7);
        st.introduction();

        status st2 = new status("Curosor", 167.3, 48.4, 2);
        st2.introduction();


        class status
        {

            String code_name;
            double height;
            double weight;
            int working_hrs;
            const string mark = "●";

            public status(String code_name,double height, double weight, int working_hrs)
            {
                this.code_name = code_name;
                this.height = height;
                this.weight = weight;
                this.working_hrs = working_hrs;
            }

            public void introduction()
            {
                Console.WriteLine($"{mark}the code name is {code_name}. " +
                    $"\n {mark}The weight is {weight} kg. " +
                    $"\n{mark} The height is {height}cm "+
                    $"\n{mark} This code-name person's working hour is {working_hrs} hours");
            }
        }
        */



        /*
                // static 
                Console.WriteLine(bar);
                Console.WriteLine("Static  ");
        Console.WriteLine(bar);
        Console.ReadLine();


        // Static: クラスのフィールドやメソッドを 「クラスが持つもの」に変更する命令
        Vehicle Car = new Vehicle("pagni");
                Vehicle MortorCycle = new Vehicle("Kawasaki");

                Console.WriteLine("There is a car called " + Car.num_of_cars); // only shows the num of obejcts used now. only 1 will be counted. 
        Console.WriteLine(MortorCycle.num_of_cars);

        Console.WriteLine("The number of static currently using is " + Vehicle.num_of_cars_static);

        Vehicle.Startrace();

        */



        /*
        class Vehicle
        {
            String Model;
            public int num_of_cars;
            public static int num_of_cars_static;

            public Vehicle(String model)
            {
                this.Model = model;
                num_of_cars++;
                num_of_cars_static++;

            }

            public static void Startrace()
            {
                Console.WriteLine("The race has begun");
            }

        }
        */



        // Over constructor technique to create multiple constructors. 
        // witha different set of parameters. name + parameters = signature

        /*
        class Pizza
        {
            string bread;
            string sauce;
            string chceese;
            string topping;


            public Pizza(String bread, String sauce)
            {
                this.bread = bread; this.sauce = sauce;
            }
            public Pizza(String bread, String sauce, String chceese)
            {
                this.bread = bread; this.sauce = sauce; this.chceese = chceese; 
            }
            public Pizza(String bread, String sauce, String chceese, String topping )
            {
                this.bread = bread;this.sauce = sauce; this.chceese = chceese; this.topping = topping;
            }


            Pizza pizza = new Pizza("roaf","tomato", "burugonya", "onion, garlic" );
        }

        */


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        // Inheritance 
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        /* 
        Cars cars = new Cars();
        Bicycles bicycles = new Bicycles();


        Console.WriteLine(cars.speed);
        Console.WriteLine(bicycles.speed);
        Console.WriteLine(cars.wheels);
        Console.WriteLine(bicycles.wheels);

        cars.go();
        bicycles.go();


        class Vehicle
        {
            public int speed = 0;

            public void go()
            {
                Console.WriteLine("This vehicle is moving");
            }
        }

        class Cars : Vehicle
        {
            public int wheels = 4;
        }

        class Bicycles : Vehicle
        {
            public int wheels = 0;
        }
        */


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        // Array objects

        /*
                Console.WriteLine(bar);
                    Console.WriteLine("Array Objects");
                    Console.WriteLine(bar);


                    Car[] garage = new Car[3];

                Car car = new Car("Mustang");
                Car car1 = new Car("Corvete");
                Car car2 = new Car("Lambo");

                garage[0] = car;
                    garage[1] = car1;
                    garage[2] = car2;

                    foreach (Car cars in garage)
                    {
                        Console.WriteLine(cars.model);
                    }
        */


        // array objects with the other class 
        /*

        Car[] garage1 = { new Car("--------------------\nToyota"), new Car("Nissan"), new Car("BMW"), new Car("Mercedes"), new Car("Matsuda"), new Car("Honda\n--------------------") };

            for(int i = 0; i<garage1.Length; i++)
            {
                Console.WriteLine(garage1[i].model);
            }

            class Car
            {
                public string model;

                public Car(string model)
        {
            this.model = model;
        }
        }
        */
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        // Array Objects 2 

/*
        String[] storages = { "Firefly", "SAM", "Jin", "Kafka", "Silverwolf" };

            for (int r = 0; r<storages.Length; r++)
            {
                storages[1] = "SAM(Firefly)";
                Console.WriteLine(storages[r]);
            }






    Console.WriteLine("Here is the array object of the box lists I made");

            box[] boxes = { new box("cardboard", 3), new box("metal", 6), new box("plastic", 11), new box("stenless", 26) };

            for (int j = 0; j<boxes.Length; j++)
            {
                Console.WriteLine(boxes[j].element);
                Console.WriteLine(boxes[j].amount);
            }
        }

        class box
{

    public string element;
    public int amount;

    public box(string element, int amount)
    {
        this.element = element;
        this.amount = amount;
    }
}
*///


    }
}
