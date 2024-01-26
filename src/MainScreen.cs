
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MainScreen : Screen {

    public MainScreen() {
    }

    public List<ActionItem> ActionQueue = new List<ActionItem>();

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

    private string ConfingDisplay(string ToDisplay) 
    {
        DisplayTop("");
        DisplayMid(ToDisplay);
        DisplayDown("");

        return GetUserInput();
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

        //ActionQueue.Add(new ActionItem("123") { });
        DisplayTop("");
        DisplayMid("List:\n(1) - Write\n(2) - click\n(3) - navigate\n(4) - loop)");
        DisplayDown("");

        int.TryParse(Console.ReadLine(), out int option);

        if (option == 1)
        {
            //  заповнення данних в райтер

            ActionWriter actionWriter = new ActionWriter();
            string myelementName = ConfingDisplay("Element name:");
            string myelementType = ConfingDisplay("Element type:");
            string texttowrite  = ConfingDisplay("Input text:");

            actionWriter.ActionConfigurator(ActionQueue.Count + 1, myelementName, myelementType, texttowrite);
            ActionItem item = new ActionItem();
            item.CreateAction(actionWriter);
            ActionQueue.Add(item);
        }
        else if (option == 2)
        {
            ActionClicker actionClicker = new ActionClicker();
            string myelementName = ConfingDisplay("Element name:");
            string myelementType = ConfingDisplay("Element type:");

            actionClicker.ActionConfigurator(ActionQueue.Count+1, myelementName,myelementType,null);
            ActionItem item = new ActionItem();
            item.CreateAction(actionClicker);
            ActionQueue.Add(item);
            
        }
        else if (option == 3)
        {
           ActionNavigator actionNavigator = new ActionNavigator();
            string Url = ConfingDisplay("Input url:");

            actionNavigator.ActionConfigurator(ActionQueue.Count + 1, Url,null,null);
            ActionItem item = new ActionItem();
            item.CreateAction(actionNavigator);
            ActionQueue.Add(item);

        }
        else if(option == 4)
        {
            ActionLooper actionLooper = new ActionLooper();
            string Positionstart = ConfingDisplay("Loop Start:");
            string PositionEnd = ConfingDisplay("Loop End:");
            string LoopCount = ConfingDisplay("Loop quantity:");

            actionLooper.ActionConfigurator(ActionQueue.Count + 1, Positionstart, PositionEnd,LoopCount);
            ActionItem item = new ActionItem();
            item.CreateAction(actionLooper);
            ActionQueue.Add(item);
        }
        else 
        {
            DisplayTop("");
            DisplayMid("error");
            DisplayDown("");
        }
        


    }
    /// <summary>
    /// @return
    /// </summary>
    public void RemoveAction()
    {
        string toRemove = ConfingDisplay("Type id of element to delete");
        int id;
        if (int.TryParse(toRemove, out id)) 
        {
            ActionQueue.RemoveAt(id);
        }
    }



    /*
     
    Додати дію
    Забрати дію
    Висвітити список
    Параметри
    Виконати чергу
     
     */
    public override void Display() 
    {
        bool loop = true;
        int choice;
        while (loop == true)
        {
            DisplayTop("");
            DisplayMid("List:\n(1) - Add action\n(2) - Remove action\n(3)List a actions\n(4) - Params\n(0) - Run queue");
            DisplayDown("");

            int.TryParse(GetUserInput(), out choice);

            if (choice == 1)
            {
                AddAction();
            }
            else if (choice == 2)
            {
                RemoveAction();
            }
            else if (choice == 3) 
            {
                for (int i = 0; i < ActionQueue.Count;i++) 
                {
                    ActionQueue[i].ActionDisplay();
                }
            }
            else if (choice == 4)
            {
                DisplayTop("");
                DisplayMid("");
                DisplayDown("");
            }
            else if (choice == 0)
            {
                try
                {
                    for (int i = 0; i < ActionQueue.Count; i++)
                    {
                        ActionQueue[i].RunAction();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
                
            }


        }    
    }

}