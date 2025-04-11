using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string gato = "explorer.exe";
        int gatos = 100;

        for (int i = 0; i < gatos; i++)
        {
            Process.Start(gato);
        }
    }
}
