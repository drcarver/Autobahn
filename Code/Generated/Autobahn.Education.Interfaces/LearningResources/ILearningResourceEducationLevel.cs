//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceEducationLevel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.LearningResources
{
     /// <summary>
     /// The ILearningResourceEducationLevel Interface
     /// </summary>
    public partial interface ILearningResourceEducationLevel : IAutobahnBase
    {
        #region ILearningResourceEducationLevel
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Learning Resource Education Level�
        /// <para>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
        /// </para>
        /// </summary>
        Guid RefEducationLevelId { get; set; }

        #endregion
    }
}
