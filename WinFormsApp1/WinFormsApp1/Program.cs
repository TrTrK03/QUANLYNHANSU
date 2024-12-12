
//using WinFormsApp1.connect;

using WinFormsApp1.connect;
using WinFormsApp1.GUI;
using WinFormsApp1.Imports;


namespace WinFormsApp1
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new GUI.ForgetPassword());
            ketnoi cont = new ketnoi();
            cont.connection();
            cont.closeconect(cont.connection());
            //Import im = new Import();
            //im.indanhsach();


            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Login successful, proceed to the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}