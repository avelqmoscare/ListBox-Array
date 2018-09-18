namespace WindowsFormsApplication1
{
    partial class frmStrings
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
            this.lstHolidaysEnum = new System.Windows.Forms.ListBox();
            this.lstHolidaysStruct = new System.Windows.Forms.ListBox();
            this.btnShowStructResult = new System.Windows.Forms.Button();
            this.btnShowEnumResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHolidaysEnum
            // 
            this.lstHolidaysEnum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstHolidaysEnum.FormattingEnabled = true;
            this.lstHolidaysEnum.Items.AddRange(new object[] {
            "New year",
            "All Saints Day",
            "Labor Day",
            "ChristmasMarikina",
            "Muntinlupa"});
            this.lstHolidaysEnum.Location = new System.Drawing.Point(12, 24);
            this.lstHolidaysEnum.Name = "lstHolidaysEnum";
            this.lstHolidaysEnum.Size = new System.Drawing.Size(132, 95);
            this.lstHolidaysEnum.TabIndex = 0;
            this.lstHolidaysEnum.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstHolidaysStruct
            // 
            this.lstHolidaysStruct.FormattingEnabled = true;
            this.lstHolidaysStruct.Items.AddRange(new object[] {
            "New Year",
            "All Saints Day",
            "Labor Day",
            "ChristmasMarikina",
            "Muntinlupa"});
            this.lstHolidaysStruct.Location = new System.Drawing.Point(150, 24);
            this.lstHolidaysStruct.Name = "lstHolidaysStruct";
            this.lstHolidaysStruct.Size = new System.Drawing.Size(122, 95);
            this.lstHolidaysStruct.TabIndex = 1;
            // 
            // btnShowStructResult
            // 
            this.btnShowStructResult.Location = new System.Drawing.Point(150, 148);
            this.btnShowStructResult.Name = "btnShowStructResult";
            this.btnShowStructResult.Size = new System.Drawing.Size(122, 23);
            this.btnShowStructResult.TabIndex = 2;
            this.btnShowStructResult.Text = "Show Struct Result";
            this.btnShowStructResult.UseVisualStyleBackColor = true;
            this.btnShowStructResult.Click += new System.EventHandler(this.btnShowStructResult_Click_1);
            // 
            // btnShowEnumResult
            // 
            this.btnShowEnumResult.Location = new System.Drawing.Point(12, 148);
            this.btnShowEnumResult.Name = "btnShowEnumResult";
            this.btnShowEnumResult.Size = new System.Drawing.Size(132, 23);
            this.btnShowEnumResult.TabIndex = 3;
            this.btnShowEnumResult.Text = "Show Enum Result";
            this.btnShowEnumResult.UseVisualStyleBackColor = true;
            this.btnShowEnumResult.Click += new System.EventHandler(this.btnShowStructResult_Click);
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnShowEnumResult);
            this.Controls.Add(this.btnShowStructResult);
            this.Controls.Add(this.lstHolidaysStruct);
            this.Controls.Add(this.lstHolidaysEnum);
            this.Name = "frmStrings";
            this.Text = "frmStrings";
            this.Load += new System.EventHandler(this.frmStrings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHolidaysEnum;
        private System.Windows.Forms.ListBox lstHolidaysStruct;
        private System.Windows.Forms.Button btnShowStructResult;
        private System.Windows.Forms.Button btnShowEnumResult;
    }
}

