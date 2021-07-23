
namespace HotelManagement
{
	partial class ReservationInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.Datelbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.ResetTbl = new System.Windows.Forms.Button();
			this.ReservationGridView = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.ReservationSearchTbl = new System.Windows.Forms.TextBox();
			this.reservationidtdl = new System.Windows.Forms.TextBox();
			this.dateinn = new System.Windows.Forms.DateTimePicker();
			this.DateIn = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateout = new System.Windows.Forms.DateTimePicker();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.clientnametbl = new System.Windows.Forms.ComboBox();
			this.roomidtbl = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.wrocbtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
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
			this.label6.TabIndex = 33;
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
			this.label1.Location = new System.Drawing.Point(256, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(624, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informacje o rezerwacjach";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			this.ResetTbl.Location = new System.Drawing.Point(888, 127);
			this.ResetTbl.Name = "ResetTbl";
			this.ResetTbl.Size = new System.Drawing.Size(35, 35);
			this.ResetTbl.TabIndex = 16;
			this.ResetTbl.Text = "Reset";
			this.ResetTbl.UseVisualStyleBackColor = false;
			this.ResetTbl.Click += new System.EventHandler(this.ResetTbl_Click);
			// 
			// ReservationGridView
			// 
			this.ReservationGridView.AllowUserToResizeColumns = false;
			this.ReservationGridView.AllowUserToResizeRows = false;
			this.ReservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ReservationGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ReservationGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.ReservationGridView.Location = new System.Drawing.Point(467, 168);
			this.ReservationGridView.Name = "ReservationGridView";
			this.ReservationGridView.RowHeadersWidth = 50;
			this.ReservationGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ReservationGridView.RowTemplate.Height = 25;
			this.ReservationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ReservationGridView.Size = new System.Drawing.Size(552, 362);
			this.ReservationGridView.TabIndex = 15;
			this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
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
			this.button4.Location = new System.Drawing.Point(847, 127);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 35);
			this.button4.TabIndex = 14;
			this.button4.Text = "Szukaj";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ReservationSearchTbl
			// 
			this.ReservationSearchTbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReservationSearchTbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.ReservationSearchTbl.Location = new System.Drawing.Point(627, 127);
			this.ReservationSearchTbl.Multiline = true;
			this.ReservationSearchTbl.Name = "ReservationSearchTbl";
			this.ReservationSearchTbl.PlaceholderText = "Szukaj rezerwacji";
			this.ReservationSearchTbl.Size = new System.Drawing.Size(217, 35);
			this.ReservationSearchTbl.TabIndex = 13;
			this.ReservationSearchTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// reservationidtdl
			// 
			this.reservationidtdl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.reservationidtdl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.reservationidtdl.Location = new System.Drawing.Point(80, 170);
			this.reservationidtdl.Multiline = true;
			this.reservationidtdl.Name = "reservationidtdl";
			this.reservationidtdl.PlaceholderText = "ID Rezerwacji";
			this.reservationidtdl.Size = new System.Drawing.Size(207, 35);
			this.reservationidtdl.TabIndex = 17;
			this.reservationidtdl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			
			// 
			// dateinn
			// 
			this.dateinn.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateinn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateinn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateinn.Location = new System.Drawing.Point(120, 385);
			this.dateinn.Name = "dateinn";
			this.dateinn.Size = new System.Drawing.Size(117, 27);
			this.dateinn.TabIndex = 20;
			this.dateinn.ValueChanged += new System.EventHandler(this.dateinn_ValueChanged);
			// 
			// DateIn
			// 
			this.DateIn.AutoSize = true;
			this.DateIn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DateIn.ForeColor = System.Drawing.Color.DodgerBlue;
			this.DateIn.Location = new System.Drawing.Point(65, 387);
			this.DateIn.Name = "DateIn";
			this.DateIn.Size = new System.Drawing.Size(39, 23);
			this.DateIn.TabIndex = 21;
			this.DateIn.Text = "Od";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(65, 430);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Do";
			// 
			// dateout
			// 
			this.dateout.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateout.Location = new System.Drawing.Point(120, 428);
			this.dateout.Name = "dateout";
			this.dateout.Size = new System.Drawing.Size(117, 27);
			this.dateout.TabIndex = 22;
			this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DeleteBtn.Location = new System.Drawing.Point(238, 500);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
			this.DeleteBtn.TabIndex = 27;
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
			this.EditBtn.TabIndex = 26;
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
			this.AddBtn.TabIndex = 25;
			this.AddBtn.Text = "Dodaj";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// clientnametbl
			// 
			this.clientnametbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.clientnametbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.clientnametbl.FormattingEnabled = true;
			this.clientnametbl.Location = new System.Drawing.Point(80, 240);
			this.clientnametbl.Name = "clientnametbl";
			this.clientnametbl.Size = new System.Drawing.Size(207, 30);
			this.clientnametbl.TabIndex = 28;
			this.clientnametbl.Text = "Imię klienta";
			// 
			// roomidtbl
			// 
			this.roomidtbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.roomidtbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.roomidtbl.FormattingEnabled = true;
			this.roomidtbl.Location = new System.Drawing.Point(80, 310);
			this.roomidtbl.Name = "roomidtbl";
			this.roomidtbl.Size = new System.Drawing.Size(207, 30);
			this.roomidtbl.TabIndex = 29;
			this.roomidtbl.Text = "ID Pokoju";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(13, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 23);
			this.label3.TabIndex = 30;
			this.label3.Text = "Klient";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label4.Location = new System.Drawing.Point(13, 312);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 31;
			this.label4.Text = "Pokój";
			// 
			// wrocbtn
			// 
			this.wrocbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.wrocbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.wrocbtn.Location = new System.Drawing.Point(148, 550);
			this.wrocbtn.Name = "wrocbtn";
			this.wrocbtn.Size = new System.Drawing.Size(75, 31);
			this.wrocbtn.TabIndex = 32;
			this.wrocbtn.Text = "Wróć";
			this.wrocbtn.UseVisualStyleBackColor = true;
			this.wrocbtn.Click += new System.EventHandler(this.wrocbtn_Click);
			// 
			// ReservationInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 643);
			this.Controls.Add(this.wrocbtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.roomidtbl);
			this.Controls.Add(this.clientnametbl);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateout);
			this.Controls.Add(this.DateIn);
			this.Controls.Add(this.dateinn);
			this.Controls.Add(this.reservationidtdl);
			this.Controls.Add(this.ResetTbl);
			this.Controls.Add(this.ReservationGridView);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.ReservationSearchTbl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReservationInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReservationInfo";
			this.Load += new System.EventHandler(this.ReservationInfo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button ResetTbl;
		private System.Windows.Forms.DataGridView ReservationGridView;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox ReservationSearchTbl;
		private System.Windows.Forms.TextBox reservationidtdl;
		private System.Windows.Forms.DateTimePicker dateinn;
		private System.Windows.Forms.Label DateIn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateout;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.ComboBox clientnametbl;
		private System.Windows.Forms.ComboBox roomidtbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button wrocbtn;
		private System.Windows.Forms.Label label6;
	}
}