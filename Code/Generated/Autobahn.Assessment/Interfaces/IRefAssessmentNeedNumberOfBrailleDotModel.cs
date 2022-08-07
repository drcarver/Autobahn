//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentNeedNumberOfBrailleDotModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentNeedNumberOfBrailleDot Interface Model
     /// </summary>
    public partial interface IRefAssessmentNeedNumberOfBrailleDotModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        Guid RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

    }
}
