namespace Guncelleme
{
    partial class guncelleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncelleme));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ilerlemedurum_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.zaman_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 62);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 41);
            this.progressBar1.TabIndex = 0;
            // 
            // ilerlemedurum_label
            // 
            this.ilerlemedurum_label.AutoSize = true;
            this.ilerlemedurum_label.Location = new System.Drawing.Point(12, 13);
            this.ilerlemedurum_label.Name = "ilerlemedurum_label";
            this.ilerlemedurum_label.Size = new System.Drawing.Size(42, 13);
            this.ilerlemedurum_label.TabIndex = 1;
            this.ilerlemedurum_label.Text = "ilerleme";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // zaman_label
            // 
            this.zaman_label.AutoSize = true;
            this.zaman_label.Location = new System.Drawing.Point(12, 35);
            this.zaman_label.Name = "zaman_label";
            this.zaman_label.Size = new System.Drawing.Size(38, 13);
            this.zaman_label.TabIndex = 2;
            this.zaman_label.Text = "zaman";
            // 
            // guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 113);
            this.Controls.Add(this.zaman_label);
            this.Controls.Add(this.ilerlemedurum_label);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme";
            this.Load += new System.EventHandler(this.Guncel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ilerlemedurum_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label zaman_label;
    }
}