﻿namespace HRSystem.form
{
    partial class rpttimetable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnprint = new DevComponents.DotNetBar.ButtonX();
            this.btnshow = new DevComponents.DotNetBar.ButtonX();
            this.dateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpersonalCardTo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpersonalCardFrom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this._timeTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._personalCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timetable = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this._onduty = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._offduty = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._clockIn = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this._clockOut = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpersonalCardTo);
            this.groupBox1.Controls.Add(this.txtpersonalCardFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายงานเวลาทำงาน";
            // 
            // btnprint
            // 
            this.btnprint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprint.Location = new System.Drawing.Point(682, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(73, 48);
            this.btnprint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "พิมพ์";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnshow
            // 
            this.btnshow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnshow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnshow.Location = new System.Drawing.Point(602, 19);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(73, 48);
            this.btnshow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnshow.TabIndex = 5;
            this.btnshow.Text = "แสดง";
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dateTo
            // 
            // 
            // 
            // 
            this.dateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTo.ButtonDropDown.Visible = true;
            this.dateTo.Location = new System.Drawing.Point(396, 47);
            // 
            // 
            // 
            this.dateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTo.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.dateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTo.MonthCalendar.TodayButtonVisible = true;
            this.dateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTo.Name = "dateTo";
            this.dateTo.ShowUpDown = true;
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTo.TabIndex = 4;
            // 
            // dateFrom
            // 
            // 
            // 
            // 
            this.dateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateFrom.ButtonDropDown.Visible = true;
            this.dateFrom.Location = new System.Drawing.Point(118, 47);
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateFrom.MonthCalendar.BackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this.dateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShowUpDown = true;
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateFrom.TabIndex = 3;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ถึง :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ถึงวันที่ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ตั้งแต่วันที่ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "รหัสพนักงานเริ่มต้น :";
            // 
            // txtpersonalCardTo
            // 
            // 
            // 
            // 
            this.txtpersonalCardTo.Border.Class = "TextBoxBorder";
            this.txtpersonalCardTo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpersonalCardTo.ButtonCustom.Visible = true;
            this.txtpersonalCardTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpersonalCardTo.Location = new System.Drawing.Point(396, 19);
            this.txtpersonalCardTo.Name = "txtpersonalCardTo";
            this.txtpersonalCardTo.Size = new System.Drawing.Size(86, 22);
            this.txtpersonalCardTo.TabIndex = 2;
            this.txtpersonalCardTo.ButtonCustomClick += new System.EventHandler(this.txtpersonalCardTo_ButtonCustomClick);
            // 
            // txtpersonalCardFrom
            // 
            // 
            // 
            // 
            this.txtpersonalCardFrom.Border.Class = "TextBoxBorder";
            this.txtpersonalCardFrom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpersonalCardFrom.ButtonCustom.Visible = true;
            this.txtpersonalCardFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpersonalCardFrom.Location = new System.Drawing.Point(118, 19);
            this.txtpersonalCardFrom.Name = "txtpersonalCardFrom";
            this.txtpersonalCardFrom.Size = new System.Drawing.Size(86, 22);
            this.txtpersonalCardFrom.TabIndex = 1;
            this.txtpersonalCardFrom.ButtonCustomClick += new System.EventHandler(this.txtpersonalCardFrom_ButtonCustomClick);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._timeTableID,
            this._personalCard,
            this._timetable,
            this._onduty,
            this._offduty,
            this._clockIn,
            this._clockOut});
            this.dgv1.Location = new System.Drawing.Point(13, 103);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(760, 329);
            this.dgv1.TabIndex = 33;
            // 
            // _timeTableID
            // 
            this._timeTableID.DataPropertyName = "timeTableID";
            this._timeTableID.HeaderText = "_timeTableID";
            this._timeTableID.Name = "_timeTableID";
            this._timeTableID.ReadOnly = true;
            this._timeTableID.Visible = false;
            // 
            // _personalCard
            // 
            this._personalCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._personalCard.DataPropertyName = "personalCard";
            this._personalCard.HeaderText = "รหัสบัตรพนักงาน";
            this._personalCard.Name = "_personalCard";
            this._personalCard.ReadOnly = true;
            // 
            // _timetable
            // 
            this._timetable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._timetable.DataPropertyName = "timetable";
            this._timetable.HeaderText = "วันที่";
            this._timetable.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this._timetable.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._timetable.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this._timetable.MonthCalendar.BackgroundStyle.Class = "";
            this._timetable.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this._timetable.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this._timetable.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._timetable.MonthCalendar.DisplayMonth = new System.DateTime(2013, 11, 1, 0, 0, 0, 0);
            this._timetable.MonthCalendar.MarkedDates = new System.DateTime[0];
            this._timetable.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._timetable.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this._timetable.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._timetable.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this._timetable.Name = "_timetable";
            this._timetable.ReadOnly = true;
            this._timetable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._timetable.ShowUpDown = true;
            // 
            // _onduty
            // 
            this._onduty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._onduty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._onduty.BackgroundStyle.Class = "TextBoxBorder";
            this._onduty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._onduty.Culture = new System.Globalization.CultureInfo("en-US");
            this._onduty.DataPropertyName = "onduty";
            this._onduty.ForeColor = System.Drawing.SystemColors.ControlText;
            this._onduty.HeaderText = "เวลาเริ่มงาน";
            this._onduty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._onduty.Mask = "##:##";
            this._onduty.Name = "_onduty";
            this._onduty.PasswordChar = '\0';
            this._onduty.ReadOnly = true;
            this._onduty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._onduty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._onduty.Text = "  :";
            // 
            // _offduty
            // 
            this._offduty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._offduty.BackgroundStyle.Class = "TextBoxBorder";
            this._offduty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._offduty.Culture = new System.Globalization.CultureInfo("en-US");
            this._offduty.DataPropertyName = "offduty";
            this._offduty.ForeColor = System.Drawing.SystemColors.ControlText;
            this._offduty.HeaderText = "เวลาเลิกงาน";
            this._offduty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._offduty.Mask = "##:##";
            this._offduty.Name = "_offduty";
            this._offduty.PasswordChar = '\0';
            this._offduty.ReadOnly = true;
            this._offduty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._offduty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._offduty.Text = "  :";
            // 
            // _clockIn
            // 
            this._clockIn.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._clockIn.BackgroundStyle.Class = "TextBoxBorder";
            this._clockIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._clockIn.Culture = new System.Globalization.CultureInfo("en-US");
            this._clockIn.DataPropertyName = "clockIn";
            this._clockIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this._clockIn.HeaderText = "ลงเวลาเข้า";
            this._clockIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._clockIn.Mask = "##:##";
            this._clockIn.Name = "_clockIn";
            this._clockIn.PasswordChar = '\0';
            this._clockIn.ReadOnly = true;
            this._clockIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._clockIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._clockIn.Text = "  :";
            // 
            // _clockOut
            // 
            this._clockOut.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this._clockOut.BackgroundStyle.Class = "TextBoxBorder";
            this._clockOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._clockOut.Culture = new System.Globalization.CultureInfo("en-US");
            this._clockOut.DataPropertyName = "clockOut";
            this._clockOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this._clockOut.HeaderText = "ลงเวลาออก";
            this._clockOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._clockOut.Mask = "##:##";
            this._clockOut.Name = "_clockOut";
            this._clockOut.PasswordChar = '\0';
            this._clockOut.ReadOnly = true;
            this._clockOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._clockOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._clockOut.Text = "  :";
            // 
            // rpttimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 444);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "rpttimetable";
            this.Text = "รายงานเวลาทำงาน";
            this.Load += new System.EventHandler(this.rpttimetable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpersonalCardTo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpersonalCardFrom;
        private DevComponents.DotNetBar.ButtonX btnshow;
        private DevComponents.DotNetBar.ButtonX btnprint;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _personalCard;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn _timetable;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _onduty;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _offduty;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _clockIn;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn _clockOut;
    }
}