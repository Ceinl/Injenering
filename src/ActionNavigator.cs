
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionNavigator : ActionContainer {

    private string Url;

    private int Order;

    public ActionNavigator() {
    }

    public override void ActionConfigurator(int a, string url, string b, string c)
    {
        Url = url;
        Order = a;

    }   

    public override void ActionHolder()
    {
        int a;
        BrowserManager.BrowserNavigator(Url);
    }

    public override void ActionResult()
    {
        Console.WriteLine($" {Order} -- Navigation");

    }

}