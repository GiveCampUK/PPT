

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
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Table1Item : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Table1Item entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Table1Item()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Table1Item(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Table1Item> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Table1Item.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Item_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Table1Item_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Table1Item.DetailsClass.GetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Table1Item.DetailsClass.SetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string wowo
        {
            get
            {
                return global::LightSwitchApplication.Table1Item.DetailsClass.GetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.wowo);
            }
            set
            {
                global::LightSwitchApplication.Table1Item.DetailsClass.SetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.wowo, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void wowo_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void wowo_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void wowo_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string morestuff
        {
            get
            {
                return global::LightSwitchApplication.Table1Item.DetailsClass.GetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.morestuff);
            }
            set
            {
                global::LightSwitchApplication.Table1Item.DetailsClass.SetValue(this, global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.morestuff, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void morestuff_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void morestuff_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void morestuff_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Table1Item,
                global::LightSwitchApplication.Table1Item.DetailsClass,
                global::LightSwitchApplication.Table1Item.DetailsClass.IImplementation,
                global::LightSwitchApplication.Table1Item.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>.Entry
                __Table1ItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>.Entry(
                    global::LightSwitchApplication.Table1Item.DetailsClass.__Table1Item_CreateNew,
                    global::LightSwitchApplication.Table1Item.DetailsClass.__Table1Item_Created,
                    global::LightSwitchApplication.Table1Item.DetailsClass.__Table1Item_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Table1Item __Table1Item_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Table1Item> es)
            {
                return new global::LightSwitchApplication.Table1Item(es);
            }
            private static void __Table1Item_Created(global::LightSwitchApplication.Table1Item e)
            {
                e.Table1Item_Created();
            }
            private static bool __Table1Item_AllowSaveWithErrors(global::LightSwitchApplication.Table1Item e)
            {
                bool result = false;
                e.Table1Item_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Table1Item.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string> wowo
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.wowo) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string> morestuff
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties.morestuff) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string wowo { get; set; }
                new string morestuff { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Table1Item.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int>.Data> c, global::LightSwitchApplication.Table1Item.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Table1Item e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Table1Item e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Table1Item e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Entry
                    wowo = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Entry(
                        "wowo",
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_Stub,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_ComputeIsReadOnly,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_Validate,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_GetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_SetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._wowo_OnValueChanged);
                private static void _wowo_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Table1Item.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Data> c, global::LightSwitchApplication.Table1Item.DetailsClass d, object sf)
                {
                    c(d, ref d._wowo, sf);
                }
                private static bool _wowo_ComputeIsReadOnly(global::LightSwitchApplication.Table1Item e)
                {
                    bool result = false;
                    e.wowo_IsReadOnly(ref result);
                    return result;
                }
                private static void _wowo_Validate(global::LightSwitchApplication.Table1Item e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.wowo_Validate(r);
                }
                private static string _wowo_GetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d)
                {
                    return d.ImplementationEntity.wowo;
                }
                private static void _wowo_SetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d, string v)
                {
                    d.ImplementationEntity.wowo = v;
                }
                private static void _wowo_OnValueChanged(global::LightSwitchApplication.Table1Item e)
                {
                    e.wowo_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Entry
                    morestuff = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Entry(
                        "morestuff",
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_Stub,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_ComputeIsReadOnly,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_Validate,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_GetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_SetImplementationValue,
                        global::LightSwitchApplication.Table1Item.DetailsClass.PropertySetProperties._morestuff_OnValueChanged);
                private static void _morestuff_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Table1Item.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Data> c, global::LightSwitchApplication.Table1Item.DetailsClass d, object sf)
                {
                    c(d, ref d._morestuff, sf);
                }
                private static bool _morestuff_ComputeIsReadOnly(global::LightSwitchApplication.Table1Item e)
                {
                    bool result = false;
                    e.morestuff_IsReadOnly(ref result);
                    return result;
                }
                private static void _morestuff_Validate(global::LightSwitchApplication.Table1Item e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.morestuff_Validate(r);
                }
                private static string _morestuff_GetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d)
                {
                    return d.ImplementationEntity.morestuff;
                }
                private static void _morestuff_SetImplementationValue(global::LightSwitchApplication.Table1Item.DetailsClass d, string v)
                {
                    d.ImplementationEntity.morestuff = v;
                }
                private static void _morestuff_OnValueChanged(global::LightSwitchApplication.Table1Item e)
                {
                    e.morestuff_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Data _wowo;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Table1Item, global::LightSwitchApplication.Table1Item.DetailsClass, string>.Data _morestuff;
            
        }
    
        #endregion
    }
    
    #endregion
}
