//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedBrailleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentNeedBraille Model
     /// </summary>
    public partial class AssessmentNeedBrailleModel : AutobahnBase, Interfaces.IAssessmentNeedBraille
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Decimal? BrailleDotPressure { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public System.Int32? NumberOfBrailleCells { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}
