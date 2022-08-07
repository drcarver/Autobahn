//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicRecordView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentAcademicRecordView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentAcademicRecordView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentAcademicRecordViewModel as the data context for the view
        /// </summary>
        public K12StudentAcademicRecordView(IK12StudentAcademicRecordViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
