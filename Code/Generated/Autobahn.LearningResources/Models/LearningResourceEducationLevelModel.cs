//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelModel.cs
//***************************************************************************

using Autobahn.Interfaces.LearningResources;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceEducationLevel Model
     /// </summary>
    public partial class LearningResourceEducationLevelModel : AutobahnBase, ILearningResourceEducationLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Learning Resource Education Level�
        /// <para>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
        /// </para>
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

    }
}
