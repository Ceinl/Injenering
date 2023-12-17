
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MainScreen : Screen {

    public MainScreen() {
    }

    public List<ActionItem> ActionQueue;

    public string excelPath;

    public int ActionDeley = 0;

    /// <summary>
    /// @return
    /// </summary>
    public void RunActions() {
        // TODO implement here
        foreach (var item in ActionQueue)
        {
            Thread.Sleep(ActionDeley);
            item.RunAction();
        }
    }

    /// <summary>
    /// @return
    /// </summary>
    public void GetExcel()
    {
        excelPath = GetUserInput();
    }
    /// <summary>
    /// @return
    /// </summary>
    public void AddAction()
    {
        ActionQueue.Add(new ActionItem("123") { });
    }
    /// <summary>
    /// @return
    /// </summary>
    public void RemoveAction()
    {

    }




    public override void Display()
    {
        bool loop = true;
        int choice = 0;
        while (loop == true) 
        {
            // Run Add Remove End
            // Add - clicker, writer, looper, navigator
            // Remove - by ActionQueue id
            DisplayTop("Choice action:");
            DisplayMid("List:\n(1)Run actions\n(2)Display actions\n(3)Add action to queue\n(4)Remove action from queue\n(5)Parametrs");
            DisplayDown("");
            int.TryParse(GetUserInput(), out choice);

            ClearScren();

            if (choice == 1) 
            {
            
            }
            else if (choice == 2) 
            { 
            
            }
            else if (choice == 3)
            {
                AddAction();
            }
            else if (choice == 4)
            {
                RemoveAction();
            }
            else if (choice == 5)
            {
                DisplayTop("");
                DisplayMid("Choice param to change");
                DisplayDown("List:(1)Path to excel file\n(2)Action deleay");

                int.TryParse(GetUserInput(), out choice);

                if (choice == 1)
                {
                    DisplayTop("");
                    DisplayMid("Enter a excel file path:");
                    DisplayDown("");

                    GetExcel();
                }
                else if (choice == 2)
                {
                    DisplayTop("");
                    DisplayMid("Enter a delay in miliseconds:");
                    DisplayDown("");

                    int.TryParse(GetUserInput(), out ActionDeley);
                }
            }
            else 
            { 
            
            }
        }
    }

}