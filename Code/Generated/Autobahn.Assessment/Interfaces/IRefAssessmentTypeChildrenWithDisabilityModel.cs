//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentTypeChildrenWithDisabilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentTypeChildrenWithDisability Interface Model
     /// </summary>
    public partial interface IRefAssessmentTypeChildrenWithDisabilityModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        Guid RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    }
}
