namespace FinalUi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsoleAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMulticastAlert = new System.Windows.Forms.Button();
            this.btnUpgradeEngine = new System.Windows.Forms.Button();
            this.btnWeaponDamage = new System.Windows.Forms.Button();
            this.btnRecieveCargo = new System.Windows.Forms.Button();
            this.btnUnsubscribeListener = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCommandLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsoleAlert
            // 
            this.btnConsoleAlert.BackColor = System.Drawing.SystemColors.Info;
            this.btnConsoleAlert.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleAlert.Location = new System.Drawing.Point(57, 81);
            this.btnConsoleAlert.Name = "btnConsoleAlert";
            this.btnConsoleAlert.Size = new System.Drawing.Size(247, 34);
            this.btnConsoleAlert.TabIndex = 0;
            this.btnConsoleAlert.Text = "[ Send Console Alert ]";
            this.btnConsoleAlert.UseVisualStyleBackColor = false;
            this.btnConsoleAlert.Click += new System.EventHandler(this.btnConsoleAlert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "SYSTEM ALERTS ( CUSTOM DELEGATE )";
            // 
            // btnMulticastAlert
            // 
            this.btnMulticastAlert.BackColor = System.Drawing.SystemColors.Info;
            this.btnMulticastAlert.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulticastAlert.Location = new System.Drawing.Point(321, 81);
            this.btnMulticastAlert.Name = "btnMulticastAlert";
            this.btnMulticastAlert.Size = new System.Drawing.Size(247, 34);
            this.btnMulticastAlert.TabIndex = 7;
            this.btnMulticastAlert.Text = "[ Send Multicast Alert ]";
            this.btnMulticastAlert.UseVisualStyleBackColor = false;
            this.btnMulticastAlert.Click += new System.EventHandler(this.btnMulticastAlert_Click);
            // 
            // btnUpgradeEngine
            // 
            this.btnUpgradeEngine.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpgradeEngine.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgradeEngine.Location = new System.Drawing.Point(57, 177);
            this.btnUpgradeEngine.Name = "btnUpgradeEngine";
            this.btnUpgradeEngine.Size = new System.Drawing.Size(247, 34);
            this.btnUpgradeEngine.TabIndex = 8;
            this.btnUpgradeEngine.Text = "[ Upgrade Engine ]";
            this.btnUpgradeEngine.UseVisualStyleBackColor = false;
            this.btnUpgradeEngine.Click += new System.EventHandler(this.btnUpgradeEngine_Click);
            // 
            // btnWeaponDamage
            // 
            this.btnWeaponDamage.BackColor = System.Drawing.SystemColors.Info;
            this.btnWeaponDamage.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeaponDamage.Location = new System.Drawing.Point(321, 177);
            this.btnWeaponDamage.Name = "btnWeaponDamage";
            this.btnWeaponDamage.Size = new System.Drawing.Size(247, 34);
            this.btnWeaponDamage.TabIndex = 9;
            this.btnWeaponDamage.Text = "[ Calculate Weapon Damage ]";
            this.btnWeaponDamage.UseVisualStyleBackColor = false;
            this.btnWeaponDamage.Click += new System.EventHandler(this.btnWeaponDamage_Click);
            // 
            // btnRecieveCargo
            // 
            this.btnRecieveCargo.BackColor = System.Drawing.SystemColors.Info;
            this.btnRecieveCargo.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecieveCargo.Location = new System.Drawing.Point(57, 271);
            this.btnRecieveCargo.Name = "btnRecieveCargo";
            this.btnRecieveCargo.Size = new System.Drawing.Size(247, 34);
            this.btnRecieveCargo.TabIndex = 10;
            this.btnRecieveCargo.Text = "[ Recieve Cargo ]";
            this.btnRecieveCargo.UseVisualStyleBackColor = false;
            this.btnRecieveCargo.Click += new System.EventHandler(this.btnRecieveCargo_Click);
            // 
            // btnUnsubscribeListener
            // 
            this.btnUnsubscribeListener.BackColor = System.Drawing.SystemColors.Info;
            this.btnUnsubscribeListener.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsubscribeListener.Location = new System.Drawing.Point(321, 271);
            this.btnUnsubscribeListener.Name = "btnUnsubscribeListener";
            this.btnUnsubscribeListener.Size = new System.Drawing.Size(247, 34);
            this.btnUnsubscribeListener.TabIndex = 11;
            this.btnUnsubscribeListener.Text = "[ Unsubscribe Listener ]";
            this.btnUnsubscribeListener.UseVisualStyleBackColor = false;
            this.btnUnsubscribeListener.Click += new System.EventHandler(this.btnUnsubscribeListener_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "SHIP COMPONENTS ( INTERFACE + DELEGATE )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "CARGO SYSTEM ( EVENTS + CUSTOM ACCESSOR  )";
            // 
            // textCommandLog
            // 
            this.textCommandLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textCommandLog.Location = new System.Drawing.Point(98, 394);
            this.textCommandLog.Multiline = true;
            this.textCommandLog.Name = "textCommandLog";
            this.textCommandLog.Size = new System.Drawing.Size(422, 171);
            this.textCommandLog.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "COMMAND LOG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 651);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status: Ready";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(461, 642);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 35);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "[ Clear ]";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 695);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCommandLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnsubscribeListener);
            this.Controls.Add(this.btnRecieveCargo);
            this.Controls.Add(this.btnWeaponDamage);
            this.Controls.Add(this.btnUpgradeEngine);
            this.Controls.Add(this.btnMulticastAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsoleAlert);
            this.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GALACTIC COMMAND CENTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsoleAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMulticastAlert;
        private System.Windows.Forms.Button btnUpgradeEngine;
        private System.Windows.Forms.Button btnWeaponDamage;
        private System.Windows.Forms.Button btnRecieveCargo;
        private System.Windows.Forms.Button btnUnsubscribeListener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCommandLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
    }
}

