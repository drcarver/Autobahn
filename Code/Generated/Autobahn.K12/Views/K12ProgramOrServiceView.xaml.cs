//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12ProgramOrServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12ProgramOrServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IK12ProgramOrService View Model as the data context for the view
        /// </summary>
        public K12ProgramOrServiceView(Interfaces.IK12ProgramOrService vm)
        {
            BindingContext  = vm;
        }
    }
}
