//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IEPPresentLevelModel.cs
//* Name:       IEP Present Level Academic Description
//* Definition: How the child's disability affects the child's academic achievement.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// How the child's disability affects the child's academic achievement.
     /// </summary>
    public partial class IEPPresentLevelModel : AutobahnBase, Interfaces.IIEPPresentLevel
    {
        /// <summary>
        /// IEP Present Level Academic Description
        /// <para>
        /// How the child's disability affects the child's academic achievement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20686">IEP Present Level Academic Description</a>
        /// </para>
        /// </summary>
        public System.String AcademicDescription { get; set; }

        /// <summary>
        /// IEP Present Level Functional Description
        /// <para>
        /// How the child's disability affects the child's functional performance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20687">IEP Present Level Functional Description</a>
        /// </para>
        /// </summary>
        public System.String FunctionalDescription { get; set; }

        /// <summary>
        /// IEP Present Level General Education Description
        /// <para>
        /// How the child's disability affects the child's involvement and progress in the general education curriculum.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20688">IEP Present Level General Education Description</a>
        /// </para>
        /// </summary>
        public System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// IEP Present Level Parent Concern Description
        /// <para>
        /// Parent's explanation of their interest in or concerns about the student's participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20691">IEP Present Level Parent Concern Description</a>
        /// </para>
        /// </summary>
        public System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// IEP Present Level Preschool Description
        /// <para>
        /// For preschool children, as appropriate, how the disability affects the child's participation in appropriate activities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20689">IEP Present Level Preschool Description</a>
        /// </para>
        /// </summary>
        public System.String PreschoolDescription { get; set; }

        /// <summary>
        /// IEP Present Level Student Concern Description
        /// <para>
        /// Student's explanation of his or her interest in or concerns about participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20692">IEP Present Level Student Concern Description</a>
        /// </para>
        /// </summary>
        public System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// IEP Present Level Student Strengths Description
        /// <para>
        /// Explanation of perceived strengths and abilities of the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20690">IEP Present Level Student Strengths Description</a>
        /// </para>
        /// </summary>
        public System.String StudentStrengthsDescription { get; set; }

    }
}
