//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEmploymentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentEmployment View Model as the data context for the view
        /// </summary>
        public K12StudentEmploymentView(Interfaces.IK12StudentEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}
