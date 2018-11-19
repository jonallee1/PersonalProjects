using Library.src.Library.ControllerLayer;
using Library.src.Library.DataAccessLayer;
using Library.src.Library.Database;
using Library.src.Library.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.Library.GUILayer
{
    class MainScreen
    {
        Controller controller = new Controller();

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
                    createUser();
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
        //encrypt password when reading in information
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
                    if (controller.checkCredentials(MemberID, password))
                    {
                        controller.signIn(MemberID);
                        LibraryMainScreen();
                        signInRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials, please try again");
                    }

                }

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
                Console.WriteLine("- 2: Return                               -");
                Console.WriteLine("- 3: See current Library objects          -");
                Console.WriteLine("- 4: Sign Out                             -");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Option: ");
                int Selection = Convert.ToInt32(Console.ReadLine());

                if (Selection == 1)
                {
                    Rent();
                }
                else if (Selection == 2)
                {
                    returnItem();
                }
                else if (Selection == 3)
                {
                    checkedOutItems();
                }
                else if (Selection == 4)
                {
                    controller.signOut();
                    mainscreenrunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }


        public void returnItem()
        {
            bool returnscreenrunning = true;
            List<LibraryObject> checkedoutitems;
            while (returnscreenrunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-             Return SCREEN               -");
                Console.WriteLine("- Select which item to return by LibID    -");
                Console.WriteLine("- 0: Cancel                               -");
                checkedoutitems = controller.checkOutItems();
                int counter = 1;
                foreach (LibraryObject lo in checkedoutitems)
                {
                    Console.WriteLine(counter + ": Name: " + lo.getName() + ", Type: " + lo.getObjectType() + ", ID: " + lo.getLibraryID());
                    counter++;
                }
                int Selection = Convert.ToInt32(Console.ReadLine());
                if (Selection == 0)
                {
                    returnscreenrunning = false;
                }
                else
                {
                    controller.returnBook(Selection);
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
                Console.Write("Birthday: Year ");
                int bdayyear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Birthday: Month ");
                int bdaymonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Birthday: Day ");
                int bdayday = Convert.ToInt32(Console.ReadLine());
                DateTime birthday = new DateTime(bdayyear, bdayday, bdaymonth);

                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Go Back? Y/N: ");
                string goBack = Console.ReadLine();
                if (goBack == "Y")
                {
                    mainscreenrunning = false;
                }
                else
                {
                    int memberID = controller.createUser(Name,birthday , Username, Password);
                    Console.WriteLine("Your memberID is: " + memberID);
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
            bool rentScreenRunning = true;
            while (rentScreenRunning)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-                   Rent                  -");
                Console.WriteLine("- Choose an option                        -");
                Console.WriteLine("- 1: Search                               -");
                Console.WriteLine("- 2: Cancel                               -");
                Console.WriteLine("-------------------------------------------");

                Console.Write("Option: ");
                int Selection = Convert.ToInt32(Console.ReadLine());
                if (Selection == 1)
                {

                    string Search = Console.ReadLine();
                    returnSearch(Search);
                }
                else if (Selection == 2)
                {
                    rentScreenRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }

        public void returnSearch(String Keyword)
        {
            bool returnSearchRun = true;
            while (returnSearchRun)
            {
                List<LibraryObject> results = controller.returnSearch(Keyword);
                
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-              Search Results             -");
                Console.WriteLine("- Please select an object                 -");
                Console.WriteLine("- 0: Go back                              -");
                int counter = 1;
                Console.WriteLine("Number of results: " + results.Count);
                foreach (LibraryObject lo in results)
                {
                    Console.WriteLine(counter + ": Name: " + lo.getName() + ", Type: " + lo.getObjectType() + ", ID: " + lo.getLibraryID());
                    counter++;
                }
                Console.WriteLine("-------------------------------------------");
                Console.Write("Selection: ");
                int Selection = Convert.ToInt32(Console.ReadLine());
                if (Selection == 0)
                {
                    returnSearchRun = false;
                }
                else
                {
                    controller.checkOut(Selection-1);
                }
            }
        }



        public void checkedOutItems()
        {
            bool checkedOutItems = true;
            while (checkedOutItems)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-        Current Checked Out Items        -");
                List<LibraryObject> checkedoutitems = controller.checkOutItems();
                int counter = 1;
                foreach (LibraryObject lo in checkedoutitems)
                {
                    Console.WriteLine(counter + ": Name: " + lo.getName() + ", Type: " + lo.getObjectType() + ", ID: " + lo.getLibraryID());
                    counter++;
                }
                Console.Write("Go back? Y/N");
                string goBack = Console.ReadLine();
                if (goBack == "Y")
                {
                    checkedOutItems = false;
                }
                else
                {

                }

            }
           
        }
    }
}
