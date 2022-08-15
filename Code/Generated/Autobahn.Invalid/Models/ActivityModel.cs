//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Activity Model
     /// </summary>
    public partial class ActivityModel : AutobahnBase, Interfaces.IActivity
    {
        /// <summary>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public System.String ActivityDescription { get; set; }

    }
}
