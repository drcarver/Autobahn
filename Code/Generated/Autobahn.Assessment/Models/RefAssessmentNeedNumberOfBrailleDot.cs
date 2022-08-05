//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedNumberOfBrailleDot.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentNeedNumberOfBrailleDot Model
     /// </summary>
    public partial class RefAssessmentNeedNumberOfBrailleDot : ReferenceModelBase, IRefAssessmentNeedNumberOfBrailleDot
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        public Guid RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

    }
}
