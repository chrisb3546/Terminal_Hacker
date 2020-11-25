


using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] levelOnePasswords = {"testone","testtwo"};
    string[] levelTwoPasswords={"one", "two"};
    int level;
    enum Screen {
        MainMenu, Password, Win
    }
    Screen currentScreen = Screen.MainMenu;
    string password;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();

    }

 

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Learning to code video games!");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the Police Department");
        Terminal.WriteLine("Press 3 for Nasa");
        Terminal.WriteLine("Enter your selection: ");
    }


    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            currentScreen = Screen.MainMenu;
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu){
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password){
            CheckPassword(input);
        }
       

    }

    void RunMainMenu(string input){

        bool isValidLevelNumber = (input == "1" || input == "2");
         if (isValidLevelNumber){
             level = int.Parse(input);
         }
        if( input == "1") 
       {    
           int indexOne = Random.Range(0,levelOnePasswords.Length);
           password = levelOnePasswords[indexOne];
           StartGame();
       }
       else if ( input == "2")
       {
           int indexTwo = Random.Range(0,levelTwoPasswords.Length);
            password = levelTwoPasswords[indexTwo];
            StartGame();
       }
        else 
        {
            Terminal.WriteLine("Please make valid selection");
        }
    }

    void StartGame ()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Please Enter Password: ");
        
    }

    void CheckPassword(string input){
        if (input == password){
            DisplayWinScreen();
        }
        else{
            Terminal.WriteLine("wrong, try again");
        }

    }

    void DisplayWinScreen(){
        currentScreen =  Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward(){
        Terminal.WriteLine("SUCCESS!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}