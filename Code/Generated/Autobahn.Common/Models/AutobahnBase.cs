using System.ComponentModel;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Base Model for Autobahn
     /// </summary>
    public partial class AutobahnBase : IAutobahnBase, IChangeTracking
    {
        // private field for IsChanged
        protected bool isChanged = false;

        /// <summary>
        /// THe Id of the ViewModel
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Accept changes to the model
        /// </summary>
        public virtual void AcceptChanges()
        {
            isChanged = true;
        }

        /// <summary>
        /// Has the ViewModelChanged?
        /// </summary>
        public bool IsChanged { get => isChanged; }

        /// <summary>
        /// Is it a new model?
        /// </summary>
        public bool IsNew { get; set; }
    }
}
