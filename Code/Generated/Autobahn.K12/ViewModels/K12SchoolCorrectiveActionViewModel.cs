//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolCorrectiveActionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolCorrectiveAction View Model
     /// </summary>
    public partial class K12SchoolCorrectiveActionViewModel : ViewModelBase, Interfaces.IK12SchoolCorrectiveAction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolCorrectiveAction";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // RefCorrectiveActionTypeId -- (backing property for Corrective Action Type)
        private Guid _RefCorrectiveActionTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12School"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Corrective Action Type
        /// <para>
        /// The types of corrective actions under ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19049">Corrective Action Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get => _RefCorrectiveActionTypeId; set => SetProperty(ref _RefCorrectiveActionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolCorrectiveAction model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId; // 
            RefCorrectiveActionTypeId = model.RefCorrectiveActionTypeId; // Corrective Action Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefCorrectiveActionType List
        /// <summary>
        /// The complete <see cref="RefCorrectiveActionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefCorrectiveActionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f424ddbb-316b-4e29-9312-8ac3eea25d71"), Code="CA1", Description="Required implementation of a new research-based curriculum or instructional program", Definition="A corrective action requiring implementation of a new research-based curriculum or instructional program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f57dfa3c-f2a8-4832-a901-980a982e439a"), Code="CA2", Description="Extension of the school year or school day ", Definition="A corrective action requiring extension of the school year or school day.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1439267e-5209-43fe-a6bf-6e98c54fdcc5"), Code="CA3", Description="Replacement of staff members relevant to the school's low performance", Definition="A corrective action requiring replacement of staff members relevant to the school's low performance.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("cf0acfe8-80d4-4e14-aa72-7428bac56cf0"), Code="CA4", Description="Significant decrease in management authority at the school level", Definition="A corrective action requiring significant decrease in management authority at the school level.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("a0f8ace1-db2a-4898-bd2f-69573ae3670f"), Code="CA5", Description="Replacement of the principal", Definition="A corrective action requiring replacement of the principal.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("f6b72598-887e-411a-930d-5f1c64cbfdb6"), Code="CA6", Description="Restructuring of the internal organization of the school", Definition="A corrective action requiring restructuring of the internal organization of the school.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("253626f6-b8ca-4919-a2ae-c793670368f8"), Code="CA7", Description="Appointment of an outside expert to advise the school", Definition="A corrective action requiring appointment of an outside expert to advise the school.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
