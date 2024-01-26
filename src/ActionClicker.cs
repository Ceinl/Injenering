
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionClicker : ActionContainer {

    public ActionClicker() {
    }
    int Order;
    string ElementName;
    string ElementType;

    public override void ActionConfigurator(int order, string elementname, string elementType, string b)
    {
        Order = order;
        ElementName = elementname;
        ElementType = elementType;
    }

    public override void ActionHolder()
    {
        BrowserManager.BrowserClicker(ElementName, ElementType);
    }
    public override void ActionResult()
    {
        Console.WriteLine($"{Order} -- Click on {ElementName}");
    }

}

