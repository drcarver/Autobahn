//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentTypeChildrenWithDisabilityModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentTypeChildrenWithDisability Model
     /// </summary>
    public partial class RefAssessmentTypeChildrenWithDisabilityModel : ReferenceModelBase, IRefAssessmentTypeChildrenWithDisabilityModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        public Guid RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    }
}
