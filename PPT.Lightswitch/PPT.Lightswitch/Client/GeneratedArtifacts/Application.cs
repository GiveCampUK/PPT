//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Application
        : global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.DataWorkspace>
    {
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Application(global::Microsoft.LightSwitch.Model.IApplicationDefinition applicationDefinition) : base(applicationDefinition)
        {
            global::LightSwitchApplication.Application.DetailsClass.Initialize(this);
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_Initialize();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Application_LoggedIn();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static new global::LightSwitchApplication.Application Current
        {
            get
            {
                return (global::LightSwitchApplication.Application)global::Microsoft.LightSwitch.Framework.Client.ClientApplication<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Current;
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactList_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactList_Run(ref bool handled);
    
        /// <summary>
        /// Opens the ShowContactList screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowContactList()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowContactList);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactTypesList_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ContactTypesList_Run(ref bool handled);
    
        /// <summary>
        /// Opens the ShowContactTypesList screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowContactTypesList()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowContactTypesList);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CountryList_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CountryList_Run(ref bool handled);
    
        /// <summary>
        /// Opens the ShowCountryList screen.  If the screen is already opened, it is activated and shown.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowCountryList()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowCountryList);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewContacts_CanRun(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CreateNewContacts_Run(ref bool handled);
    
        /// <summary>
        /// Opens a new instance of the ShowCreateNewContacts screen.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void ShowCreateNewContacts()
        {
            ((global::Microsoft.LightSwitch.Details.Client.IClientApplicationDetails)this.Details).InvokeMethod(this.Details.Methods.ShowCreateNewContacts);
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass, global::LightSwitchApplication.Application.DetailsClass.PropertySet, global::LightSwitchApplication.Application.DetailsClass.CommandSet, global::LightSwitchApplication.Application.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializeCommandEntry = global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowContactList;
                var initializeMethodEntry = global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowContactList;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                __ApplicationEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                    global::LightSwitchApplication.Application.DetailsClass.__Application_Initialized,
                    global::LightSwitchApplication.Application.DetailsClass.__Application_LoggedIn);
            private static void __Application_Initialized(global::LightSwitchApplication.Application a)
            {
                a.Application_Initialize();
            }
            private static void __Application_LoggedIn(global::LightSwitchApplication.Application a)
            {
                a.Application_LoggedIn();
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.Application.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.Application.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            protected override global::Microsoft.LightSwitch.Client.IScreenObject CreateScreen(string screenName, params object[] args)
            {
                switch (screenName)
                {
                    case "ContactList":
                        return global::LightSwitchApplication.ContactList.CreateInstance();
                    case "ContactTypesList":
                        return global::LightSwitchApplication.ContactTypesList.CreateInstance();
                    case "CountryList":
                        return global::LightSwitchApplication.CountryList.CreateInstance();
                    case "CreateNewContacts":
                        return global::LightSwitchApplication.CreateNewContacts.CreateInstance();
                }
            
                return base.CreateScreen(screenName, args);
            }
            
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationPropertySet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationCommandSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowContactList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowContactList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowContactTypesList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowContactTypesList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCountryList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowCountryList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCreateNewContacts
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowCreateNewContacts);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationMethodSet<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowContactList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowContactList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowContactTypesList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowContactTypesList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCountryList
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCountryList);
                    }
                }

                public global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass> ShowCreateNewContacts
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>)
                               base.GetItem(global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowCreateNewContacts);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowContactList = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowContactList",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowContactList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowContactList_CreateExecutableObject);
                private static void _ShowContactList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowContactListCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowContactList_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowContactList.CreateInvocation(new object[0]);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowContactTypesList = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowContactTypesList",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowContactTypesList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowContactTypesList_CreateExecutableObject);
                private static void _ShowContactTypesList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowContactTypesListCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowContactTypesList_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowContactTypesList.CreateInvocation(new object[0]);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCountryList = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCountryList",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCountryList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCountryList_CreateExecutableObject);
                private static void _ShowCountryList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCountryListCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowCountryList_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowCountryList.CreateInvocation(new object[0]);
                }

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCreateNewContacts = new global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCreateNewContacts",
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCreateNewContacts_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowCreateNewContacts_CreateExecutableObject);
                private static void _ShowCreateNewContacts_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCreateNewContactsCommand, sf);
                }
                private static global::Microsoft.LightSwitch.IExecutable _ShowCreateNewContacts_CreateExecutableObject(global::LightSwitchApplication.Application.DetailsClass d)
                {
                    return ((global::LightSwitchApplication.Application.DetailsClass)d).Methods.ShowCreateNewContacts.CreateInvocation(new object[0]);
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowContactList = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowContactList",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactList_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactList_InvokeMethod);
                private static void _ShowContactList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowContactListMethod, sf);
                }
                private static global::System.Exception _ShowContactList_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.ContactList_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowContactList_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.ContactList_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:ContactList", () => global::LightSwitchApplication.ContactList.CreateInstance(), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowContactTypesList = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowContactTypesList",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactTypesList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactTypesList_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowContactTypesList_InvokeMethod);
                private static void _ShowContactTypesList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowContactTypesListMethod, sf);
                }
                private static global::System.Exception _ShowContactTypesList_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.ContactTypesList_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowContactTypesList_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.ContactTypesList_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:ContactTypesList", () => global::LightSwitchApplication.ContactTypesList.CreateInstance(), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCountryList = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCountryList",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCountryList_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCountryList_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCountryList_InvokeMethod);
                private static void _ShowCountryList_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCountryListMethod, sf);
                }
                private static global::System.Exception _ShowCountryList_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.CountryList_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowCountryList_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.CountryList_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:CountryList", () => global::LightSwitchApplication.CountryList.CreateInstance(), args);
                    }
                }
 
                public static readonly global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry
                    ShowCreateNewContacts = new global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Entry(
                        "ShowCreateNewContacts",
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewContacts_Stub,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewContacts_CanInvoke,
                        global::LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowCreateNewContacts_InvokeMethod);
                private static void _ShowCreateNewContacts_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Application.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data> c, global::LightSwitchApplication.Application.DetailsClass d, object sf)
                {
                    c(d, ref d._ShowCreateNewContactsMethod, sf);
                }
                private static global::System.Exception _ShowCreateNewContacts_CanInvoke(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args, global::System.Exception ex)
                {
                    bool result = true;
                    d.Application.CreateNewContacts_CanRun(ref result);
                    return result ? null : ex;
                }
                private static void _ShowCreateNewContacts_InvokeMethod(global::LightSwitchApplication.Application.DetailsClass d, global::System.Collections.ObjectModel.ReadOnlyCollection<object> args)
                {
                    bool handled = false;
                    d.Application.CreateNewContacts_Run(ref handled);
                    if (!handled)
                    {
                        d.ShowScreen("LightSwitchApplication:CreateNewContacts", () => global::LightSwitchApplication.CreateNewContacts.CreateInstance(), args);
                    }
                }
 
            }

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowContactListMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowContactTypesListMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCountryListMethod;

            private global::Microsoft.LightSwitch.Details.Framework.ApplicationMethod<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCreateNewContactsMethod;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowContactListCommand;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowContactTypesListCommand;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCountryListCommand;

            private global::Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand<global::LightSwitchApplication.Application, global::LightSwitchApplication.Application.DetailsClass>.Data _ShowCreateNewContactsCommand;

        }
    }
}
