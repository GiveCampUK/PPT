﻿using System;
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
    public partial class ContactList
    {
        partial void ContactList_Activated()
        {
            // Write your code here.

        }

        partial void ContactList_Saving(ref bool handled)
        {
            // Write your code here.
            System.Diagnostics.Debug.WriteLine("Break");

            
        }

        partial void ContactList_Saved()
        {
            // Write your code here.
            
        }

    }
}
