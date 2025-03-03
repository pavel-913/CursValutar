using System.Drawing;

namespace CursValutar
{
    partial class CursMAIB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursMAIB));
            this.mdlbtn = new System.Windows.Forms.Button();
            this.usdbtn = new System.Windows.Forms.Button();
            this.eurbtn = new System.Windows.Forms.Button();
            this.ronbtn = new System.Windows.Forms.Button();
            this.gbpbtn = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.gbp1btn = new System.Windows.Forms.Button();
            this.ron1btn = new System.Windows.Forms.Button();
            this.eur1btn = new System.Windows.Forms.Button();
            this.usd1btn = new System.Windows.Forms.Button();
            this.mdl1btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.USDbuy = new System.Windows.Forms.Label();
            this.EURbuy = new System.Windows.Forms.Label();
            this.RONbuy = new System.Windows.Forms.Label();
            this.GBPbuy = new System.Windows.Forms.Label();
            this.GBPsell = new System.Windows.Forms.Label();
            this.RONsell = new System.Windows.Forms.Label();
            this.EURsell = new System.Windows.Forms.Label();
            this.USDsell = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdlbtn
            // 
            this.mdlbtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.mdlbtn.Location = new System.Drawing.Point(0, 8);
            this.mdlbtn.Name = "mdlbtn";
            this.mdlbtn.Size = new System.Drawing.Size(61, 39);
            this.mdlbtn.TabIndex = 0;
            this.mdlbtn.Text = "MDL";
            this.mdlbtn.UseVisualStyleBackColor = true;
            this.mdlbtn.Click += new System.EventHandler(this.mdlbtn_Click);
            // 
            // usdbtn
            // 
            this.usdbtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.usdbtn.Location = new System.Drawing.Point(60, 8);
            this.usdbtn.Name = "usdbtn";
            this.usdbtn.Size = new System.Drawing.Size(61, 39);
            this.usdbtn.TabIndex = 1;
            this.usdbtn.Text = "USD";
            this.usdbtn.UseVisualStyleBackColor = true;
            this.usdbtn.Click += new System.EventHandler(this.usdbtn_Click);
            // 
            // eurbtn
            // 
            this.eurbtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.eurbtn.Location = new System.Drawing.Point(120, 8);
            this.eurbtn.Name = "eurbtn";
            this.eurbtn.Size = new System.Drawing.Size(61, 39);
            this.eurbtn.TabIndex = 2;
            this.eurbtn.Text = "EUR";
            this.eurbtn.UseVisualStyleBackColor = true;
            this.eurbtn.Click += new System.EventHandler(this.eurbtn_Click);
            // 
            // ronbtn
            // 
            this.ronbtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.ronbtn.Location = new System.Drawing.Point(180, 8);
            this.ronbtn.Name = "ronbtn";
            this.ronbtn.Size = new System.Drawing.Size(61, 39);
            this.ronbtn.TabIndex = 3;
            this.ronbtn.Text = "RON";
            this.ronbtn.UseVisualStyleBackColor = true;
            this.ronbtn.Click += new System.EventHandler(this.rontbn_Click);
            // 
            // gbpbtn
            // 
            this.gbpbtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.gbpbtn.Location = new System.Drawing.Point(240, 8);
            this.gbpbtn.Name = "gbpbtn";
            this.gbpbtn.Size = new System.Drawing.Size(61, 39);
            this.gbpbtn.TabIndex = 4;
            this.gbpbtn.Text = "GBP";
            this.gbpbtn.UseVisualStyleBackColor = true;
            this.gbpbtn.Click += new System.EventHandler(this.gbpbtn_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(0, 46);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(301, 41);
            this.txtBox1.TabIndex = 5;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            this.txtBox1.Enter += new System.EventHandler(this.txtBox1_Enter);
            this.txtBox1.Leave += new System.EventHandler(this.txtBox1_Leave);
            // 
            // txtBox2
            // 
            this.txtBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(16, 46);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(301, 41);
            this.txtBox2.TabIndex = 6;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            this.txtBox2.Enter += new System.EventHandler(this.txtBox2_Enter);
            this.txtBox2.Leave += new System.EventHandler(this.txtBox2_Leave);
            // 
            // gbp1btn
            // 
            this.gbp1btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.gbp1btn.Location = new System.Drawing.Point(256, 8);
            this.gbp1btn.Name = "gbp1btn";
            this.gbp1btn.Size = new System.Drawing.Size(61, 39);
            this.gbp1btn.TabIndex = 11;
            this.gbp1btn.Text = "GBP";
            this.gbp1btn.UseVisualStyleBackColor = true;
            this.gbp1btn.Click += new System.EventHandler(this.gbp1btn_Click);
            // 
            // ron1btn
            // 
            this.ron1btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.ron1btn.Location = new System.Drawing.Point(196, 8);
            this.ron1btn.Name = "ron1btn";
            this.ron1btn.Size = new System.Drawing.Size(61, 39);
            this.ron1btn.TabIndex = 10;
            this.ron1btn.Text = "RON";
            this.ron1btn.UseVisualStyleBackColor = true;
            this.ron1btn.Click += new System.EventHandler(this.ron1btn_Click);
            // 
            // eur1btn
            // 
            this.eur1btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.eur1btn.Location = new System.Drawing.Point(136, 8);
            this.eur1btn.Name = "eur1btn";
            this.eur1btn.Size = new System.Drawing.Size(61, 39);
            this.eur1btn.TabIndex = 9;
            this.eur1btn.Text = "EUR";
            this.eur1btn.UseVisualStyleBackColor = true;
            this.eur1btn.Click += new System.EventHandler(this.eur1btn_Click);
            // 
            // usd1btn
            // 
            this.usd1btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.usd1btn.Location = new System.Drawing.Point(76, 8);
            this.usd1btn.Name = "usd1btn";
            this.usd1btn.Size = new System.Drawing.Size(61, 39);
            this.usd1btn.TabIndex = 8;
            this.usd1btn.Text = "USD";
            this.usd1btn.UseVisualStyleBackColor = true;
            this.usd1btn.Click += new System.EventHandler(this.usd1btn_Click);
            // 
            // mdl1btn
            // 
            this.mdl1btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.mdl1btn.Location = new System.Drawing.Point(16, 8);
            this.mdl1btn.Name = "mdl1btn";
            this.mdl1btn.Size = new System.Drawing.Size(61, 39);
            this.mdl1btn.TabIndex = 7;
            this.mdl1btn.Text = "MDL";
            this.mdl1btn.UseVisualStyleBackColor = true;
            this.mdl1btn.Click += new System.EventHandler(this.mdl1btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ron1btn);
            this.panel1.Controls.Add(this.gbp1btn);
            this.panel1.Controls.Add(this.txtBox2);
            this.panel1.Controls.Add(this.mdl1btn);
            this.panel1.Controls.Add(this.eur1btn);
            this.panel1.Controls.Add(this.usd1btn);
            this.panel1.Location = new System.Drawing.Point(444, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 90);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbpbtn);
            this.panel2.Controls.Add(this.mdlbtn);
            this.panel2.Controls.Add(this.txtBox1);
            this.panel2.Controls.Add(this.usdbtn);
            this.panel2.Controls.Add(this.eurbtn);
            this.panel2.Controls.Add(this.ronbtn);
            this.panel2.Location = new System.Drawing.Point(37, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 90);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(376, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "valuta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "cumpărare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(584, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "vânzare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(380, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(380, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "EUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(380, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "RON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(380, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "GBP";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(23, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(765, 2);
            this.label8.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(23, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(765, 2);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(23, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(765, 2);
            this.label10.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(23, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(765, 2);
            this.label11.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(23, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(765, 2);
            this.label12.TabIndex = 28;
            // 
            // USDbuy
            // 
            this.USDbuy.AutoSize = true;
            this.USDbuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USDbuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.USDbuy.Location = new System.Drawing.Point(154, 96);
            this.USDbuy.Name = "USDbuy";
            this.USDbuy.Size = new System.Drawing.Size(37, 18);
            this.USDbuy.TabIndex = 29;
            this.USDbuy.Text = "USD";
            // 
            // EURbuy
            // 
            this.EURbuy.AutoSize = true;
            this.EURbuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EURbuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EURbuy.Location = new System.Drawing.Point(154, 159);
            this.EURbuy.Name = "EURbuy";
            this.EURbuy.Size = new System.Drawing.Size(35, 18);
            this.EURbuy.TabIndex = 30;
            this.EURbuy.Text = "EUR";
            // 
            // RONbuy
            // 
            this.RONbuy.AutoSize = true;
            this.RONbuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RONbuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RONbuy.Location = new System.Drawing.Point(154, 221);
            this.RONbuy.Name = "RONbuy";
            this.RONbuy.Size = new System.Drawing.Size(41, 18);
            this.RONbuy.TabIndex = 31;
            this.RONbuy.Text = "RON";
            // 
            // GBPbuy
            // 
            this.GBPbuy.AutoSize = true;
            this.GBPbuy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPbuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBPbuy.Location = new System.Drawing.Point(154, 285);
            this.GBPbuy.Name = "GBPbuy";
            this.GBPbuy.Size = new System.Drawing.Size(38, 18);
            this.GBPbuy.TabIndex = 32;
            this.GBPbuy.Text = "GBP";
            // 
            // GBPsell
            // 
            this.GBPsell.AutoSize = true;
            this.GBPsell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPsell.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GBPsell.Location = new System.Drawing.Point(595, 285);
            this.GBPsell.Name = "GBPsell";
            this.GBPsell.Size = new System.Drawing.Size(38, 18);
            this.GBPsell.TabIndex = 36;
            this.GBPsell.Text = "GBP";
            // 
            // RONsell
            // 
            this.RONsell.AutoSize = true;
            this.RONsell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RONsell.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RONsell.Location = new System.Drawing.Point(595, 221);
            this.RONsell.Name = "RONsell";
            this.RONsell.Size = new System.Drawing.Size(41, 18);
            this.RONsell.TabIndex = 35;
            this.RONsell.Text = "RON";
            // 
            // EURsell
            // 
            this.EURsell.AutoSize = true;
            this.EURsell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EURsell.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EURsell.Location = new System.Drawing.Point(595, 159);
            this.EURsell.Name = "EURsell";
            this.EURsell.Size = new System.Drawing.Size(35, 18);
            this.EURsell.TabIndex = 34;
            this.EURsell.Text = "EUR";
            // 
            // USDsell
            // 
            this.USDsell.AutoSize = true;
            this.USDsell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USDsell.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.USDsell.Location = new System.Drawing.Point(595, 96);
            this.USDsell.Name = "USDsell";
            this.USDsell.Size = new System.Drawing.Size(37, 18);
            this.USDsell.TabIndex = 33;
            this.USDsell.Text = "USD";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline);
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(425, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Schimbare curs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline);
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(97, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 33);
            this.button2.TabIndex = 38;
            this.button2.Text = "Istoric curs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CursMAIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GBPsell);
            this.Controls.Add(this.RONsell);
            this.Controls.Add(this.EURsell);
            this.Controls.Add(this.USDsell);
            this.Controls.Add(this.GBPbuy);
            this.Controls.Add(this.RONbuy);
            this.Controls.Add(this.EURbuy);
            this.Controls.Add(this.USDbuy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CursMAIB";
            this.Text = "SchimbMAIB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mdlbtn;
        private System.Windows.Forms.Button usdbtn;
        private System.Windows.Forms.Button eurbtn;
        private System.Windows.Forms.Button ronbtn;
        private System.Windows.Forms.Button gbpbtn;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button gbp1btn;
        private System.Windows.Forms.Button ron1btn;
        private System.Windows.Forms.Button eur1btn;
        private System.Windows.Forms.Button usd1btn;
        private System.Windows.Forms.Button mdl1btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label USDbuy;
        private System.Windows.Forms.Label EURbuy;
        private System.Windows.Forms.Label RONbuy;
        private System.Windows.Forms.Label GBPbuy;
        private System.Windows.Forms.Label GBPsell;
        private System.Windows.Forms.Label RONsell;
        private System.Windows.Forms.Label EURsell;
        private System.Windows.Forms.Label USDsell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

