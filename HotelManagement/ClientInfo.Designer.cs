
namespace HotelManagement
{
	partial class ClientInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.Datelbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.clientidtbl = new System.Windows.Forms.TextBox();
			this.clientnametbl = new System.Windows.Forms.TextBox();
			this.clientphonetbl = new System.Windows.Forms.TextBox();
			this.clientcountrytbl = new System.Windows.Forms.ComboBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.ClientSearchTbl = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.ClientGridView = new System.Windows.Forms.DataGridView();
			this.ResetTbl = new System.Windows.Forms.Button();
			this.wrocbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
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
			this.panel1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(1092, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 32);
			this.label6.TabIndex = 29;
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
			this.label1.Location = new System.Drawing.Point(302, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(532, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informacje o klientach";
			// 
			// clientidtbl
			// 
			this.clientidtbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clientidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.clientidtbl.Location = new System.Drawing.Point(80, 170);
			this.clientidtbl.Multiline = true;
			this.clientidtbl.Name = "clientidtbl";
			this.clientidtbl.PlaceholderText = "ID Klienta";
			this.clientidtbl.Size = new System.Drawing.Size(207, 35);
			this.clientidtbl.TabIndex = 1;
			this.clientidtbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clientidtbl.TextChanged += new System.EventHandler(this.clientidtbl_TextChanged);
			// 
			// clientnametbl
			// 
			this.clientnametbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clientnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.clientnametbl.Location = new System.Drawing.Point(80, 240);
			this.clientnametbl.Multiline = true;
			this.clientnametbl.Name = "clientnametbl";
			this.clientnametbl.PlaceholderText = "Imie";
			this.clientnametbl.Size = new System.Drawing.Size(207, 35);
			this.clientnametbl.TabIndex = 2;
			this.clientnametbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// clientphonetbl
			// 
			this.clientphonetbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clientphonetbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.clientphonetbl.Location = new System.Drawing.Point(80, 310);
			this.clientphonetbl.Multiline = true;
			this.clientphonetbl.Name = "clientphonetbl";
			this.clientphonetbl.PlaceholderText = "Numer telefonu";
			this.clientphonetbl.Size = new System.Drawing.Size(207, 35);
			this.clientphonetbl.TabIndex = 3;
			this.clientphonetbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// clientcountrytbl
			// 
			this.clientcountrytbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clientcountrytbl.ForeColor = System.Drawing.SystemColors.GrayText;
			this.clientcountrytbl.FormattingEnabled = true;
			this.clientcountrytbl.Items.AddRange(new object[] {
            "POLSKA",
            "NIEMCY",
            "USA",
            "CHINY",
            "JAPONIA",
            "ROSJA",
            "HISZPANIA",
            "WŁOCHY",
            "PORTUGALIA",
            "SZWECJA",
            "NORWEGIA",
            "TURCJA",
            "ANGLIA",
            "SZKOCJA",
            "IRLANDIA",
            "BUŁGARIA",
            "CHORWACJA",
            "RUMUNIA"});
			this.clientcountrytbl.Location = new System.Drawing.Point(80, 380);
			this.clientcountrytbl.Name = "clientcountrytbl";
			this.clientcountrytbl.Size = new System.Drawing.Size(207, 29);
			this.clientcountrytbl.TabIndex = 4;
			this.clientcountrytbl.Text = "Kraj";
			// 
			// AddBtn
			// 
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddBtn.Location = new System.Drawing.Point(58, 500);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 31);
			this.AddBtn.TabIndex = 6;
			this.AddBtn.Text = "Dodaj";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditBtn.Location = new System.Drawing.Point(148, 500);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(75, 31);
			this.EditBtn.TabIndex = 7;
			this.EditBtn.Text = "Edytuj";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteBtn.Location = new System.Drawing.Point(238, 500);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
			this.DeleteBtn.TabIndex = 8;
			this.DeleteBtn.Text = "Usuń";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// ClientSearchTbl
			// 
			this.ClientSearchTbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ClientSearchTbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.ClientSearchTbl.Location = new System.Drawing.Point(627, 127);
			this.ClientSearchTbl.Multiline = true;
			this.ClientSearchTbl.Name = "ClientSearchTbl";
			this.ClientSearchTbl.PlaceholderText = "Szukaj klienta";
			this.ClientSearchTbl.Size = new System.Drawing.Size(207, 35);
			this.ClientSearchTbl.TabIndex = 9;
			this.ClientSearchTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ClientSearchTbl.TextChanged += new System.EventHandler(this.ClientSearchTbl_TextChanged);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Control;
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
			this.button4.TabIndex = 10;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// ClientGridView
			// 
			this.ClientGridView.AllowUserToResizeColumns = false;
			this.ClientGridView.AllowUserToResizeRows = false;
			this.ClientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ClientGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ClientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClientGridView.Location = new System.Drawing.Point(467, 168);
			this.ClientGridView.Name = "ClientGridView";
			this.ClientGridView.RowHeadersWidth = 50;
			this.ClientGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ClientGridView.RowTemplate.Height = 25;
			this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientGridView.Size = new System.Drawing.Size(552, 362);
			this.ClientGridView.TabIndex = 11;
			this.ClientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellContentClick);
			// 
			// ResetTbl
			// 
			this.ResetTbl.BackColor = System.Drawing.SystemColors.Control;
			this.ResetTbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetTbl.BackgroundImage")));
			this.ResetTbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ResetTbl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ResetTbl.FlatAppearance.BorderSize = 0;
			this.ResetTbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResetTbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ResetTbl.Location = new System.Drawing.Point(881, 127);
			this.ResetTbl.Name = "ResetTbl";
			this.ResetTbl.Size = new System.Drawing.Size(35, 35);
			this.ResetTbl.TabIndex = 12;
			this.ResetTbl.UseVisualStyleBackColor = false;
			this.ResetTbl.Click += new System.EventHandler(this.ResetTbl_Click);
			// 
			// wrocbtn
			// 
			this.wrocbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.wrocbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.wrocbtn.Location = new System.Drawing.Point(148, 550);
			this.wrocbtn.Name = "wrocbtn";
			this.wrocbtn.Size = new System.Drawing.Size(75, 31);
			this.wrocbtn.TabIndex = 28;
			this.wrocbtn.Text = "Wróć";
			this.wrocbtn.UseVisualStyleBackColor = true;
			this.wrocbtn.Click += new System.EventHandler(this.wrocbtn_Click);
			// 
			// ClientInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 643);
			this.Controls.Add(this.wrocbtn);
			this.Controls.Add(this.ResetTbl);
			this.Controls.Add(this.ClientGridView);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.ClientSearchTbl);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.clientcountrytbl);
			this.Controls.Add(this.clientphonetbl);
			this.Controls.Add(this.clientnametbl);
			this.Controls.Add(this.clientidtbl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ClientInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientInfo";
			this.Load += new System.EventHandler(this.ClientInfo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox clientidtbl;
		private System.Windows.Forms.TextBox clientnametbl;
		private System.Windows.Forms.TextBox clientphonetbl;
		private System.Windows.Forms.ComboBox clientcountrytbl;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.TextBox ClientSearchTbl;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridView ClientGridView;
		private System.Windows.Forms.Button ResetTbl;
		private System.Windows.Forms.Button wrocbtn;
		private System.Windows.Forms.Label label6;
	}
}