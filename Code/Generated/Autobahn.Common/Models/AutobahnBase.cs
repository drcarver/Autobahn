//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   AutobahnBase.cs
//**********************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Common.Models
{
    /// <summary>
    /// The Base Model for Autobahn
    /// </summary>
    public partial class AutobahnBase : IAutobahnBase
    {
        // private field for IsChanged
        protected bool _isChanged = false;

        /// <summary>
        /// THe Id of the ViewModel
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Accept changes to the model
        /// </summary>
        public virtual void AcceptChanges()
        {
            _isChanged = false;
            IsNew = false;
        }

        /// <summary>
        /// Has the ViewModelChanged?
        /// </summary>
        public bool IsChanged { get => _isChanged; }

        /// <summary>
        /// Is it a new model?
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
