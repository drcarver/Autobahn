//**********************************************************
//* DomainName: Competencies
//* FileName:   CoreKnowledgeAreaViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CoreKnowledgeArea View Model
     /// </summary>
    public partial class CoreKnowledgeAreaViewModel : ViewModelBase, Interfaces.ICoreKnowledgeArea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CoreKnowledgeArea";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // RefCoreKnowledgeAreaId -- (backing property for Early Learning Core Knowledge Area)
        private Guid _RefCoreKnowledgeAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Early Learning Core Knowledge Area
        /// <para>
        /// A description of the core knowledge areas addressed by Early Learning professional development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19812">Early Learning Core Knowledge Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefCoreKnowledgeAreaId { get => _RefCoreKnowledgeAreaId; set => SetProperty(ref _RefCoreKnowledgeAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICoreKnowledgeArea model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
            RefCoreKnowledgeAreaId = model.RefCoreKnowledgeAreaId; // Early Learning Core Knowledge Area
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
