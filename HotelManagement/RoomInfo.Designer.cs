
namespace HotelManagement
{
	partial class RoomInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.Datelbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.roomphonetbl = new System.Windows.Forms.TextBox();
			this.roomidtbl = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.yesradio = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.noradio = new System.Windows.Forms.RadioButton();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ResetTbl = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.RoomSearchTbl = new System.Windows.Forms.TextBox();
			this.RoomGridView = new System.Windows.Forms.DataGridView();
			this.wrocbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.Datelbl);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1136, 100);
			this.panel1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(1076, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 32);
			this.label6.TabIndex = 30;
			this.label6.Text = "X";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// Datelbl
			// 
			this.Datelbl.AutoSize = true;
			this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Datelbl.Location = new System.Drawing.Point(938, 67);
			this.Datelbl.Name = "Datelbl";
			this.Datelbl.Size = new System.Drawing.Size(81, 33);
			this.Datelbl.TabIndex = 1;
			this.Datelbl.Text = "Date";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(308, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(519, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informacje o pokojach";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// roomphonetbl
			// 
			this.roomphonetbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.roomphonetbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.roomphonetbl.Location = new System.Drawing.Point(80, 240);
			this.roomphonetbl.Multiline = true;
			this.roomphonetbl.Name = "roomphonetbl";
			this.roomphonetbl.PlaceholderText = "Telefon pokoju";
			this.roomphonetbl.Size = new System.Drawing.Size(207, 35);
			this.roomphonetbl.TabIndex = 6;
			this.roomphonetbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// roomidtbl
			// 
			this.roomidtbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.roomidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.roomidtbl.Location = new System.Drawing.Point(80, 170);
			this.roomidtbl.Multiline = true;
			this.roomidtbl.Name = "roomidtbl";
			this.roomidtbl.PlaceholderText = "ID Pokoju";
			this.roomidtbl.Size = new System.Drawing.Size(207, 35);
			this.roomidtbl.TabIndex = 5;
			this.roomidtbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.roomidtbl.TextChanged += new System.EventHandler(this.roomidtbl_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(82, 310);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Wolny";
			// 
			// yesradio
			// 
			this.yesradio.AutoSize = true;
			this.yesradio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.yesradio.Location = new System.Drawing.Point(165, 315);
			this.yesradio.Name = "yesradio";
			this.yesradio.Size = new System.Drawing.Size(14, 13);
			this.yesradio.TabIndex = 8;
			this.yesradio.TabStop = true;
			this.yesradio.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(180, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Tak";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(249, 310);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "Nie";
			// 
			// noradio
			// 
			this.noradio.AutoSize = true;
			this.noradio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.noradio.Location = new System.Drawing.Point(234, 315);
			this.noradio.Name = "noradio";
			this.noradio.Size = new System.Drawing.Size(14, 13);
			this.noradio.TabIndex = 10;
			this.noradio.TabStop = true;
			this.noradio.UseVisualStyleBackColor = true;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteBtn.Location = new System.Drawing.Point(238, 500);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
			this.DeleteBtn.TabIndex = 21;
			this.DeleteBtn.Text = "Usuń";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditBtn.Location = new System.Drawing.Point(148, 500);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(75, 31);
			this.EditBtn.TabIndex = 20;
			this.EditBtn.Text = "Edytuj";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddBtn.Location = new System.Drawing.Point(58, 500);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 31);
			this.AddBtn.TabIndex = 19;
			this.AddBtn.Text = "Dodaj";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ResetTbl
			// 
			this.ResetTbl.BackColor = System.Drawing.Color.Transparent;
			this.ResetTbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetTbl.BackgroundImage")));
			this.ResetTbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ResetTbl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ResetTbl.FlatAppearance.BorderSize = 0;
			this.ResetTbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResetTbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ResetTbl.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ResetTbl.Location = new System.Drawing.Point(881, 127);
			this.ResetTbl.Name = "ResetTbl";
			this.ResetTbl.Size = new System.Drawing.Size(35, 35);
			this.ResetTbl.TabIndex = 25;
			this.ResetTbl.UseVisualStyleBackColor = false;
			this.ResetTbl.Click += new System.EventHandler(this.ResetTbl_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button4.Location = new System.Drawing.Point(840, 127);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 35);
			this.button4.TabIndex = 24;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// RoomSearchTbl
			// 
			this.RoomSearchTbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RoomSearchTbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.RoomSearchTbl.Location = new System.Drawing.Point(627, 127);
			this.RoomSearchTbl.Multiline = true;
			this.RoomSearchTbl.Name = "RoomSearchTbl";
			this.RoomSearchTbl.PlaceholderText = "Szukaj pokoju";
			this.RoomSearchTbl.Size = new System.Drawing.Size(207, 35);
			this.RoomSearchTbl.TabIndex = 23;
			this.RoomSearchTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.RoomSearchTbl.Click += new System.EventHandler(this.RoomSearchTbl_Click);
			this.RoomSearchTbl.TextChanged += new System.EventHandler(this.RoomSearchTbl_TextChanged);
			// 
			// RoomGridView
			// 
			this.RoomGridView.AllowUserToResizeColumns = false;
			this.RoomGridView.AllowUserToResizeRows = false;
			this.RoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.RoomGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomGridView.DefaultCellStyle = dataGridViewCellStyle10;
			this.RoomGridView.Location = new System.Drawing.Point(467, 168);
			this.RoomGridView.Name = "RoomGridView";
			this.RoomGridView.RowHeadersWidth = 50;
			this.RoomGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.RoomGridView.RowTemplate.Height = 25;
			this.RoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.RoomGridView.Size = new System.Drawing.Size(552, 362);
			this.RoomGridView.TabIndex = 26;
			this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick_1);
			// 
			// wrocbtn
			// 
			this.wrocbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.wrocbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.wrocbtn.Location = new System.Drawing.Point(148, 550);
			this.wrocbtn.Name = "wrocbtn";
			this.wrocbtn.Size = new System.Drawing.Size(75, 31);
			this.wrocbtn.TabIndex = 27;
			this.wrocbtn.Text = "Wróć";
			this.wrocbtn.UseVisualStyleBackColor = true;
			this.wrocbtn.Click += new System.EventHandler(this.wrocbtn_Click);
			// 
			// RoomInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 643);
			this.Controls.Add(this.wrocbtn);
			this.Controls.Add(this.RoomGridView);
			this.Controls.Add(this.ResetTbl);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.RoomSearchTbl);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.noradio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.yesradio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.roomphonetbl);
			this.Controls.Add(this.roomidtbl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RoomInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RoomInfo";
			this.Load += new System.EventHandler(this.RoomInfo_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox roomphonetbl;
		private System.Windows.Forms.TextBox roomidtbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton yesradio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton noradio;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button ResetTbl;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox RoomSearchTbl;
		private System.Windows.Forms.DataGridView RoomGridView;
		private System.Windows.Forms.Button wrocbtn;
		private System.Windows.Forms.Label label6;
	}
}