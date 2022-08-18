//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentActivityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentActivityView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentActivity View Model as the data context for the view
        /// </summary>
        public K12StudentActivityView(Interfaces.IK12StudentActivity vm)
        {
            BindingContext  = vm;
        }
    }
}
