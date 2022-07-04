using DataAccess.MemberRepository;

namespace MyStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MemberRepository repository = new MemberRepository();
            //Mai Quang Khai
            repository.InitAdmin();
            Application.Run(new frmLogin());            
        }
    }
}