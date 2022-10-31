using System.Management.Automation;

PowerShell.Create().AddCommand("Get-Host").Invoke();
Console.ReadKey();