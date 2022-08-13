//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicRecordView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentAcademicRecord View Model as the data context for the view
        /// </summary>
        public K12StudentAcademicRecordView(Interfaces.IK12StudentAcademicRecord vm)
        {
            BindingContext  = vm;
        }
    }
}
