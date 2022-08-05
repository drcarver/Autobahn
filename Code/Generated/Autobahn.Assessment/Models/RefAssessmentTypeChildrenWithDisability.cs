//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentTypeChildrenWithDisability.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentTypeChildrenWithDisability Model
     /// </summary>
    public partial class RefAssessmentTypeChildrenWithDisability : ReferenceModelBase, IRefAssessmentTypeChildrenWithDisability
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        public Guid RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    }
}
