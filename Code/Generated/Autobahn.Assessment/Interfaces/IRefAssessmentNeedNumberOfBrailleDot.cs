//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentNeedNumberOfBrailleDot.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentNeedNumberOfBrailleDot Interface
     /// </summary>
    public partial interface IRefAssessmentNeedNumberOfBrailleDot : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        Guid RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

    }
}
