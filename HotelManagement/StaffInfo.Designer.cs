
namespace HotelManagement
{
	partial class StaffInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfo));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.Datelbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.staffphonetbl = new System.Windows.Forms.TextBox();
			this.staffnametbl = new System.Windows.Forms.TextBox();
			this.staffidtbl = new System.Windows.Forms.TextBox();
			this.staffgendertbl = new System.Windows.Forms.ComboBox();
			this.StaffGridView = new System.Windows.Forms.DataGridView();
			this.ResetTbl = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.StaffSearchTbl = new System.Windows.Forms.TextBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.passwordtbl = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.wrocbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
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
			this.panel1.TabIndex = 1;
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
			this.label1.Location = new System.Drawing.Point(242, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(637, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informacje o pracownikach";
			// 
			// staffphonetbl
			// 
			this.staffphonetbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.staffphonetbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.staffphonetbl.Location = new System.Drawing.Point(80, 310);
			this.staffphonetbl.Multiline = true;
			this.staffphonetbl.Name = "staffphonetbl";
			this.staffphonetbl.PlaceholderText = "Numer Telefonu";
			this.staffphonetbl.Size = new System.Drawing.Size(207, 35);
			this.staffphonetbl.TabIndex = 6;
			this.staffphonetbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// staffnametbl
			// 
			this.staffnametbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.staffnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.staffnametbl.Location = new System.Drawing.Point(80, 240);
			this.staffnametbl.Multiline = true;
			this.staffnametbl.Name = "staffnametbl";
			this.staffnametbl.PlaceholderText = "Imie";
			this.staffnametbl.Size = new System.Drawing.Size(207, 35);
			this.staffnametbl.TabIndex = 5;
			this.staffnametbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// staffidtbl
			// 
			this.staffidtbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.staffidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.staffidtbl.Location = new System.Drawing.Point(80, 170);
			this.staffidtbl.Multiline = true;
			this.staffidtbl.Name = "staffidtbl";
			this.staffidtbl.PlaceholderText = "ID Pracownika";
			this.staffidtbl.Size = new System.Drawing.Size(207, 35);
			this.staffidtbl.TabIndex = 4;
			this.staffidtbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.staffidtbl.TextChanged += new System.EventHandler(this.staffidtbl_TextChanged);
			// 
			// staffgendertbl
			// 
			this.staffgendertbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.staffgendertbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.staffgendertbl.FormattingEnabled = true;
			this.staffgendertbl.Items.AddRange(new object[] {
            "Mężczyzna",
            "Kobieta"});
			this.staffgendertbl.Location = new System.Drawing.Point(80, 450);
			this.staffgendertbl.Name = "staffgendertbl";
			this.staffgendertbl.Size = new System.Drawing.Size(207, 29);
			this.staffgendertbl.TabIndex = 7;
			this.staffgendertbl.Text = "Płeć";
			// 
			// StaffGridView
			// 
			this.StaffGridView.AllowUserToResizeColumns = false;
			this.StaffGridView.AllowUserToResizeRows = false;
			this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.StaffGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.StaffGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.StaffGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.StaffGridView.Location = new System.Drawing.Point(467, 168);
			this.StaffGridView.Name = "StaffGridView";
			this.StaffGridView.RowHeadersWidth = 50;
			this.StaffGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.StaffGridView.RowTemplate.Height = 25;
			this.StaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StaffGridView.Size = new System.Drawing.Size(552, 362);
			this.StaffGridView.TabIndex = 12;
			this.StaffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGridView_CellContentClick);
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
			this.ResetTbl.TabIndex = 15;
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
			this.button4.TabIndex = 14;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// StaffSearchTbl
			// 
			this.StaffSearchTbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StaffSearchTbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.StaffSearchTbl.Location = new System.Drawing.Point(627, 127);
			this.StaffSearchTbl.Multiline = true;
			this.StaffSearchTbl.Name = "StaffSearchTbl";
			this.StaffSearchTbl.PlaceholderText = "Szukaj pracownika";
			this.StaffSearchTbl.Size = new System.Drawing.Size(207, 35);
			this.StaffSearchTbl.TabIndex = 13;
			this.StaffSearchTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteBtn.Location = new System.Drawing.Point(238, 500);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
			this.DeleteBtn.TabIndex = 18;
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
			this.EditBtn.TabIndex = 17;
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
			this.AddBtn.TabIndex = 16;
			this.AddBtn.Text = "Dodaj";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// passwordtbl
			// 
			this.passwordtbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordtbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.passwordtbl.Location = new System.Drawing.Point(80, 380);
			this.passwordtbl.Multiline = true;
			this.passwordtbl.Name = "passwordtbl";
			this.passwordtbl.PlaceholderText = "Hasło";
			this.passwordtbl.Size = new System.Drawing.Size(207, 35);
			this.passwordtbl.TabIndex = 19;
			this.passwordtbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
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
			// StaffInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 643);
			this.Controls.Add(this.wrocbtn);
			this.Controls.Add(this.passwordtbl);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.ResetTbl);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.StaffSearchTbl);
			this.Controls.Add(this.StaffGridView);
			this.Controls.Add(this.staffgendertbl);
			this.Controls.Add(this.staffphonetbl);
			this.Controls.Add(this.staffnametbl);
			this.Controls.Add(this.staffidtbl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StaffInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StaffInfo";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox staffphonetbl;
		private System.Windows.Forms.TextBox staffnametbl;
		private System.Windows.Forms.TextBox staffidtbl;
		private System.Windows.Forms.ComboBox staffgendertbl;
		private System.Windows.Forms.DataGridView StaffGridView;
		private System.Windows.Forms.Button ResetTbl;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox StaffSearchTbl;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox passwordtbl;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button wrocbtn;
		private System.Windows.Forms.Label label6;
	}
}