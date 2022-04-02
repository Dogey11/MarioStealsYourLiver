using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;
using Browser;

namespace Mario
{
    public partial class Form1 : Form
    {
        public bool accepted = false;

        public string LocalAppData()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        }

        public void MarioFolderParent()
        {
            string dogey11 = $"{LocalAppData()}\\Dogey11";
            if (!Directory.Exists(dogey11))
            {
                Directory.CreateDirectory(dogey11);
            }
        }

        public bool MarioFolder()
        {
            string mario = $"{LocalAppData()}\\Dogey11\\Mario";
            bool exists;
            if (!Directory.Exists(mario))
            {
                Directory.CreateDirectory(mario);
                exists = false;
            }
            else
            {
                Directory.SetCurrentDirectory(mario);
                exists = File.Exists("data.cfg");
            }
            Directory.SetCurrentDirectory(mario);

            return exists;
        }

        public int DataFile(bool exists)
        {
        Start:

            // If file doesn't exist
            if (exists == false)
            {
                int currentDay = int.Parse(DateTime.Today.DayOfYear.ToString());

                Random random = new Random();
                int daysUntil = random.Next(3, 32);
                daysUntil -= 1;
                currentDay += daysUntil;

                using (var tw = new StreamWriter("data.cfg", false))
                {
                    tw.WriteLine(currentDay);
                }
            }

            try
            {
                int currentDay2 = int.Parse(DateTime.Today.DayOfYear.ToString());
                int theDay = int.Parse(File.ReadAllText("data.cfg"));
                return theDay -= currentDay2;
            }
            catch (Exception)
            {
                exists = false;
                goto Start;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cancel.Enabled = false;
            SystemSounds.Hand.Play();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            accepted = true;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!accepted)
            {
                e.Cancel = true;
                SystemSounds.Hand.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            MinimizeBox = false;
            MaximizeBox = false;
            CenterToScreen();
            Activate();
            SystemSounds.Asterisk.Play();

            MarioFolderParent();
            bool exists = MarioFolder();
            int finalDayCount = DataFile(exists);
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() > 1 && args[1] == "--debug")
            {
                    versionID.Visible = true;
            }
            else
            {
                versionID.Visible = false;
            }


            if (finalDayCount > 0)
            {
                text.Text = $"{finalDayCount} Days Until Mario Steals Your Liver";
            }
            else
            {
                try
                {
                    File.Delete("data.cfg");
                }
                catch (Exception)
                {
                    accepted = true;
                    Close();
                }

                Browser.Browser.Get("https://www.youtube.com/watch?v=X_8Nh5XfRw0");
                accepted = true;
                Close();
            }
        }

        private void versionID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TopMost = false;
            Browser.Browser.Get("https://github.com/Dogey11/MarioStealsYourLiver/releases/tag/" + versionID.Text);
        }
    }
}
