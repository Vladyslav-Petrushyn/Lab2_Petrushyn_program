namespace Lab1_Petrushyn_program
{
	partial class MainForm
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
			this.Menu_strp = new System.Windows.Forms.MenuStrip();
			this.Start_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.DoSmth_menu_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.buy_wm_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.Sold_wm_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.exchange_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.polar_btn = new System.Windows.Forms.ToolStripMenuItem();
			this.Count_tb = new System.Windows.Forms.TextBox();
			this.Count_lbl = new System.Windows.Forms.Label();
			this.Warframes_lb = new System.Windows.Forms.ListBox();
			this.Sex_lbl = new System.Windows.Forms.Label();
			this.Mods_lbl = new System.Windows.Forms.Label();
			this.Name_lbl = new System.Windows.Forms.Label();
			this.Type_lbl = new System.Windows.Forms.Label();
			this.Lvl_lbl = new System.Windows.Forms.Label();
			this.Characteristics_lbl = new System.Windows.Forms.Label();
			this.Warframes_lbl = new System.Windows.Forms.Label();
			this.Name_tb = new System.Windows.Forms.TextBox();
			this.lvl_tb = new System.Windows.Forms.TextBox();
			this.Mods_count_tb = new System.Windows.Forms.TextBox();
			this.Type_cb = new System.Windows.Forms.ComboBox();
			this.Sex_cb = new System.Windows.Forms.ComboBox();
			this.Ready_btn = new System.Windows.Forms.Button();
			this.Credits_tb = new System.Windows.Forms.TextBox();
			this.Credits_input_lbl = new System.Windows.Forms.Label();
			this.Change_btn = new System.Windows.Forms.Button();
			this.Reputation_lbl = new System.Windows.Forms.Label();
			this.All_char = new System.Windows.Forms.Button();
			this.Is_Resp_lbl = new System.Windows.Forms.Label();
			this.Ressuract_tb = new System.Windows.Forms.TextBox();
			this.Menu_strp.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu_strp
			// 
			this.Menu_strp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_btn,
            this.DoSmth_menu_btn});
			this.Menu_strp.Location = new System.Drawing.Point(0, 0);
			this.Menu_strp.Name = "Menu_strp";
			this.Menu_strp.Size = new System.Drawing.Size(635, 25);
			this.Menu_strp.TabIndex = 0;
			this.Menu_strp.Text = "menuStrip1";
			// 
			// Start_btn
			// 
			this.Start_btn.Name = "Start_btn";
			this.Start_btn.Size = new System.Drawing.Size(60, 21);
			this.Start_btn.Text = "Почати";
			this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
			// 
			// DoSmth_menu_btn
			// 
			this.DoSmth_menu_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buy_wm_btn,
            this.Sold_wm_btn,
            this.exchange_btn,
            this.polar_btn});
			this.DoSmth_menu_btn.Enabled = false;
			this.DoSmth_menu_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DoSmth_menu_btn.Name = "DoSmth_menu_btn";
			this.DoSmth_menu_btn.Size = new System.Drawing.Size(135, 21);
			this.DoSmth_menu_btn.Text = "Дії з Ворфреймами";
			// 
			// buy_wm_btn
			// 
			this.buy_wm_btn.Name = "buy_wm_btn";
			this.buy_wm_btn.Size = new System.Drawing.Size(215, 22);
			this.buy_wm_btn.Text = "Придбати";
			this.buy_wm_btn.Click += new System.EventHandler(this.buy_wm_btn_Click);
			// 
			// Sold_wm_btn
			// 
			this.Sold_wm_btn.Name = "Sold_wm_btn";
			this.Sold_wm_btn.Size = new System.Drawing.Size(215, 22);
			this.Sold_wm_btn.Text = "Продати";
			this.Sold_wm_btn.Click += new System.EventHandler(this.Sold_wm_btn_Click);
			// 
			// exchange_btn
			// 
			this.exchange_btn.Name = "exchange_btn";
			this.exchange_btn.Size = new System.Drawing.Size(215, 22);
			this.exchange_btn.Text = "Обміняти на репутацію";
			this.exchange_btn.Click += new System.EventHandler(this.exchange_btn_Click);
			// 
			// polar_btn
			// 
			this.polar_btn.Name = "polar_btn";
			this.polar_btn.Size = new System.Drawing.Size(215, 22);
			this.polar_btn.Text = "Поляризувати";
			this.polar_btn.Click += new System.EventHandler(this.polar_btn_Click);
			// 
			// Count_tb
			// 
			this.Count_tb.Enabled = false;
			this.Count_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Count_tb.Location = new System.Drawing.Point(208, 87);
			this.Count_tb.Name = "Count_tb";
			this.Count_tb.Size = new System.Drawing.Size(101, 29);
			this.Count_tb.TabIndex = 2;
			// 
			// Count_lbl
			// 
			this.Count_lbl.AutoSize = true;
			this.Count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Count_lbl.Location = new System.Drawing.Point(30, 83);
			this.Count_lbl.Name = "Count_lbl";
			this.Count_lbl.Size = new System.Drawing.Size(172, 40);
			this.Count_lbl.TabIndex = 1;
			this.Count_lbl.Text = "Максимальна \r\nкількість ворфреймів";
			this.Count_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Warframes_lb
			// 
			this.Warframes_lb.Enabled = false;
			this.Warframes_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Warframes_lb.FormattingEnabled = true;
			this.Warframes_lb.ItemHeight = 24;
			this.Warframes_lb.Location = new System.Drawing.Point(353, 99);
			this.Warframes_lb.Name = "Warframes_lb";
			this.Warframes_lb.Size = new System.Drawing.Size(252, 340);
			this.Warframes_lb.TabIndex = 6;
			this.Warframes_lb.Click += new System.EventHandler(this.Warframes_lb_SelectedIndexChanged);
			// 
			// Sex_lbl
			// 
			this.Sex_lbl.AutoSize = true;
			this.Sex_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Sex_lbl.Location = new System.Drawing.Point(34, 359);
			this.Sex_lbl.Name = "Sex_lbl";
			this.Sex_lbl.Size = new System.Drawing.Size(64, 24);
			this.Sex_lbl.TabIndex = 7;
			this.Sex_lbl.Text = "Стать";
			// 
			// Mods_lbl
			// 
			this.Mods_lbl.AutoSize = true;
			this.Mods_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Mods_lbl.Location = new System.Drawing.Point(34, 294);
			this.Mods_lbl.Name = "Mods_lbl";
			this.Mods_lbl.Size = new System.Drawing.Size(147, 24);
			this.Mods_lbl.TabIndex = 8;
			this.Mods_lbl.Text = "Кількість модів";
			// 
			// Name_lbl
			// 
			this.Name_lbl.AutoSize = true;
			this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name_lbl.Location = new System.Drawing.Point(34, 231);
			this.Name_lbl.Name = "Name_lbl";
			this.Name_lbl.Size = new System.Drawing.Size(64, 24);
			this.Name_lbl.TabIndex = 9;
			this.Name_lbl.Text = "Назва";
			// 
			// Type_lbl
			// 
			this.Type_lbl.AutoSize = true;
			this.Type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Type_lbl.Location = new System.Drawing.Point(34, 327);
			this.Type_lbl.Name = "Type_lbl";
			this.Type_lbl.Size = new System.Drawing.Size(44, 24);
			this.Type_lbl.TabIndex = 10;
			this.Type_lbl.Text = "Тип";
			// 
			// Lvl_lbl
			// 
			this.Lvl_lbl.AutoSize = true;
			this.Lvl_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Lvl_lbl.Location = new System.Drawing.Point(34, 264);
			this.Lvl_lbl.Name = "Lvl_lbl";
			this.Lvl_lbl.Size = new System.Drawing.Size(70, 24);
			this.Lvl_lbl.TabIndex = 11;
			this.Lvl_lbl.Text = "Рівень";
			// 
			// Characteristics_lbl
			// 
			this.Characteristics_lbl.AutoSize = true;
			this.Characteristics_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Characteristics_lbl.Location = new System.Drawing.Point(95, 194);
			this.Characteristics_lbl.Name = "Characteristics_lbl";
			this.Characteristics_lbl.Size = new System.Drawing.Size(170, 24);
			this.Characteristics_lbl.TabIndex = 12;
			this.Characteristics_lbl.Text = "Характеристики";
			// 
			// Warframes_lbl
			// 
			this.Warframes_lbl.AutoSize = true;
			this.Warframes_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Warframes_lbl.Location = new System.Drawing.Point(368, 67);
			this.Warframes_lbl.Name = "Warframes_lbl";
			this.Warframes_lbl.Size = new System.Drawing.Size(205, 24);
			this.Warframes_lbl.TabIndex = 13;
			this.Warframes_lbl.Text = "Список ворфреймів";
			// 
			// Name_tb
			// 
			this.Name_tb.Enabled = false;
			this.Name_tb.Location = new System.Drawing.Point(209, 231);
			this.Name_tb.Name = "Name_tb";
			this.Name_tb.Size = new System.Drawing.Size(100, 20);
			this.Name_tb.TabIndex = 14;
			// 
			// lvl_tb
			// 
			this.lvl_tb.Enabled = false;
			this.lvl_tb.Location = new System.Drawing.Point(209, 264);
			this.lvl_tb.Name = "lvl_tb";
			this.lvl_tb.Size = new System.Drawing.Size(100, 20);
			this.lvl_tb.TabIndex = 15;
			// 
			// Mods_count_tb
			// 
			this.Mods_count_tb.Enabled = false;
			this.Mods_count_tb.Location = new System.Drawing.Point(209, 298);
			this.Mods_count_tb.Name = "Mods_count_tb";
			this.Mods_count_tb.Size = new System.Drawing.Size(100, 20);
			this.Mods_count_tb.TabIndex = 16;
			// 
			// Type_cb
			// 
			this.Type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Type_cb.Enabled = false;
			this.Type_cb.FormattingEnabled = true;
			this.Type_cb.Location = new System.Drawing.Point(209, 330);
			this.Type_cb.Name = "Type_cb";
			this.Type_cb.Size = new System.Drawing.Size(100, 21);
			this.Type_cb.TabIndex = 17;
			// 
			// Sex_cb
			// 
			this.Sex_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Sex_cb.Enabled = false;
			this.Sex_cb.FormattingEnabled = true;
			this.Sex_cb.Location = new System.Drawing.Point(209, 364);
			this.Sex_cb.Name = "Sex_cb";
			this.Sex_cb.Size = new System.Drawing.Size(100, 21);
			this.Sex_cb.TabIndex = 18;
			// 
			// Ready_btn
			// 
			this.Ready_btn.Enabled = false;
			this.Ready_btn.Location = new System.Drawing.Point(127, 168);
			this.Ready_btn.Name = "Ready_btn";
			this.Ready_btn.Size = new System.Drawing.Size(106, 23);
			this.Ready_btn.TabIndex = 19;
			this.Ready_btn.Text = "Готово";
			this.Ready_btn.UseVisualStyleBackColor = true;
			this.Ready_btn.Click += new System.EventHandler(this.Ready_btn_Click);
			// 
			// Credits_tb
			// 
			this.Credits_tb.Enabled = false;
			this.Credits_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Credits_tb.Location = new System.Drawing.Point(207, 133);
			this.Credits_tb.Name = "Credits_tb";
			this.Credits_tb.Size = new System.Drawing.Size(101, 29);
			this.Credits_tb.TabIndex = 4;
			// 
			// Credits_input_lbl
			// 
			this.Credits_input_lbl.AutoSize = true;
			this.Credits_input_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Credits_input_lbl.Location = new System.Drawing.Point(42, 136);
			this.Credits_input_lbl.Name = "Credits_input_lbl";
			this.Credits_input_lbl.Size = new System.Drawing.Size(149, 20);
			this.Credits_input_lbl.TabIndex = 3;
			this.Credits_input_lbl.Text = "Кількість кредитів";
			this.Credits_input_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Change_btn
			// 
			this.Change_btn.Enabled = false;
			this.Change_btn.Location = new System.Drawing.Point(46, 426);
			this.Change_btn.Name = "Change_btn";
			this.Change_btn.Size = new System.Drawing.Size(106, 23);
			this.Change_btn.TabIndex = 20;
			this.Change_btn.Text = "Змінити";
			this.Change_btn.UseVisualStyleBackColor = true;
			this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
			// 
			// Reputation_lbl
			// 
			this.Reputation_lbl.AutoSize = true;
			this.Reputation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Reputation_lbl.Location = new System.Drawing.Point(282, 40);
			this.Reputation_lbl.Name = "Reputation_lbl";
			this.Reputation_lbl.Size = new System.Drawing.Size(91, 18);
			this.Reputation_lbl.TabIndex = 21;
			this.Reputation_lbl.Text = "Репутація: 0";
			// 
			// All_char
			// 
			this.All_char.Enabled = false;
			this.All_char.Location = new System.Drawing.Point(193, 426);
			this.All_char.Name = "All_char";
			this.All_char.Size = new System.Drawing.Size(106, 23);
			this.All_char.TabIndex = 22;
			this.All_char.Text = "Інфо";
			this.All_char.UseVisualStyleBackColor = true;
			this.All_char.Click += new System.EventHandler(this.All_char_Click);
			// 
			// Is_Resp_lbl
			// 
			this.Is_Resp_lbl.AutoSize = true;
			this.Is_Resp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Is_Resp_lbl.Location = new System.Drawing.Point(34, 391);
			this.Is_Resp_lbl.Name = "Is_Resp_lbl";
			this.Is_Resp_lbl.Size = new System.Drawing.Size(170, 24);
			this.Is_Resp_lbl.TabIndex = 23;
			this.Is_Resp_lbl.Text = "Можна відродити";
			// 
			// Ressuract_tb
			// 
			this.Ressuract_tb.Enabled = false;
			this.Ressuract_tb.Location = new System.Drawing.Point(210, 395);
			this.Ressuract_tb.Name = "Ressuract_tb";
			this.Ressuract_tb.Size = new System.Drawing.Size(98, 20);
			this.Ressuract_tb.TabIndex = 24;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 465);
			this.Controls.Add(this.Ressuract_tb);
			this.Controls.Add(this.Is_Resp_lbl);
			this.Controls.Add(this.All_char);
			this.Controls.Add(this.Reputation_lbl);
			this.Controls.Add(this.Change_btn);
			this.Controls.Add(this.Ready_btn);
			this.Controls.Add(this.Sex_cb);
			this.Controls.Add(this.Type_cb);
			this.Controls.Add(this.Mods_count_tb);
			this.Controls.Add(this.lvl_tb);
			this.Controls.Add(this.Name_tb);
			this.Controls.Add(this.Warframes_lbl);
			this.Controls.Add(this.Characteristics_lbl);
			this.Controls.Add(this.Lvl_lbl);
			this.Controls.Add(this.Type_lbl);
			this.Controls.Add(this.Name_lbl);
			this.Controls.Add(this.Mods_lbl);
			this.Controls.Add(this.Sex_lbl);
			this.Controls.Add(this.Warframes_lb);
			this.Controls.Add(this.Credits_tb);
			this.Controls.Add(this.Credits_input_lbl);
			this.Controls.Add(this.Count_tb);
			this.Controls.Add(this.Count_lbl);
			this.Controls.Add(this.Menu_strp);
			this.MainMenuStrip = this.Menu_strp;
			this.Name = "MainForm";
			this.Text = "Warframe Simulator (Beta v 0.1)";
			this.Menu_strp.ResumeLayout(false);
			this.Menu_strp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip Menu_strp;
		private System.Windows.Forms.ToolStripMenuItem DoSmth_menu_btn;
		private System.Windows.Forms.ToolStripMenuItem buy_wm_btn;
		private System.Windows.Forms.ToolStripMenuItem Sold_wm_btn;
		private System.Windows.Forms.ToolStripMenuItem exchange_btn;
		private System.Windows.Forms.ToolStripMenuItem polar_btn;
		private System.Windows.Forms.ToolStripMenuItem Start_btn;
		private System.Windows.Forms.TextBox Count_tb;
		private System.Windows.Forms.Label Count_lbl;
		private System.Windows.Forms.ListBox Warframes_lb;
		private System.Windows.Forms.Label Sex_lbl;
		private System.Windows.Forms.Label Mods_lbl;
		private System.Windows.Forms.Label Name_lbl;
		private System.Windows.Forms.Label Type_lbl;
		private System.Windows.Forms.Label Lvl_lbl;
		private System.Windows.Forms.Label Characteristics_lbl;
		private System.Windows.Forms.Label Warframes_lbl;
		private System.Windows.Forms.TextBox Name_tb;
		private System.Windows.Forms.TextBox lvl_tb;
		private System.Windows.Forms.TextBox Mods_count_tb;
		private System.Windows.Forms.ComboBox Type_cb;
		private System.Windows.Forms.ComboBox Sex_cb;
		private System.Windows.Forms.Button Ready_btn;
		private System.Windows.Forms.TextBox Credits_tb;
		private System.Windows.Forms.Label Credits_input_lbl;
		private System.Windows.Forms.Button Change_btn;
		private System.Windows.Forms.Label Reputation_lbl;
		private System.Windows.Forms.Button All_char;
		private System.Windows.Forms.Label Is_Resp_lbl;
		private System.Windows.Forms.TextBox Ressuract_tb;
	}
}

