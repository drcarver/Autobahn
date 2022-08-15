//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipContent Model
     /// </summary>
    public partial class AssessmentNeedApipContentModel : AutobahnBase, Interfaces.IAssessmentNeedApipContent
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

    }
}
