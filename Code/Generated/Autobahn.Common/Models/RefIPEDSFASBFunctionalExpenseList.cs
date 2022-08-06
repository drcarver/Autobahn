//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBFunctionalExpenseList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSFASBFunctionalExpense Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSFASBFunctionalExpense"> List
         /// </summary>
        public static List<RefIPEDSFASBFunctionalExpense> RefIPEDSFASBFunctionalExpenseList = new List<RefIPEDSFASBFunctionalExpense> =
        {
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("7758cb57-15e2-4416-a717-0d51c8923b2b"), Code="A functional expense category that includes expenses of activities and services that support the institution's primary missions of instruction, research, and public service. It includes the retention, preservation, and display of educational materials (for example, libraries, museums, and galleries); organized activities that provide support services to the academic functions of the institution (such as a demonstration school associated with a college of education or veterinary and dental clinics if their primary purpose is to support the instructional program); media such as audiovisual services; academic administration (including academic deans but not department chairpersons); and formally organized and separately budgeted academic personnel development and course and curriculum development expenses. Also included are information technology expenses related to academic support activities; if an institution does not separately budget and expense information technology resources, the costs associated with the three primary programs will be applied to this function and the remainder to institutional support. Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", Description="Academicsupport", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("9297fa31-bad3-4374-aa46-3cde2f1b7411"), Code="Expenses for essentially self-supporting operations of the institution that exist to furnish a service to students, faculty, or staff, and that charge a fee that is directly related to, although not necessarily equal to, the cost of the service. Examples are residence halls, food services, student health services, intercollegiate athletics (only if essentially self-supporting), college unions, college stores, faculty and staff parking, and faculty housing. Institutions include actual or allocated costs for operation and maintenance of plant, interest and depreciation.", Description="Auxiliaryenterprises", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("ebb4171b-4a8f-48ad-b15a-da5c47fbd58c"), Code="Expenses associated with a hospital operated by the postsecondary institution (but not as a component unit) and reported as a part of the institution. This classification includes nursing expenses, other professional services, general services, administrative services, and fiscal services. Also included are information technology expenses, actual or allocated costs for operation and maintenance of plant, interest and depreciation related to hospital capital assets.", Description="Hospitalservices", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("1cb0c799-0350-40b3-a211-da8d6407ca60"), Code="Expenses associated with operations that are independent of or unrelated to the primary missions of the institution (i.e., instruction, research, public service) although they may contribute indirectly to the enhancement of these programs. This category is generally limited to expenses of a major federally funded research and development center. Also includes information technology expenses, actual or allocated costs for operation and maintenance of plant, interest and depreciation related to the independent operations. Expenses of operations owned and managed as investments of the institution's endowment funds are excluded.", Description="Independentoperations", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("c13a4263-caa0-4587-884b-fd5a3389587d"), Code="A functional expense category that includes expenses for the day-to-day operational support of the institution. Includes expenses for general administrative services, central executive-level activities concerned with management and long range planning, legal and fiscal operations, space management, employee personnel and records, logistical services such as purchasing and printing, and public relations and development. Also includes information technology expenses related to institutional support activities. If an institution does not separately budget and expense information technology resources, the IT costs associated with student services and operation and maintenance of plant will also be applied to this function.", Description="Institutionalsupport", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("a666c38d-e7ab-40ab-b66d-d1d69b51fb15"), Code="A functional expense category that includes expenses of the colleges, schools, departments, and other instructional divisions of the institution and expenses for departmental research and public service that are not separately budgeted. Includes general academic instruction, occupational and vocational instruction, community education, preparatory and adult basic education, and regular, special, and extension sessions. Also includes expenses for both credit and non-credit activities. Excludes expenses for academic administration where the primary function is administration (e.g., academic deans). Information technology expenses related to instructional activities if the institution separately budgets and expenses information technology resources are included (otherwise these expenses are included in academic support). Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", Description="Instruction", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("5b540921-71d8-4742-887e-f336c57470ad"), Code="The portion of scholarships and fellowships granted by an institution that exceeds the amount applied to institutional charges such as tuition and fees or room and board. The amount reported as expense excludes allowances.", Description="Netgrantaidtostudents", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("02b59954-c05c-43bd-8788-20d8e73ea893"), Code="", Description="Other", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("26e00fce-02b9-4990-9b2b-9225ac882101"), Code="A functional expense category that includes expenses for activities established primarily to provide noninstructional services beneficial to individuals and groups external to the institution. Examples are conferences, institutes, general advisory service, reference bureaus, and similar services provided to particular sectors of the community. This function includes expenses for community services, cooperative extension services, and public broadcasting services. Also includes information technology expenses related to the public service activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in academic support). Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", Description="Publicservice", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("bcb73169-fce4-48f4-9f7b-158b47e1949f"), Code="A functional expense category that includes expenses for activities specifically organized to produce research outcomes and commissioned by an agency either external to the institution or separately budgeted by an organizational unit within the institution. The category includes institutes and research centers, and individual and project research. This function does not include nonresearch sponsored programs (e.g., training programs). Also included are information technology expenses related to research activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in academic support.) Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", Description="Research", Definition="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("11d6cf43-e088-48ab-b838-021457f6b0fc"), Code="A functional expense category that includes expenses for admissions, registrar activities, and activities whose primary purpose is to contribute to students emotional and physical well-being and to their intellectual, cultural, and social development outside the context of the formal instructional program. Examples include student activities, cultural events, student newspapers, intramural athletics, student organizations, supplemental instruction outside the normal administration, and student records. Intercollegiate athletics and student health services may also be included except when operated as self-supporting auxiliary enterprises. Also may include information technology expenses related to student service activities if the institution separately budgets and expenses information technology resources(otherwise these expenses are included in institutional support.) Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", Description="Studentservices", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIPEDSFASBFunctionalExpense Pick List
         /// </summary>
        public static List<RefIPEDSFASBFunctionalExpense> RefIPEDSFASBFunctionalExpensePickList = new List<RefIPEDSFASBFunctionalExpense> =
        {
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("7758cb57-15e2-4416-a717-0d51c8923b2b"), Code="A functional expense category that includes expenses of activities and services that support the institution's primary missions of instruction, research, and public service. It includes the retention, preservation, and display of educational materials (for example, libraries, museums, and galleries); organized activities that provide support services to the academic functions of the institution (such as a demonstration school associated with a college of education or veterinary and dental clinics if their primary purpose is to support the instructional program); media such as audiovisual services; academic administration (including academic deans but not department chairpersons); and formally organized and separately budgeted academic personnel development and course and curriculum development expenses. Also included are information technology expenses related to academic support activities; if an institution does not separately budget and expense information technology resources, the costs associated with the three primary programs will be applied to this function and the remainder to institutional support. Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("9297fa31-bad3-4374-aa46-3cde2f1b7411"), Code="Expenses for essentially self-supporting operations of the institution that exist to furnish a service to students, faculty, or staff, and that charge a fee that is directly related to, although not necessarily equal to, the cost of the service. Examples are residence halls, food services, student health services, intercollegiate athletics (only if essentially self-supporting), college unions, college stores, faculty and staff parking, and faculty housing. Institutions include actual or allocated costs for operation and maintenance of plant, interest and depreciation.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("ebb4171b-4a8f-48ad-b15a-da5c47fbd58c"), Code="Expenses associated with a hospital operated by the postsecondary institution (but not as a component unit) and reported as a part of the institution. This classification includes nursing expenses, other professional services, general services, administrative services, and fiscal services. Also included are information technology expenses, actual or allocated costs for operation and maintenance of plant, interest and depreciation related to hospital capital assets.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("1cb0c799-0350-40b3-a211-da8d6407ca60"), Code="Expenses associated with operations that are independent of or unrelated to the primary missions of the institution (i.e., instruction, research, public service) although they may contribute indirectly to the enhancement of these programs. This category is generally limited to expenses of a major federally funded research and development center. Also includes information technology expenses, actual or allocated costs for operation and maintenance of plant, interest and depreciation related to the independent operations. Expenses of operations owned and managed as investments of the institution's endowment funds are excluded.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("c13a4263-caa0-4587-884b-fd5a3389587d"), Code="A functional expense category that includes expenses for the day-to-day operational support of the institution. Includes expenses for general administrative services, central executive-level activities concerned with management and long range planning, legal and fiscal operations, space management, employee personnel and records, logistical services such as purchasing and printing, and public relations and development. Also includes information technology expenses related to institutional support activities. If an institution does not separately budget and expense information technology resources, the IT costs associated with student services and operation and maintenance of plant will also be applied to this function.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("a666c38d-e7ab-40ab-b66d-d1d69b51fb15"), Code="A functional expense category that includes expenses of the colleges, schools, departments, and other instructional divisions of the institution and expenses for departmental research and public service that are not separately budgeted. Includes general academic instruction, occupational and vocational instruction, community education, preparatory and adult basic education, and regular, special, and extension sessions. Also includes expenses for both credit and non-credit activities. Excludes expenses for academic administration where the primary function is administration (e.g., academic deans). Information technology expenses related to instructional activities if the institution separately budgets and expenses information technology resources are included (otherwise these expenses are included in academic support). Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("5b540921-71d8-4742-887e-f336c57470ad"), Code="The portion of scholarships and fellowships granted by an institution that exceeds the amount applied to institutional charges such as tuition and fees or room and board. The amount reported as expense excludes allowances.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("02b59954-c05c-43bd-8788-20d8e73ea893"), Code="", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("26e00fce-02b9-4990-9b2b-9225ac882101"), Code="A functional expense category that includes expenses for activities established primarily to provide noninstructional services beneficial to individuals and groups external to the institution. Examples are conferences, institutes, general advisory service, reference bureaus, and similar services provided to particular sectors of the community. This function includes expenses for community services, cooperative extension services, and public broadcasting services. Also includes information technology expenses related to the public service activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in academic support). Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("bcb73169-fce4-48f4-9f7b-158b47e1949f"), Code="A functional expense category that includes expenses for activities specifically organized to produce research outcomes and commissioned by an agency either external to the institution or separately budgeted by an organizational unit within the institution. The category includes institutes and research centers, and individual and project research. This function does not include nonresearch sponsored programs (e.g., training programs). Also included are information technology expenses related to research activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in academic support.) Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", SortOrder=0 },
            new RefIPEDSFASBFunctionalExpense { Id=Guid.Parse("11d6cf43-e088-48ab-b838-021457f6b0fc"), Code="A functional expense category that includes expenses for admissions, registrar activities, and activities whose primary purpose is to contribute to students emotional and physical well-being and to their intellectual, cultural, and social development outside the context of the formal instructional program. Examples include student activities, cultural events, student newspapers, intramural athletics, student organizations, supplemental instruction outside the normal administration, and student records. Intercollegiate athletics and student health services may also be included except when operated as self-supporting auxiliary enterprises. Also may include information technology expenses related to student service activities if the institution separately budgets and expenses information technology resources(otherwise these expenses are included in institutional support.) Institutions include actual or allocated costs for operation and maintenance of plant, interest, and depreciation.", SortOrder=0 },
       };
   }
}
