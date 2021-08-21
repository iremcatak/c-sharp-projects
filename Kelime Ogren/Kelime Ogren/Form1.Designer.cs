
namespace Kelime_Ogren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxing = new System.Windows.Forms.TextBox();
            this.tboxtur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkelime = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // tboxing
            // 
            this.tboxing.Location = new System.Drawing.Point(117, 29);
            this.tboxing.Name = "tboxing";
            this.tboxing.Size = new System.Drawing.Size(246, 27);
            this.tboxing.TabIndex = 1;
            // 
            // tboxtur
            // 
            this.tboxtur.Location = new System.Drawing.Point(117, 71);
            this.tboxtur.Name = "tboxtur";
            this.tboxtur.Size = new System.Drawing.Size(246, 27);
            this.tboxtur.TabIndex = 1;
            this.tboxtur.TextChanged += new System.EventHandler(this.tboxtur_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(495, 32);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(28, 18);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime:";
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.Location = new System.Drawing.Point(495, 71);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(18, 18);
            this.lblkelime.TabIndex = 7;
            this.lblkelime.Text = "0";
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(463, 111);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(28, 18);
            this.lblcevap.TabIndex = 8;
            this.lblcevap.Text = "lbl";
            this.lblcevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 147);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lblkelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxtur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxing);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxing;
        private System.Windows.Forms.TextBox tboxtur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Timer timer1;
    }
}

