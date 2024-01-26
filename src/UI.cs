
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UI {

   

    public static LoginScreen login = new LoginScreen();

    public static RegisterScreen register = new RegisterScreen();

    public static MainScreen mainScreen = new MainScreen();

    /// <summary>
    /// Method to call a login screen 
    /// </summary>
    public static void callLoginScreen() {
        login.Display();
    }

    /// <summary>
    /// Method to call a register screen 
    /// </summary>
    public static void callRegisterScreen() {
        register.Display();

    }

    /// <summary>
    /// Method to call a main screen 
    /// </summary>
    public static void callMainScreen() {
        mainScreen.Display();
    }

}