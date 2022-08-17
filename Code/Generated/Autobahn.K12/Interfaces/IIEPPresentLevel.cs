//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IIEPPresentLevel.cs
//* Name:       IEP Present Level Academic Description
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IIEPPresentLevel : IAutobahnBase
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
        System.String AcademicDescription { get; set; }

        /// <summary>
        /// IEP Present Level Functional Description
        /// <para>
        /// How the child's disability affects the child's functional performance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20687">IEP Present Level Functional Description</a>
        /// </para>
        /// </summary>
        System.String FunctionalDescription { get; set; }

        /// <summary>
        /// IEP Present Level General Education Description
        /// <para>
        /// How the child's disability affects the child's involvement and progress in the general education curriculum.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20688">IEP Present Level General Education Description</a>
        /// </para>
        /// </summary>
        System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// IEP Present Level Parent Concern Description
        /// <para>
        /// Parent's explanation of their interest in or concerns about the student's participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20691">IEP Present Level Parent Concern Description</a>
        /// </para>
        /// </summary>
        System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// IEP Present Level Preschool Description
        /// <para>
        /// For preschool children, as appropriate, how the disability affects the child's participation in appropriate activities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20689">IEP Present Level Preschool Description</a>
        /// </para>
        /// </summary>
        System.String PreschoolDescription { get; set; }

        /// <summary>
        /// IEP Present Level Student Concern Description
        /// <para>
        /// Student's explanation of his or her interest in or concerns about participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20692">IEP Present Level Student Concern Description</a>
        /// </para>
        /// </summary>
        System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// IEP Present Level Student Strengths Description
        /// <para>
        /// Explanation of perceived strengths and abilities of the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20690">IEP Present Level Student Strengths Description</a>
        /// </para>
        /// </summary>
        System.String StudentStrengthsDescription { get; set; }

    }
}
