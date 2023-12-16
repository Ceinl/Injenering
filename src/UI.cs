
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UI {

   

    public static LoginScreen login = new LoginScreen();

    public static RegisterScreen register = new RegisterScreen();

    public static MainScreen mainScreen = new MainScreen();

    /// <summary>
    /// Method to call a login screen from base file
    /// </summary>
    public static void callLoginScreen() {
        // TODO implement here
        login.Display();
    }

    /// <summary>
    /// @return
    /// </summary>
    public static void callRegisterScreen() {
        // TODO implement here
        register.Display();

    }

    /// <summary>
    /// @return
    /// </summary>
    public static void callMainScreen() {
        // TODO implement here
        mainScreen.Display();
    }

}