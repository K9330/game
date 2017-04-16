namespace game
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcurrenthp = new System.Windows.Forms.Label();
            this.lblcurrentmp = new System.Windows.Forms.Label();
            this.lblcurrentstamina = new System.Windows.Forms.Label();
            this.lblgold = new System.Windows.Forms.Label();
            this.lblmaxhp = new System.Windows.Forms.Label();
            this.lblmaxmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpotential = new System.Windows.Forms.Label();
            this.lblmaxstamina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stamina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gold";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcurrenthp
            // 
            this.lblcurrenthp.AutoSize = true;
            this.lblcurrenthp.Location = new System.Drawing.Point(79, 13);
            this.lblcurrenthp.Name = "lblcurrenthp";
            this.lblcurrenthp.Size = new System.Drawing.Size(0, 13);
            this.lblcurrenthp.TabIndex = 5;
            // 
            // lblcurrentmp
            // 
            this.lblcurrentmp.AutoSize = true;
            this.lblcurrentmp.Location = new System.Drawing.Point(79, 30);
            this.lblcurrentmp.Name = "lblcurrentmp";
            this.lblcurrentmp.Size = new System.Drawing.Size(0, 13);
            this.lblcurrentmp.TabIndex = 6;
            // 
            // lblcurrentstamina
            // 
            this.lblcurrentstamina.AutoSize = true;
            this.lblcurrentstamina.Location = new System.Drawing.Point(79, 47);
            this.lblcurrentstamina.Name = "lblcurrentstamina";
            this.lblcurrentstamina.Size = new System.Drawing.Size(0, 13);
            this.lblcurrentstamina.TabIndex = 7;
            // 
            // lblgold
            // 
            this.lblgold.AutoSize = true;
            this.lblgold.Location = new System.Drawing.Point(79, 64);
            this.lblgold.Name = "lblgold";
            this.lblgold.Size = new System.Drawing.Size(0, 13);
            this.lblgold.TabIndex = 8;
            // 
            // lblmaxhp
            // 
            this.lblmaxhp.AutoSize = true;
            this.lblmaxhp.Location = new System.Drawing.Point(120, 13);
            this.lblmaxhp.Name = "lblmaxhp";
            this.lblmaxhp.Size = new System.Drawing.Size(0, 13);
            this.lblmaxhp.TabIndex = 10;
            // 
            // lblmaxmp
            // 
            this.lblmaxmp.AutoSize = true;
            this.lblmaxmp.Location = new System.Drawing.Point(120, 30);
            this.lblmaxmp.Name = "lblmaxmp";
            this.lblmaxmp.Size = new System.Drawing.Size(0, 13);
            this.lblmaxmp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Potential";
            // 
            // lblpotential
            // 
            this.lblpotential.AutoSize = true;
            this.lblpotential.Location = new System.Drawing.Point(79, 81);
            this.lblpotential.Name = "lblpotential";
            this.lblpotential.Size = new System.Drawing.Size(0, 13);
            this.lblpotential.TabIndex = 13;
            // 
            // lblmaxstamina
            // 
            this.lblmaxstamina.AutoSize = true;
            this.lblmaxstamina.Location = new System.Drawing.Point(120, 47);
            this.lblmaxstamina.Name = "lblmaxstamina";
            this.lblmaxstamina.Size = new System.Drawing.Size(0, 13);
            this.lblmaxstamina.TabIndex = 14;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblmaxstamina);
            this.Controls.Add(this.lblpotential);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblmaxmp);
            this.Controls.Add(this.lblmaxhp);
            this.Controls.Add(this.lblgold);
            this.Controls.Add(this.lblcurrentstamina);
            this.Controls.Add(this.lblcurrentmp);
            this.Controls.Add(this.lblcurrenthp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcurrenthp;
        private System.Windows.Forms.Label lblcurrentmp;
        private System.Windows.Forms.Label lblcurrentstamina;
        private System.Windows.Forms.Label lblgold;
        private System.Windows.Forms.Label lblmaxhp;
        private System.Windows.Forms.Label lblmaxmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpotential;
        private System.Windows.Forms.Label lblmaxstamina;
    }
}

