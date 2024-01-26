
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ActionContainer {

    public ActionContainer() {
    }

    /// <summary>
    /// @return
    /// </summary>
    public abstract void ActionConfigurator(int a, string b, string c,string d);

    /// <summary>
    /// @return
    /// </summary>
    public abstract void ActionHolder();
    public abstract void ActionResult();


}