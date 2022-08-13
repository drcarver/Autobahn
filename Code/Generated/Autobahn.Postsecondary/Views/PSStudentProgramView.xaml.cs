//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PSStudentProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PSStudentProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IPSStudentProgram View Model as the data context for the view
        /// </summary>
        public PSStudentProgramView(Interfaces.IPSStudentProgram vm)
        {
            BindingContext  = vm;
        }
    }
}
