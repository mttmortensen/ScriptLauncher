using System.Diagnostics;

namespace ScriptLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_EnabledADUSers(object sender, EventArgs e)
        {
            // 1. Create process settings 
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "powershell.exe";

            // 2. Script Path from OneDrive
            psi.Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"& 'C:\\Users\\mattm\\OneDrive - 4Life Research\\Documents\\Scripts\\CountUsers.ps1'\"";

            // 3. Quiet Execution (no black window pop up)
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            // 4. Capture any output or errors
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 5. Run the process 
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            // 6. Wait and capture the result
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();

            // 7. Show basic success or error message
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Error:\n {error}");

            }
            else
            {
                MessageBox.Show($"Done!\n {output}");
            }

        }
    }
}
