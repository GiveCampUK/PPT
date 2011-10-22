using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void ContactsSet_Inserted(Contacts entity)
        {

            if (entity != null)
            {
                var prisoner = new Prisoner();

            }
        }
    }
}
