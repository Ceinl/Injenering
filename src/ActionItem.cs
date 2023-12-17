
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionItem {

    public dynamic myAction;

    private string myActionType;  
    
    public string myActionName;  

    public ActionItem(dynamic myAction) 
    {
        CreateAction(myAction);
    }

    public void CreateAction(ActionClicker newAction) 
    {
        myAction = newAction;
    }

    public void CreateAction(ActionWriter newAction)
    {
        myAction = newAction;
    }

    public void CreateAction(ActionNavigator newAction)
    {
        myAction = newAction;
    }

    public void CreateAction(ActionLooper newAction)
    {
        myAction = newAction;
    }





    public void RunAction() {

    }

}