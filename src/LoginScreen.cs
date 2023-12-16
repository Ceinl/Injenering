
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LoginScreen : Screen {

    public LoginScreen() {
    }

    public string rootLogin = "root";

    public string rootPassword = "start";

    /// <summary>
    /// @return
    /// </summary>
  

    /// <summary>
    /// @return
    /// </summary>
    public bool CompareToRootInfo(string CompareData,bool isLogin) {
        if (isLogin) 
        {
            if (CompareData == rootLogin) 
            {
                return true;
            }
        }
        else if (!isLogin) 
        {
            if (CompareData == rootPassword) 
            {
                return true;
            }
        }
        return false;
    }

    public bool CompareToDataBaseInfo(string compareLogin, string comparePassword) {
        // TODO implement here

        if(AccInfo.LoginBase.Count > 0) 
        {
            for (int i = 0; i < AccInfo.LoginBase.Count; i++)
            {
                if (AccInfo.LoginBase[i] == compareLogin && AccInfo.PasswordBase[i] == comparePassword)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public override void Display()
    {
        string password = "", login ="";


        while (true)
        {

            DisplayTop("");
            DisplayMid("Login:");
            DisplayDown("");

            login = GetUserInput();
            if (CompareToRootInfo(login, true))
            {

                DisplayTop($"login -- {login}");
                DisplayMid("Password:");
                DisplayDown("");

                password = GetUserInput();
                if (CompareToRootInfo(password, false))
                {
                    break;
                    UI.callMainScreen();
                }

            }
            else if (CompareToDataBaseInfo(login, password))
            {
                UI.callMainScreen();
            }
        }
    }
}