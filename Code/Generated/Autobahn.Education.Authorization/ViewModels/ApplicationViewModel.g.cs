//**********************************************************
//* DomainName: Information used by an application or service that authenticates the identity of a person or authorizes a person’s access to information or services.
//* FileName:   ApplicationViewModel.g.cs
//*
//* This code was generated by a tool.  Do not
//* modify this file!  Instead modify the
//* ApplicationViewModel.cs file
//***************************************************************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Autobahn.Education.Interfaces.Common;
using Autobahn.Education.Interfaces.Authorization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Autobahn.Education.Authorization.ViewModels
{
     /// <summary>
     /// The Application View Model
     /// </summary>
    public partial class ApplicationViewModel : ObservableValidator, IApplication
    {
        #region "ApplicationViewModel Constructor"
        /// </summary>
        /// The service provider instance.
        /// <summary>
        private System.IServiceProvider serviceProvider;

        /// <summary>
        /// ApplicationViewModel Constructor
        /// </summary>
        public ApplicationViewModel(System.IServiceProvider provider)
        {
            serviceProvider = provider;
            OnApplicationViewModelConstruction();
        }

        /// <summary>
        /// ApplicationViewModel Constructor partial method
        /// <para>
        /// This method is called by the view model constructor
        /// to allow the inclusion of custom processing in
        /// the view models construction
        /// </para>
        /// </summary>
        public partial void OnApplicationViewModelConstruction();
        #endregion"

        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string viewTitle = "Hello from Application";

        // The isNew property is set if the view model has been created but not saved to the database
        private bool isNew = false;

        /// The isDeleted property is set if the view model is to be deleted from the database
        private bool isDeleted = false;

        /// The view model is changed and needs to be save to the database.
        public bool isChanged = false;

        /// The view model is performing a long running task
        public bool isBusy = false;

        // Name -- (backing property for Authorization Application Name)
        private System.String name;

        // Uri -- (backing property for Authorization Application URI)
        private System.String uri;

        #endregion

        #region "IAutobahnBase Properties"
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

        /// <summary>
        /// The IsNew property is set if the view model has been created but not saved to the database
        /// </summary>
        public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

        /// <summary>
        /// The IsDeleted property is set if the view model is to be delted from the database
        /// </summary>
        public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

        /// <summary>
        /// The primary key of the view model
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// The view model is changed and needs to be save to the database.
        /// </summary>
        public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

        /// <summary>
        /// The view model is performing a long running task
        /// </summary>
        public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

        /// <summary>
        /// The view model's changes have been save so update its tracking properties
        /// </summary>
        public void AcceptChanges()
        {
            IsNew = false;
            IsChanged = false;
        }
        #endregion

        #region "IApplication Properties"
        /// <summary>
        /// Authorization Application Name
        /// <para>
        /// The name of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20127">Authorization Application Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Authorization Application Name")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(120,ErrorMessage="The {0} must be less then {1} characters.")]
        public System.String Name { get => name; set => SetProperty(ref name, value, true); }

        /// <summary>
        /// Authorization Application URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20128">Authorization Application URI</a>
        /// </para>
        /// </summary>
        [DisplayName("Authorization Application URI")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
        public System.String Uri { get => uri; set => SetProperty(ref uri, value, true); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // Authorization Application Name
            Uri = model.Uri; // Authorization Application URI
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
