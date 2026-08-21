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
        // =========================================================
        // PART 1 - Custom Delegates
        // Assigned to: Marteja and Mendoza
        // =========================================================

        public delegate void SystemAlert(string message, int severity);

        private void ConsoleLog(string message, int severity)
        {
            AppendLog("[CONSOLE] Severity " + severity + ": " + message);
        }

        private void FileLog(string message, int severity)
        {
            AppendLog("[LOG] Severity " + severity + ": " + message);
        }

        // =========================================================
        // PART 2 - Delegates and Interface
        // Assigned to: Mallari and Joven
        // =========================================================

        public interface IUpgradable
        {
            void Upgrade();
        }

        public class Engine : IUpgradable
        {
            public void Upgrade()
            {
                // Upgrade logic
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

            // =========================================================
            // PART 4 - Event Accessors
            // Assigned to: Ordonez and Lillio
            // =========================================================

            public event EventHandler OnCargoReceived
            {
                add
                {
                    MessageBox.Show("Security check passed.");
                    _onCargoReceived += value;
                }
                remove
                {
                    MessageBox.Show("Listener removed.");
                    _onCargoReceived -= value;
                }
            }


            // =========================================================
            // PART 3 - Events
            // Assigned to: Haquias and Planquero
            // =========================================================


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
            cargo.OnCargoReceived += CargoReceivedHandler;
        }

        private void CargoReceivedHandler(object sender, EventArgs e)
        {
            AppendLog("Cargo received! Processing started.");
        }




        // =========================================================
        // BUTTON EVENTS
        // =========================================================

        // Part 1 - Marteja

        private void btnConsoleAlert_Click(object sender, EventArgs e)
        {
            SystemAlert alert = ConsoleLog;
            alert("Engine failure!", 5);
        }

        // Part 1 - Mendoza

        private void btnMulticastAlert_Click(object sender, EventArgs e)
        {
            SystemAlert alert = ConsoleLog;
            alert += FileLog;
            alert("Engine failure!", 5);
        }

        // Part 2 - Joven

        private void btnUpgradeEngine_Click(object sender, EventArgs e)
        {
            engine.Upgrade();
            AppendLog("Engine upgraded!");
        }

        // Part 2 - Mallari

        private void btnWeaponDamage_Click(object sender, EventArgs e)
        {
            int damage = CalculateDamage(10);
            AppendLog("Weapon Damage Calculated: " + damage);
        }

        // Part 3 - Planquero / Haquias

        private void btnRecieveCargo_Click(object sender, EventArgs e)
        {
            cargo.ReceiveCargo();
        }

        // Part 4 - Lillio

        private void btnUnsubscribeListener_Click(object sender, EventArgs e)
        {
            cargo.OnCargoReceived -= CargoReceivedHandler;
        }

        // Clear Log - Ordonez

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textCommandLog.Clear();
        }

        // Helper Method - Ordonez

        private void AppendLog(string message)
        {
            textCommandLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + message + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
