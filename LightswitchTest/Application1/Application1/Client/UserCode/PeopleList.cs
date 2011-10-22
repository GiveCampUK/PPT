using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class PeopleList
    {
        partial void Method_Execute()
        {
            System.Diagnostics.Debug.WriteLine("boo ya");
            // Write your code here.
            var prisonsCalledBob = this.DataWorkspace.ApplicationData.Prisons.Where(x => x.Name == "Bob").FirstOrDefault();
            System.Diagnostics.Debug.WriteLine(prisonsCalledBob.Name);
        

        }

        partial void DoMethod1_Execute()
        {
            // Write your code here.

        }

        partial void Method1_Execute()
        {
            // Write your code here.

        }
    }
}
