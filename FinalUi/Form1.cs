using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalUi
{
    public partial class Form1 : Form
    {
   
        public delegate void SystemAlert(string message, int severity);

        private void ConsoleLog(string message, int severity)
        {
            AppendLog("[CONSOLE] Severity " + severity + ": " + message);
        }

        private void FileLog(string message, int severity)
        {
            AppendLog("[LOG] Severity " + severity + ": " + message);
        }


        public interface IUpgradable
        {
            void Upgrade();
        }

        public class Engine : IUpgradable
        {
            public void Upgrade()
            {
       
            }
        }

        private Engine engine = new Engine();

   
        public delegate int DamageCalculator(int power);

        private int CalculateDamage(int power)
        {
            DamageCalculator calc = delegate (int p) { return p * 2; };
            return calc(power);
        }

    
        public class CargoSystem
        {
            private EventHandler _onCargoReceived;

            public event EventHandler OnCargoReceived
            {
                add
                {
                    // MEMBER 8
                    MessageBox.Show("Security check passed.");
                    _onCargoReceived += value;
                }
                remove
                {
                    // MEMBER 9
                    MessageBox.Show("Listener removed.");
                    _onCargoReceived -= value;
                }
            }

            // MEMBER 6
            public void ReceiveCargo()
            {
                if (_onCargoReceived != null)
                {
                    _onCargoReceived(this, EventArgs.Empty);
                }
            }
        }

        private CargoSystem cargo = new CargoSystem();

  
        public Form1()
        {
            InitializeComponent();

            // MEMBER 7 - Subscribe
            cargo.OnCargoReceived += CargoReceivedHandler;
        }

        // MEMBER 7 - Event Handler
        private void CargoReceivedHandler(object sender, EventArgs e)
        {
            AppendLog("Cargo received! Processing started.");
        }


        private void btnConsoleAlert_Click(object sender, EventArgs e)
        {

            SystemAlert alert = ConsoleLog;
            alert("Engine failure!", 5);

        }

        private void btnMulticastAlert_Click(object sender, EventArgs e)
        {

            SystemAlert alert = ConsoleLog;
            alert += FileLog;          // Multicast
            alert("Engine failure!", 5);

        }

        private void btnUpgradeEngine_Click(object sender, EventArgs e)
        {

            engine.Upgrade();
            AppendLog("Engine upgraded!");

        }

        private void btnWeaponDamage_Click(object sender, EventArgs e)
        {
            int damage = CalculateDamage(10);
            AppendLog($"Weapon Damage Calculated: {damage}");
        }

        private void btnRecieveCargo_Click(object sender, EventArgs e)
        {
            cargo.ReceiveCargo();
        }

        private void btnUnsubscribeListener_Click(object sender, EventArgs e)
        {
            cargo.OnCargoReceived -= CargoReceivedHandler;
        }

        private void AppendLog(string message)
        {
            textCommandLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + message + Environment.NewLine);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textCommandLog.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
