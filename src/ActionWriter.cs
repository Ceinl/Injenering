
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionWriter : ActionContainer {

    private string ElementName;
    private string ElementType;
    private string Option;
    private int Order;

    public ActionWriter() {
    }
    public override void ActionConfigurator(int order, string elementName, string elementType, string option)
    {
        ElementName = elementName;
        ElementType = elementType;
        Option = option;
        Order = order;

        Console.WriteLine($" {order} -- {option} writed to {elementType} {elementName} ");
    }

    public override void ActionHolder()
    {
        BrowserManager.BrowserWriter(ElementName, ElementType, Option);
    }

    public override void ActionResult()
    {
        Console.WriteLine($" {Order} -- {Option} writed to {ElementType} {ElementName} ");
    }

}