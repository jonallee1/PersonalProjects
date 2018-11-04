using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.GUILayer
{
    class MainScreen
    {
        

        public MainScreen()
        {
            Login();
        }


        public void Login()
        {
            bool ProgramRunning = true;
            while (ProgramRunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-                LIBRARY                  -");
                Console.WriteLine("- Please select the following options:    -");
                Console.WriteLine("- 1: Sign In                              -");
                Console.WriteLine("- 2: Create User                          -");
                Console.WriteLine("- 3: Exit                                 -");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Selection: ");
                int intTemp = Convert.ToInt32(Console.ReadLine());
                if (intTemp == 1)
                {
                    SignIn();
                }
                else if (intTemp == 2)
                {

                }
                else if (intTemp == 3)
                {
                    ProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }

            }
            
        }

        public void SignIn()
        {
            bool signInRunning = true;

            while (signInRunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-                SIGN IN                  -");
                Console.WriteLine("-                                         -");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Member ID: ");
                int MemberID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("Go Back? Y/N: ");
                string goBack = Console.ReadLine();
                if (goBack == "Y")
                {
                    signInRunning = false;
                }
                else
                {
                    LibraryMainScreen();
                    signInRunning = false;
                }
                
                /*
                if(singin correctly)
                {
                    LibraryMainScreen();
                    signInRunning = false;
                                

                }
             
             
             
                */
                
                //Call Controller Sign in function
            }





        }
        public void LibraryMainScreen()
        {
            bool mainscreenrunning = true;

            while (mainscreenrunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-               MAIN SCREEN               -");
                Console.WriteLine("- Choose an option                        -");
                Console.WriteLine("- 1: Rent                                 -");
                Console.WriteLine("- 2: Deposit                              -");
                Console.WriteLine("- 3: See current Library objects          -");
                Console.WriteLine("- 4: Sign Out                             -");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Option: ");
                int Selection = Convert.ToInt32(Console.ReadLine());

                if (Selection == 1)
                {
                    //Controller rent
                }
                else if (Selection == 2)
                {
                    //controller deposit
                }
                else if (Selection == 3)
                {
                    //controller show list
                }
                else if (Selection == 4)
                {
                    mainscreenrunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }

        public void createUser()
        {
            bool mainscreenrunning = true;

            while (mainscreenrunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-               MAIN SCREEN               -");
                Console.WriteLine("- Please fill out following forms:        -");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Username: ");
                string Username = Console.ReadLine();
                Console.Write("Password: ");
                string Password = Console.ReadLine();
                Console.Write("Birthday: ");
                string Birthday = Console.ReadLine();
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Go Back? Y/N: ");
                string goBack = Console.ReadLine();
                if (goBack == "Y")
                {
                    mainscreenrunning = false;
                }
                /*if(valid)
                {
                controller create user function

                }*/
            }
        }

        public void Rent()
        {

        }
    }
}
