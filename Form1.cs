using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace REGMTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetRegMTA_Click(object sender, EventArgs e)
        {

            RegistryKey Key = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All");
            RegistryKey CommonReg = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\Common");
            RegistryKey VersReg = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5");
            RegistryKey Settings = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5\Settings");
            RegistryKey Diagn = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5\Settings\diagnostics");
            RegistryKey General = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5\Settings\general");
            RegistryKey Nvhacks = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5\Settings\nvhacks");
            RegistryKey Watchdog = Registry.LocalMachine.CreateSubKey(@"Software\WOW6432Node\Multi Theft Auto: San Andreas All\1.5\Settings\watchdog");

            //Common
            CommonReg.SetValue("GTA:SA Path", Application.StartupPath);

            //Version
            VersReg.SetValue("Last Run Location", "");
            VersReg.SetValue("Last Run Path Hash", "");
            VersReg.SetValue("Last Run Path Version", "");
            VersReg.SetValue("OnQuitCommand", "");
            VersReg.SetValue("OnRestartCommand", "");
            VersReg.SetValue("PostUpdateConnect", "");
            // Diagnosticks
            Diagn.SetValue("bsod-detect-skip", "0");
            Diagn.SetValue("createdevice-last-status", "3");
            Diagn.SetValue("debug-setting", "none");
            Diagn.SetValue("game-begin-time", "");
            Diagn.SetValue("gta-fopen-fail", "");
            Diagn.SetValue("gta-fopen-last", "");
            Diagn.SetValue("gta-model-fail", "");
            Diagn.SetValue("gta-upgrade-fail", "");
            Diagn.SetValue("img-file-corrupt", "");
            Diagn.SetValue("last-crash-reason", "");
            Diagn.SetValue("last-dump-save", "");
            //General
            General.SetValue("aero-changeable", "1");
            General.SetValue("aero-enabled", "1");
            General.SetValue("cachechecksum", "");
            General.SetValue("customized-sa-files-request", "0");
            General.SetValue("debugfilter", "");
            General.SetValue("device-selection-disabled", "");
            General.SetValue("is-admin", "1");
            General.SetValue("last-server-ip", "1");
            General.SetValue("locale", "ru");
            General.SetValue("mta-version-ext", "1.5.7-1.00000.0.000");
            General.SetValue("news-install", "");
            General.SetValue("news-updated", "1");
            General.SetValue("no-cycle-event-log", "0");
            General.SetValue("os-version", "6.2");
            General.SetValue("pending-browse-to-solution", "");
            General.SetValue("real-os-build", "14393");
            General.SetValue("real-os-version", "10.0");
            General.SetValue("reportsettings", "filter2@+all,-{1000~2007},-2050,-2051,-{3211},-{4002},-4023,-5132,-5133,-7011,-7043,-7411,-7420,-7601,-7744,-7745,-7801,-{7832~7833},-{7842~7845},-7940,-8070,-8613,-7711,-9423;max@38001;min@11");
            General.SetValue("serial", "");
            General.SetValue("trouble-url", "");
            General.SetValue("Win8Color16", "0");
            General.SetValue("Win8MouseFix", "0");
            //Nvhacks
            Nvhacks.SetValue("nvidia", "1");
            Nvhacks.SetValue("optimus", "0");
            Nvhacks.SetValue("optimus-alt-startup", "0");
            Nvhacks.SetValue("optimus-export-enablement", "0");
            Nvhacks.SetValue("optimus-force-windowed", "0");
            Nvhacks.SetValue("optimus-rename-exe", "0");
            //Watchdog
            Watchdog.SetValue("CR1", "0");
            Watchdog.SetValue("CR2", "0");
            Watchdog.SetValue("CR3", "0");
            Watchdog.SetValue("L0", "0");
            Watchdog.SetValue("L1", "1");
            Watchdog.SetValue("L2", "0");
            Watchdog.SetValue("L3", "0");
            Watchdog.SetValue("L4", "0");
            Watchdog.SetValue("L5", "0");
            Watchdog.SetValue("lastruncrash", "1");
            Watchdog.SetValue("Q0", "0");
            Watchdog.SetValue("uncleanstop", "0");

            label1.Text = "Реестр успешно установлен!";
            Process.Start("Multi Theft Auto.exe");

        }
    }
}
