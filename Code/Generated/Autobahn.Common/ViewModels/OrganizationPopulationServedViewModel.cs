//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServed View Model
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : ViewModelBase, Interfaces.IOrganizationPopulationServed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPopulationServed";

        // member variable for the AgeUnit property
        private System.String _AgeUnit;

        // OldestAgeServed -- (backing property for Early Learning Oldest Age Authorized to Serve)
        private System.Int32? _OldestAgeServed;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefPopulationServedId -- (backing property for Special Circumstances Population Served)
        private Guid? _RefPopulationServedId;

        // YoungestAgeServed -- (backing property for Early Learning Youngest Age Authorized to Serve)
        private System.Int32? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String AgeUnit { get => _AgeUnit; set => SetProperty(ref _AgeUnit, value); }

        /// <summary>
        /// Early Learning Oldest Age Authorized to Serve
        /// <para>
        /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Special Circumstances Population Served
        /// <para>
        /// Program provides services to meet the needs of children in special circumstances.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19852">Special Circumstances Population Served</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPopulationServedId { get => _RefPopulationServedId; set => SetProperty(ref _RefPopulationServedId, value); }

        /// <summary>
        /// Early Learning Youngest Age Authorized to Serve
        /// <para>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            AgeUnit = model.AgeUnit; // 
            OldestAgeServed = model.OldestAgeServed; // Early Learning Oldest Age Authorized to Serve
            OrganizationId = model.OrganizationId; // 
            RefPopulationServedId = model.RefPopulationServedId; // Special Circumstances Population Served
            YoungestAgeServed = model.YoungestAgeServed; // Early Learning Youngest Age Authorized to Serve
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPopulationServed List
        /// <summary>
        /// The complete <see cref="RefPopulationServed"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPopulationServedList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9759c552-ccfa-43a1-942b-5bab2f68c1c1"), Code="ELL", Description="English language learners", Definition="The program provides services to meet the needs of English language learners.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c26bf966-297b-4c4c-9b5b-bea1ed31fb4d"), Code="CWD", Description="Children with disabilities", Definition="The program provides services to meet the needs of children with disabilities.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2cb887d2-7101-4835-a212-97f36736b6ae"), Code="Homeless", Description="Homeless", Definition="The program provides services to meet the needs of homeless.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b2258193-878a-4a12-aa23-15a4c6878940"), Code="MentalHealth", Description="Mental health", Definition="The program provides mental health services.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("17be20f0-dc9f-4f4f-86ba-e8e64ac4900b"), Code="SpecialHealthNeeds", Description="Special health needs", Definition="The program provides services to meet the needs of learners with special health needs.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("42e5d4d9-ee25-44ab-ba68-0417ccd55fc5"), Code="Foster", Description="Foster", Definition="The program provides services to meet the needs of foster children and families.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("31761404-dc43-436c-b4a9-2c63a7e0104d"), Code="Other", Description="Other", Definition="The program provides services to meet the needs of learners in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion
    }
}
