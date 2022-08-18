//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceFrequencyViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceFrequency View Model
     /// </summary>
    public partial class ServiceFrequencyViewModel : ViewModelBase, Interfaces.IServiceFrequency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceFrequency";

        // DurationInMinutes -- (backing property for Duration Length in Minutes)
        private System.Int32? _DurationInMinutes;

        // FrequencyLength -- (backing property for Frequency Length)
        private System.Int32? _FrequencyLength;

        // InstancesPerCycle -- (backing property for Frequency Instances Per Cycle)
        private System.Int32? _InstancesPerCycle;

        // RefFrequencyUnitId -- (backing property for Frequency Unit)
        private Guid? _RefFrequencyUnitId;

        // member variable for the ServicePlanId property
        private Guid _ServicePlanId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Duration Length in Minutes
        /// <para>
        /// The number of minutes in an instance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20697">Duration Length in Minutes</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? DurationInMinutes { get => _DurationInMinutes; set => SetProperty(ref _DurationInMinutes, value); }

        /// <summary>
        /// Frequency Length
        /// <para>
        /// The number of units within a repeating cycle. Used with Frequency and Frequency Units elements to describe the occurrence of repeating events such as student services delivered 3 times a week for 16 weeks.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20696">Frequency Length</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? FrequencyLength { get => _FrequencyLength; set => SetProperty(ref _FrequencyLength, value); }

        /// <summary>
        /// Frequency Instances Per Cycle
        /// <para>
        /// The number of recurrences within a cycle.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20695">Frequency Instances Per Cycle</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InstancesPerCycle { get => _InstancesPerCycle; set => SetProperty(ref _InstancesPerCycle, value); }

        /// <summary>
        /// Frequency Unit
        /// <para>
        /// The unit of time by which a cycle is defined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFrequencyUnitId { get => _RefFrequencyUnitId; set => SetProperty(ref _RefFrequencyUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicePlan"/> model
        /// </summary>
        public Guid ServicePlanId { get => _ServicePlanId; set => SetProperty(ref _ServicePlanId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceFrequency model)
        {
            IsBusy = true;
            Id = model.Id;
            DurationInMinutes = model.DurationInMinutes; // Duration Length in Minutes
            FrequencyLength = model.FrequencyLength; // Frequency Length
            InstancesPerCycle = model.InstancesPerCycle; // Frequency Instances Per Cycle
            RefFrequencyUnitId = model.RefFrequencyUnitId; // Frequency Unit
            ServicePlanId = model.ServicePlanId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
