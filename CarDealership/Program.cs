using CarDealership.Forms;

namespace CarDealership
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Cars());
        }
    }
}