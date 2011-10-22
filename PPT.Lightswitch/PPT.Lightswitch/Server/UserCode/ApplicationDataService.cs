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
            if (entity != null && entity.PersonType.Name == "Prisoner")
            {
                var prisoner = Prisoners.AddNew();
                prisoner.ContactId = entity;
                prisoner.SomeData = "Some prisoner data";
            }
        }
    }
}
