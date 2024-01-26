
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionItem {

    public dynamic myAction;

    public string myActionName;

   
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



    public void ActionDisplay() 
    {
        myAction.ActionResult();
    }

    public void RunAction() {
        myAction.ActionHolder();
    }

}