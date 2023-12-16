
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Screen {

    public Screen() {
    }

    /// <summary>
    /// @return
    /// </summary>
    public abstract void Display();

    /// <summary>
    /// @param content 
    /// @return
    /// </summary>
    protected void DisplayTop(string content) {
        // TODO implement here
        ClearScren();

        if (content != "") 
        {
            Console.WriteLine($"--  {content}");
        }
        else 
        {
            Console.WriteLine();
        }
      
    }
    

    /// <summary>
    /// @param content 
    /// @return
    /// </summary>
    protected void DisplayMid(string content) {
        // TODO implement here
        if (content != "")
        {
            Console.WriteLine($"--  {content}");
        }
        else
        {
            Console.WriteLine();
        }
    }

    /// <summary>
    /// @param content 
    /// @return
    /// </summary>
    protected void DisplayDown(string content) {
        // TODO implement here
        if (content != "")
        {
            Console.WriteLine($"--  {content}");
        }
        else
        {
            Console.WriteLine();
        }
    }

    /// <summary>
    /// @return
    /// </summary>
    protected void ClearScren() {
        Console.Clear();
    }

    /// <summary>
    /// @return
    /// </summary>
    protected string GetUserInput() {
        Console.WriteLine("\\/");
        return Console.ReadLine();
    }

    /// <summary>
    /// @return
    /// </summary>

}