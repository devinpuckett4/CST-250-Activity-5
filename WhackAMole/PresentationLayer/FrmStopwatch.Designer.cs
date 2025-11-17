// ===============================================
// FrmStopwatch.Designer
// Stopwatch + Whack-A-Mole UI layout
// ===============================================
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhackAMole.PresentationLayer
{
    partial class FrmStopwatch
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTimeElapsed;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrStopwatch;
        private Button btnTarget;
        private Button btnDecoy;
        private Label lblScore;
        private Label lblMiss;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Build the UI.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrStopwatch = new System.Windows.Forms.Timer(this.components);
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnDecoy = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTimeElapsed
            //
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeElapsed.Location = new System.Drawing.Point(20, 15);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(106, 45);
            this.lblTimeElapsed.TabIndex = 0;
            this.lblTimeElapsed.Text = "00:00";
            //
            // btnStart
            //
            this.btnStart.Location = new System.Drawing.Point(20, 75);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClickEH);
            //
            // btnStop
            //
            this.btnStop.Location = new System.Drawing.Point(105, 75);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStopClickEH);
            //
            // btnReset
            //
            this.btnReset.Location = new System.Drawing.Point(190, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnResetClickEH);
            //
            // tmrStopwatch
            //
            this.tmrStopwatch.Interval = 1000;
            this.tmrStopwatch.Tick += new System.EventHandler(this.TmrStopwatchTickEH);
            //
            // btnTarget
            //
            this.btnTarget.BackColor = System.Drawing.Color.LightGreen;
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.Location = new System.Drawing.Point(260, 130);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(70, 35);
            this.btnTarget.TabIndex = 4;
            this.btnTarget.Text = "Hit";
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Visible = false;
            this.btnTarget.Click += new System.EventHandler(this.BtnTargetClickEH);
            //
            // btnDecoy
            //
            this.btnDecoy.BackColor = System.Drawing.Color.LightCoral;
            this.btnDecoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecoy.Location = new System.Drawing.Point(340, 130);
            this.btnDecoy.Name = "btnDecoy";
            this.btnDecoy.Size = new System.Drawing.Size(70, 35);
            this.btnDecoy.TabIndex = 5;
            this.btnDecoy.Text = "Bomb";
            this.btnDecoy.UseVisualStyleBackColor = false;
            this.btnDecoy.Visible = false;
            this.btnDecoy.Click += new System.EventHandler(this.BtnDecoyClickEH);
            //
            // lblScore
            //
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(300, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: 0";
            //
            // lblMiss
            //
            this.lblMiss.AutoSize = true;
            this.lblMiss.Location = new System.Drawing.Point(300, 35);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(65, 15);
            this.lblMiss.TabIndex = 7;
            this.lblMiss.Text = "Misses: 0";
            //
            // FrmStopwatch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(430, 220);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnDecoy);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimeElapsed);
            this.Name = "FrmStopwatch";
            this.Text = "Stopwatch - Whack-A-Mole";
            this.Click += new System.EventHandler(this.FrmStopwatchClickEH);
            this.Resize += new System.EventHandler(this.FrmStopwatchResizeEH); // Added for resize handling challenge.
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}