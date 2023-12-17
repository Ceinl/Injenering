
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RegisterScreen : Screen {

    public RegisterScreen() {
    }

    /// <summary>
    /// @return
    /// </summary>
    public void CreateUser(string password, string login) 
    {
        AccInfo.LoginBase.Add(login);
        AccInfo.PasswordBase.Add(password);
    }

    public override void Display()
    {
        bool isLoginAvailable = true;

        DisplayTop("");
        DisplayMid("Do you wish to register? (Yes/No)");
        DisplayDown("");

        string answer = GetUserInput();
        answer = answer.ToLower();
        if (answer == "no") 
        {
            UI.callLoginScreen();
        }
        else if(answer == "yes") 
        {
            DisplayTop("");
            DisplayMid("Enter the new login:");
            DisplayDown("");

            string login = GetUserInput();

            for (int i = 0; i < AccInfo.LoginBase.Count; i++)
            {
                if (login == AccInfo.LoginBase[i]) 
                {
                    isLoginAvailable = false;
                    break;
                }

            }
            if (isLoginAvailable) 
            {
                DisplayTop("");
                DisplayMid("Enter the new password:");
                DisplayDown("");

                string password = GetUserInput();

                CreateUser(password,login);
                UI.callLoginScreen();
            }
           
        } 
        
     

        
        
    }

}