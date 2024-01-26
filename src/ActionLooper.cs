
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ActionLooper : ActionContainer {


    MainScreen mainScreen;

    int Order;
    string PositionStart;
    string PositionEnd;
    string loop;

    public override void ActionConfigurator(int order, string potitionStart, string positionEnd, string Loop)
    {
        Order = order;
        PositionStart = potitionStart;
        PositionEnd = positionEnd;
        loop = Loop;
    }

    public override void ActionHolder()
    {
        int.TryParse(PositionStart, out int pos1);
        int.TryParse(PositionEnd, out int pos2);
        int.TryParse(loop, out int Loops);

        for (int i = 0; i < Loops; i++) 
        {
            for (int j = pos1; j < pos2; j++) 
            {
                mainScreen.ActionQueue[j].RunAction();
            }
        }
    }
    public override void ActionResult()
    {
        int.TryParse(loop, out int quantity);
        Console.WriteLine($"{Order} -- Looped for {quantity} times");
    }

}