//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentTypeChildrenWithDisability.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentTypeChildrenWithDisability Interface
     /// </summary>
    public partial interface IRefAssessmentTypeChildrenWithDisability : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        Guid RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    }
}
