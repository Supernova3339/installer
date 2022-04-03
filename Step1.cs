using System; // rootkit
using System.Collections.Generic; // your collection of stuff
using System.ComponentModel; // sexy sex
using System.Data; // i collect dog photos
using System.Drawing; // draw the size of your dick. Wait, you dont have one!
using System.Linq; // gaybuilt prob used this when he claimed he bought google
using System.Text; // how 2 write sexy movie with 20 charachters
using System.Threading.Tasks; // we're not making a fuzzy sweatshirt now are we?
using System.Windows.Forms; // google forms reference wtf
using System.Net; // ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ wtf stop coming ඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞඞ
using System.Diagnostics; // swipe a card in a d m i n for the co.ol 69
using System.IO.Compression; // my ass 
using System.IO; // i fuck you :O
using System.Runtime.InteropServices; // interop services? more like interop susverses ඞ - okay please dont kill me let my family go im so sorry please let them go please please please please please please please please please please please please please
using System.Threading; // thread a needle in your balls

namespace SuperMailInstaller_BootStrapper
{
    public partial class Step1 : Form // ඞ
    {
        [DllImport("user32")] // 32 - 32 = 0, theres the equation to find out how many girlfriends you have
        private static extern bool SetForegroundWindow(IntPtr hwnd); // stuff to make sure it only does one program window
        [DllImport("user32")]// 32 x 0 = girlfriendCount
        private static extern bool ShowWindowAsync(IntPtr hwnd, int a); // same thing lol what did you expect
        WebClient wc = new WebClient(); // create new webclient

        public Step1() // step 2
        {
            InitializeComponent();
            // nasa.hack("fbi.gov);
        }

        private void Step1_Load(object sender, EventArgs e) // e a s p o r t s
        {
            this.Text = "SuperMail Installer - Bootstrapping"; // turtles
            string folderPath = @"C:\temp"; // temp folder
            if (!Directory.Exists(folderPath)) // del extracted folder if it alr exists - requires: not dumbass - how2earn: dont modify this line of code ඞ
            {
                Directory.CreateDirectory(folderPath);
            }

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) // check if your wifi is working
            {
                using (System.Net.WebClient client = new System.Net.WebClient()) //  open connection to hack you
                {
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted); // downloaded file completed event
                    Uri url = new Uri("http://dl.supers0ft.us/supermail/supermailsetup.zip"); // url to download from, must be a direct URL
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted); // same shit as it doesnt work unless I call it twice 
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged); // dumbass detector 3000
                    wc.DownloadFileAsync(url, "C:/temp/supermailsetup.zip"); // path to extract zip file to, it creates folder automatically
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e) // send cat pics: noreply@google.com
        {
            progressBar.Value = e.ProgressPercentage; // track download percentage, the longer your download takes the longer this takes to move
        }

        private async void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e) // once download completes, this string of code is fired
        {
            this.Text = "SuperMail Installer - Launching";
            string zipFilePath = @"C:\temp\supermailsetup.zip"; // path your downloaded zip file is (cant be anything else)
            string extractionPath = @"C:\temp\inst"; // folder it extracts to 
            if (Directory.Exists(extractionPath)) // check if folder exists
                Directory.Delete(extractionPath, true); // if folder exists delete it
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath); // extract the file
            System.Diagnostics.Process.Start(@"C:\temp\inst\supermailinstall.exe"); // run the file
            Application.Exit();
        }
    }
}

// holy shit who is this sexy beast - supernova#1388 - superdev.one - dm me if you need help with setup, this can be used on any windows program, android, ios, mac, and linux is NOT supported - hi jigsaw :)