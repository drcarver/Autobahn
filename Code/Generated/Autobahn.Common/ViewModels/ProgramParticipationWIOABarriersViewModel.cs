//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOABarriersViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOABarriers View Model
     /// </summary>
    public partial class ProgramParticipationWIOABarriersViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOABarriers
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOABarriers";

        // member variable for the ProgramParticipationWIOAId property
        private Guid _ProgramParticipationWIOAId;

        // RefWIOABarrierstoEmploymentId -- (backing property for WIOA Barriers to Employment)
        private Guid? _RefWIOABarrierstoEmploymentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProgramParticipationWIOA"/> model
        /// </summary>
        public Guid ProgramParticipationWIOAId { get => _ProgramParticipationWIOAId; set => SetProperty(ref _ProgramParticipationWIOAId, value); }

        /// <summary>
        /// WIOA Barriers to Employment
        /// <para>
        /// A self-identified barrier as defined by the Workforce Innovation and Opportunity Act (WIOA) that is presumed to affect placement of a participant in unsubsidized employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20969">WIOA Barriers to Employment</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWIOABarrierstoEmploymentId { get => _RefWIOABarrierstoEmploymentId; set => SetProperty(ref _RefWIOABarrierstoEmploymentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOABarriers model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgramParticipationWIOAId = model.ProgramParticipationWIOAId; // 
            RefWIOABarrierstoEmploymentId = model.RefWIOABarrierstoEmploymentId; // WIOA Barriers to Employment
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefWIOABarrierstoEmployment List
        /// <summary>
        /// The complete <see cref="RefWIOABarrierstoEmployment"> List
        /// </summary>
        private static List<ReferenceModelBase> RefWIOABarrierstoEmploymentList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d6129801-fafe-4989-bf09-f7f03bdd9fe1"), Code="805", Description="Cultural barriers", Definition="The participant has a perception of him-or herself as possessing attitudes, beliefs, customs, or practices that influence a way of thinking, acting, or working that may serve as a hindrance to employment.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("552df585-634e-4dca-84b3-722704151a7f"), Code="807", Description="Displaced homemaker", Definition="The participant has been providing unpaid services to family members in the home and (a) has been dependent on the income of another family member but is no longer supported by that income; (b) is the dependent spouse of a member of the armed forces on active duty whose family income is significantly reduced because of (i) a deployment or a call or order to active duty pursuant to a provision of law, (ii) a permanent change of station, or (iii) the service-connected death or disability of the member; and (c) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b3630fe-f03b-47ac-b1c3-ac9abdd70f06"), Code="803", Description="English language learner", Definition="The participant has limited ability in speaking, reading, writing, or understanding the English language that may serve as a hindrance to employment.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("87b54924-62c4-4efd-9ce4-5313df6de632"), Code="601", Description="Exhausting Temporary Assistance for Needy Families (TANF) within 2 years", Definition="The participant is within 2 years of exhausting lifetime eligibility under Part A of Title IV of the Social Security Act (42 U.S.C. 601 et seq.), regardless of whether he or she is receiving these benefits at program entry.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("dea1f320-5035-431e-8e42-4ae60ca69036"), Code="801", Description="Ex-offender", Definition="The participant is a person who either (a) has been subject to any stage of the criminal justice process for committing a status offense or delinquent act, or (b) requires assistance in overcoming barriers to employment resulting from a record of arrest or conviction.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("06222a4e-ea7b-45d4-9011-21e4758a7921"), Code="800", Description="Homeless or runaway youth", Definition="The participant lacks a fixed, regular, and adequate nighttime residence; has a primary nighttime residence that is a public or private place not designed for or ordinarily used as a regular sleeping accommodation for human beings; is a migratory child who in the preceding 36 months was required to move from one school district to another due to changes in the parent's or parent's spouse's seasonal employment in agriculture, dairy, or fishing work; or is under 18 years of age and absents himself or herself from home or place of legal residence without the permission of his or her family (i.e., runaway youth). However, a participant who may be sleeping in a temporary accommodation while away from home should not, as a result of that fact alone, be recorded as homeless.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("71aaa5f7-fda9-40aa-a946-b76928ba8a01"), Code="202", Description="Individual with disabilities", Definition="The participant indicates that he or she has a disability, defined as a physical or mental impairment, that substantially limits one or more of the person's major life activities, as defined under the Americans with Disabilities Act of 1990.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf4948ff-3c79-4655-b175-2781c9742ad3"), Code="402", Description="Long-term unemployed", Definition="The participant has been unemployed for 27 or more consecutive weeks.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc4294f3-3fef-4b47-9329-d6e48a96232f"), Code="804", Description="Low literacy level", Definition="The participant has an inability to compute and solve problems or read, write, or speak English at a level necessary to function on the job, in the participant's family, or in society, which may serve as a hindrance to employment.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("a4cda080-c2d1-4622-ad62-e8d66316ff55"), Code="802", Description="Low-income", Definition="The participant (a) receives, or in the 6 months prior to application to the program has received, or is a member of a family that is receiving in the past 6 months assistance through the Supplemental Nutrition Assistance Program (SNAP), the TANF program, the Supplemental Security Income (SSI) program, or State or local income-based public assistance; (b) is in a family with total family income that does not exceed the higher of the poverty line or 70% of the lower living standard income level; (c) is a youth who receives, or is eligible to receive, a free or reduced-price lunch; (d) is a foster child on behalf of whom State or local government payments are made; (e) is a participant with a disability whose own income is the poverty line but who is a member of a family whose income does not meet this requirement; (f) is a homeless participant or homeless child or youth or runaway youth; or (g) is a youth living in a high-poverty area.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5f1580b-8266-4f26-b275-e89fd90caeb7"), Code="808", Description="Migrant and seasonal farmworker", Definition="The participant is a low-income individual who for 12 consecutive months out of the 24 months prior to application for the program involved has been primarily employed in agriculture or fish farming labor that is characterized by chronic unemployment or underemployment, and faces multiple barriers to economic self-sufficiency.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("b83c8521-b159-4d5c-8343-211cf8d2327a"), Code="806", Description="Single parent", Definition="The participant is a single, separated, divorced, or widowed individual who has primary responsibility for one or more dependent children under age 18 (including single pregnant women).", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("3eb07ab0-992f-4c0b-94e9-42836a698ad0"), Code="704", Description="Youth in foster care or who has aged out of system", Definition="The participant is a person who is currently in foster care or has aged out of the foster care system.", SortOrder=Convert.ToDecimal("13.00") },
        };
        #endregion
    }
}
