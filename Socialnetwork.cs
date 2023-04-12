//Welcome to my social network application. This application was written entirely in C# by Hishaam Mehmood.

using System; //Allows us to access the system library.

namespace SocialNetwork //namespace used to organise code elements. 
{
    public class SocialNetwork // this is our public class
    {
        public const int Usersmax = 3; //this is the max amount of users 

        public static int[] Likes { get; set; } = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100}; //this is our likes array

        public static string[] Users = new string[3]; //this is our user string array

        public static string[] Posts = new string[3]; //this is our post string array

        public static string[] Images = new string[3]; //this is our image array

        public static string[] Captions = new string[3]; //this is our captions array

        public static int[] Imagelikes { get; set; } = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };  //this is our image likes array


         public static void Main() //main method 
        {

            SelectChoice();

        }
        public static void SelectChoice() //this is our selector method
        {
            int choice = 0;

            Console.ForegroundColor = ConsoleColor.Blue; //the console text color will be blue.
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" Welcome to Hishaam's social network application! ");
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" Please select an option from below: ");
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" 1. Enter Username. ");
            Console.WriteLine(" 2. Add a message post to list of posts. ");
            Console.WriteLine(" 3. List text posts with likes. ");
            Console.WriteLine(" 4. Add an image post to list of posts. ");
            Console.WriteLine(" 5. List Image posts and likes. ");
            Console.WriteLine(" 6. Quit ");
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" Your option is: ");
            Console.WriteLine(" ------------------------------------------------ ");

            try
            {

                string answer = Console.ReadLine();

                choice = Convert.ToInt32(answer);

                switch (choice) //This is our switch statement

                {
                    case 1: //this is our first menu option
                        UserAdd();

                        break;

                    case 2:

                        MessageAdd(); //this is our second menu option

                        break;

                    case 3:

                    ListTextPosts(); //this is our third menu option

                        break;

                    case 4:

                        ImageAdd(); //this is our fourth menu option

                        break;


                    case 5:

                        ListImagePosts(); //this is our fifth menu option

                        break;

                    case 6:
                        Quit(); //this is our sixth menu option
                        break;
                }


            }
            catch (Exception) //catch is used to display an error message; "invalid input"
            {
                Console.WriteLine(" Invalid input ");  
            }

        }

        public static void UserAdd() //this is our user method.
        {

            for (int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter username of User " +(index+1)+ " : "); 
                Console.WriteLine(" ------------------------------------------------ ");
                Users[index] = Console.ReadLine(); //reads the user's input
            }

            SelectChoice(); //returns user back to choice menu
        }

        public static void MessageAdd() //this is our message method.
        {
            for (int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter the message post details for " + Users[index] + " : ");
                Console.WriteLine(" ------------------------------------------------ ");
                Posts[index] = Console.ReadLine(); //stores input in Post array
            }

            for (int index = 0; index < Usersmax; index++)
            {
                int postLikes;
                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter the amount of likes for " + Posts[index] + " : ");
                Console.WriteLine(" ------------------------------------------------ ");
                postLikes = Convert.ToInt32(Console.ReadLine());
                Likes[index] = postLikes;
            }

            SelectChoice(); //returns the user back to the choice menu.
        }



            public static void ListTextPosts() //this is our text posts method
        { 
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" Here is a list of all posts: ");
            Console.WriteLine(" ------------------------------------------------ ");
            
            for(int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" User: " + Users[index] + " has posted " + Posts[index] + " and recieved: " + Likes[index] + " likes. ");
            }

            SelectChoice();
        }

        public static void ImageAdd() //this is our image post method
        {
            for (int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter the image name " + Images[index] + " : "); //the user is asked to input an image name.
                Console.WriteLine(" ------------------------------------------------ ");
                Images[index] = Console.ReadLine();

            }

            for(int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter the image caption for " + Images[index] + ".PNG: "); //the user is asked to input a caption for the image post
                Console.WriteLine(" ------------------------------------------------ ");
                Captions[index] = Console.ReadLine();

                
            }

            for(int index = 0; index < Usersmax; index++)
            {
                int imageLikes;

                Console.WriteLine(" ------------------------------------------------ ");
                Console.WriteLine(" Please enter the amount of likes for " + Images[index]);
                Console.WriteLine(" ------------------------------------------------ ");
                imageLikes = Convert.ToInt32(Console.ReadLine());

                Imagelikes[index] = imageLikes;
            }

            SelectChoice(); //returns the user back to the menu
        }

        public static void ListImagePosts() //this is our 
        {
            Console.WriteLine(" ------------------------------------------------ ");
            Console.WriteLine(" Here is a list of image posts ");
            Console.WriteLine(" ------------------------------------------------ ");

            for (int index = 0; index < Usersmax; index++)
            {
                Console.WriteLine(" User " + Users[index] + " has posted " + Images[index] + ".PNG" + " and recieved: " + Imagelikes[index] + " likes "); //this will output the following; User *username* has posted *imagename*.PNG and recieved *amount* Likes
            }

            SelectChoice();
        }

        public static void Quit() //this is our quit method
        {
            Console.Clear(); //clears the console window 
        }

        }

        
    }


