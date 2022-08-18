//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentModel.cs
//* Name:       Annual Base Contractual Salary
//* Definition: The total annual base contractual salary of a person.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The total annual base contractual salary of a person.
     /// </summary>
    public partial class PsStaffEmploymentModel : AutobahnBase, Interfaces.IPsStaffEmployment
    {
        /// <summary>
        /// Annual Base Contractual Salary
        /// <para>
        /// The total annual base contractual salary of a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19722">Annual Base Contractual Salary</a>
        /// </para>
        /// </summary>
        public System.Decimal? AnnualBaseContractualSalary { get; set; }

        /// <summary>
        /// Faculty Status
        /// <para>
        /// Persons identified by the institution as such and typically those whose initial assignments are made for the purpose of conducting instruction, research or public service as a principal activity (or activities). They may hold academic rank titles of professor, associate professor, assistant professor, instructor, lecturer or the equivalent of any of those academic ranks. Faculty may also include the chancellor/president, provost, vice provosts, deans, directors or the equivalent, as well as associate deans, assistant deans and executive officers of academic departments (chairpersons, heads or the equivalent) if their principal activity is instruction combined with research and/or public service. The designation as "faculty" is separate from the activities to which they may be currently assigned. For example, a newly appointed president of an institution may also be appointed as a faculty member. Graduate, instruction, and research assistants are not included in this category.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19711">Faculty Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? FacultyStatus { get; set; }

        /// <summary>
        /// Graduate Assistant Status
        /// <para>
        /// Graduate-level students employed on a part-time basis, not limited to, but often employed for the primary purpose of assisting in classroom or laboratory instruction or in the conduct of research.  Graduate students having titles such as graduate assistant, teaching assistant, teaching associate, teaching fellow, or research assistant typically hold these positions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19720">Graduate Assistant Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? GraduateAssistantStatus { get; set; }

        /// <summary>
        /// Instructional Staff Status
        /// <para>
        /// Staff whose primary function/occupational activity is primarily instruction or instruction combined with research and/or public service.  Does not include medical school staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19709">Instructional Staff Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? InstructionalStaffStatus { get; set; }

        /// <summary>
        /// Medical School Staff Status
        /// <para>
        /// Staff employed by or employees working in the medical school component of a postsecondary institution or in a free standing medical school.  Does not include staff employed by or employees working strictly in a hospital associated with a medical school or those who work in health or allied health schools or departments such as dentistry, veterinary medicine, nursing or dental hygiene.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19710">Medical School Staff Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? MedicalSchoolStaffStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicRank"/> model
        /// </summary>
        public Guid? RefAcademicRankId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentContractType"/> model
        /// </summary>
        public Guid? RefEmploymentContractTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        public Guid? RefFullTimeStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGraduateAssistantIpedsCategory"/> model
        /// </summary>
        public Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffContractLength"/> model
        /// </summary>
        public Guid? RefInstructionalStaffContractLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionalStaffFacultyTenure"/> model
        /// </summary>
        public Guid? RefInstructionalStaffFacultyTenureId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionCreditType"/> model
        /// </summary>
        public Guid? RefInstructionCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// </summary>
        public Guid? RefIpedsOccupationalCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

    }
}
