//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ApplicationData", "Contacts_ContactTypes", "ContactTypes", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ApplicationData.Implementation.ContactTypes), "Contacts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ApplicationData.Implementation.Contacts), true)]
[assembly: EdmRelationshipAttribute("ApplicationData", "Contacts_Countries", "Countries", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ApplicationData.Implementation.Countries), "Contacts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ApplicationData.Implementation.Contacts), true)]

#endregion

namespace ApplicationData.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ApplicationDataObjectContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ApplicationDataObjectContext object using the connection string found in the 'ApplicationDataObjectContext' section of the application configuration file.
        /// </summary>
        public ApplicationDataObjectContext() : base("name=ApplicationDataObjectContext", "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(string connectionString) : base(connectionString, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        public ApplicationDataObjectContext(EntityConnection connection) : base(connection, "ApplicationDataObjectContext")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contacts> ContactsSet
        {
            get
            {
                if ((_ContactsSet == null))
                {
                    _ContactsSet = base.CreateObjectSet<Contacts>("ContactsSet");
                }
                return _ContactsSet;
            }
        }
        private ObjectSet<Contacts> _ContactsSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ContactTypes> ContactTypesSet
        {
            get
            {
                if ((_ContactTypesSet == null))
                {
                    _ContactTypesSet = base.CreateObjectSet<ContactTypes>("ContactTypesSet");
                }
                return _ContactTypesSet;
            }
        }
        private ObjectSet<ContactTypes> _ContactTypesSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Countries> CountriesSet
        {
            get
            {
                if ((_CountriesSet == null))
                {
                    _CountriesSet = base.CreateObjectSet<Countries>("CountriesSet");
                }
                return _CountriesSet;
            }
        }
        private ObjectSet<Countries> _CountriesSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ContactsSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContactsSet(Contacts contacts)
        {
            base.AddObject("ContactsSet", contacts);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ContactTypesSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContactTypesSet(ContactTypes contactTypes)
        {
            base.AddObject("ContactTypesSet", contactTypes);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CountriesSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCountriesSet(Countries countries)
        {
            base.AddObject("CountriesSet", countries);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ApplicationData", Name="Contacts")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contacts : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contacts object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="line1">Initial value of the Line1 property.</param>
        /// <param name="line2">Initial value of the Line2 property.</param>
        /// <param name="line3">Initial value of the Line3 property.</param>
        /// <param name="town">Initial value of the Town property.</param>
        /// <param name="county">Initial value of the County property.</param>
        /// <param name="postcode">Initial value of the Postcode property.</param>
        /// <param name="phoneNumbers">Initial value of the PhoneNumbers property.</param>
        /// <param name="contacts_ContactTypes">Initial value of the Contacts_ContactTypes property.</param>
        /// <param name="contacts_Countries">Initial value of the Contacts_Countries property.</param>
        public static Contacts CreateContacts(global::System.Int32 id, global::System.String title, global::System.String firstName, global::System.String lastName, global::System.String line1, global::System.String line2, global::System.String line3, global::System.String town, global::System.String county, global::System.String postcode, global::System.String phoneNumbers, global::System.Int32 contacts_ContactTypes, global::System.Int32 contacts_Countries)
        {
            Contacts contacts = new Contacts();
            contacts.Id = id;
            contacts.Title = title;
            contacts.FirstName = firstName;
            contacts.LastName = lastName;
            contacts.Line1 = line1;
            contacts.Line2 = line2;
            contacts.Line3 = line3;
            contacts.Town = town;
            contacts.County = county;
            contacts.Postcode = postcode;
            contacts.PhoneNumbers = phoneNumbers;
            contacts.Contacts_ContactTypes = contacts_ContactTypes;
            contacts.Contacts_Countries = contacts_Countries;
            return contacts;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Line1
        {
            get
            {
                return _Line1;
            }
            set
            {
                OnLine1Changing(value);
                ReportPropertyChanging("Line1");
                _Line1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Line1");
                OnLine1Changed();
            }
        }
        private global::System.String _Line1;
        partial void OnLine1Changing(global::System.String value);
        partial void OnLine1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Line2
        {
            get
            {
                return _Line2;
            }
            set
            {
                OnLine2Changing(value);
                ReportPropertyChanging("Line2");
                _Line2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Line2");
                OnLine2Changed();
            }
        }
        private global::System.String _Line2;
        partial void OnLine2Changing(global::System.String value);
        partial void OnLine2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Line3
        {
            get
            {
                return _Line3;
            }
            set
            {
                OnLine3Changing(value);
                ReportPropertyChanging("Line3");
                _Line3 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Line3");
                OnLine3Changed();
            }
        }
        private global::System.String _Line3;
        partial void OnLine3Changing(global::System.String value);
        partial void OnLine3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Town
        {
            get
            {
                return _Town;
            }
            set
            {
                OnTownChanging(value);
                ReportPropertyChanging("Town");
                _Town = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Town");
                OnTownChanged();
            }
        }
        private global::System.String _Town;
        partial void OnTownChanging(global::System.String value);
        partial void OnTownChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String County
        {
            get
            {
                return _County;
            }
            set
            {
                OnCountyChanging(value);
                ReportPropertyChanging("County");
                _County = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("County");
                OnCountyChanged();
            }
        }
        private global::System.String _County;
        partial void OnCountyChanging(global::System.String value);
        partial void OnCountyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Postcode
        {
            get
            {
                return _Postcode;
            }
            set
            {
                OnPostcodeChanging(value);
                ReportPropertyChanging("Postcode");
                _Postcode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Postcode");
                OnPostcodeChanged();
            }
        }
        private global::System.String _Postcode;
        partial void OnPostcodeChanging(global::System.String value);
        partial void OnPostcodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumbers
        {
            get
            {
                return _PhoneNumbers;
            }
            set
            {
                OnPhoneNumbersChanging(value);
                ReportPropertyChanging("PhoneNumbers");
                _PhoneNumbers = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneNumbers");
                OnPhoneNumbersChanged();
            }
        }
        private global::System.String _PhoneNumbers;
        partial void OnPhoneNumbersChanging(global::System.String value);
        partial void OnPhoneNumbersChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Contacts_ContactTypes
        {
            get
            {
                return _Contacts_ContactTypes;
            }
            set
            {
                OnContacts_ContactTypesChanging(value);
                ReportPropertyChanging("Contacts_ContactTypes");
                _Contacts_ContactTypes = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Contacts_ContactTypes");
                OnContacts_ContactTypesChanged();
            }
        }
        private global::System.Int32 _Contacts_ContactTypes;
        partial void OnContacts_ContactTypesChanging(global::System.Int32 value);
        partial void OnContacts_ContactTypesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Contacts_Countries
        {
            get
            {
                return _Contacts_Countries;
            }
            set
            {
                OnContacts_CountriesChanging(value);
                ReportPropertyChanging("Contacts_Countries");
                _Contacts_Countries = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Contacts_Countries");
                OnContacts_CountriesChanged();
            }
        }
        private global::System.Int32 _Contacts_Countries;
        partial void OnContacts_CountriesChanging(global::System.Int32 value);
        partial void OnContacts_CountriesChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ApplicationData", "Contacts_ContactTypes", "ContactTypes")]
        public ContactTypes PersonType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ContactTypes>("ApplicationData.Contacts_ContactTypes", "ContactTypes").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ContactTypes>("ApplicationData.Contacts_ContactTypes", "ContactTypes").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ContactTypes> PersonTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ContactTypes>("ApplicationData.Contacts_ContactTypes", "ContactTypes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ContactTypes>("ApplicationData.Contacts_ContactTypes", "ContactTypes", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ApplicationData", "Contacts_Countries", "Countries")]
        public Countries Country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Countries>("ApplicationData.Contacts_Countries", "Countries").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Countries>("ApplicationData.Contacts_Countries", "Countries").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Countries> CountryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Countries>("ApplicationData.Contacts_Countries", "Countries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Countries>("ApplicationData.Contacts_Countries", "Countries", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ApplicationData", Name="ContactTypes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ContactTypes : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ContactTypes object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static ContactTypes CreateContactTypes(global::System.Int32 id, global::System.String name)
        {
            ContactTypes contactTypes = new ContactTypes();
            contactTypes.Id = id;
            contactTypes.Name = name;
            return contactTypes;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ApplicationData", "Contacts_ContactTypes", "Contacts")]
        public EntityCollection<Contacts> ContactsCollection
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Contacts>("ApplicationData.Contacts_ContactTypes", "Contacts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Contacts>("ApplicationData.Contacts_ContactTypes", "Contacts", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ApplicationData", Name="Countries")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Countries : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Countries object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Countries CreateCountries(global::System.Int32 id, global::System.String name)
        {
            Countries countries = new Countries();
            countries.Id = id;
            countries.Name = name;
            return countries;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ApplicationData", "Contacts_Countries", "Contacts")]
        public EntityCollection<Contacts> ContactsCollection
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Contacts>("ApplicationData.Contacts_Countries", "Contacts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Contacts>("ApplicationData.Contacts_Countries", "Contacts", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
