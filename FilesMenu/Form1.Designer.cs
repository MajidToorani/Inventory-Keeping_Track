namespace FilesMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonCreate = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxTransactNumber1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxToolPurchased = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxTransactNumber2 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelMessageDisplay = new System.Windows.Forms.Label();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.buttonCloseFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Location = new System.Drawing.Point(38, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Filename";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(1, 19);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(219, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOpen);
            this.groupBox2.Controls.Add(this.radioButtonCreate);
            this.groupBox2.Location = new System.Drawing.Point(270, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Checked = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(116, 18);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(90, 17);
            this.radioButtonOpen.TabIndex = 1;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Open Existing";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreate
            // 
            this.radioButtonCreate.AutoSize = true;
            this.radioButtonCreate.Location = new System.Drawing.Point(6, 20);
            this.radioButtonCreate.Name = "radioButtonCreate";
            this.radioButtonCreate.Size = new System.Drawing.Size(81, 17);
            this.radioButtonCreate.TabIndex = 0;
            this.radioButtonCreate.Text = "Create New";
            this.radioButtonCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxTransactNumber1);
            this.groupBox3.Location = new System.Drawing.Point(39, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 41);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transact #";
            // 
            // textBoxTransactNumber1
            // 
            this.textBoxTransactNumber1.Location = new System.Drawing.Point(0, 15);
            this.textBoxTransactNumber1.Name = "textBoxTransactNumber1";
            this.textBoxTransactNumber1.Size = new System.Drawing.Size(136, 20);
            this.textBoxTransactNumber1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDate);
            this.groupBox4.Location = new System.Drawing.Point(181, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 41);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(1, 15);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(152, 20);
            this.textBoxDate.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSerialNumber);
            this.groupBox5.Location = new System.Drawing.Point(343, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(131, 41);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serial Number";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(1, 15);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(130, 20);
            this.textBoxSerialNumber.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxToolPurchased);
            this.groupBox6.Location = new System.Drawing.Point(480, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 41);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tool Purchased";
            // 
            // textBoxToolPurchased
            // 
            this.textBoxToolPurchased.Location = new System.Drawing.Point(1, 15);
            this.textBoxToolPurchased.Name = "textBoxToolPurchased";
            this.textBoxToolPurchased.Size = new System.Drawing.Size(244, 20);
            this.textBoxToolPurchased.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxPrice);
            this.groupBox7.Location = new System.Drawing.Point(729, 85);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(112, 41);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(3, 14);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(109, 20);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxQty);
            this.groupBox8.Location = new System.Drawing.Point(847, 85);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(79, 41);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Qty";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(1, 13);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(78, 20);
            this.textBoxQty.TabIndex = 0;
            this.textBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxAmount);
            this.groupBox9.Location = new System.Drawing.Point(932, 85);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(136, 41);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(1, 12);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(135, 20);
            this.textBoxAmount.TabIndex = 0;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxTransactNumber2);
            this.groupBox10.Location = new System.Drawing.Point(374, 132);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(131, 36);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Transact #";
            // 
            // textBoxTransactNumber2
            // 
            this.textBoxTransactNumber2.Location = new System.Drawing.Point(0, 13);
            this.textBoxTransactNumber2.Name = "textBoxTransactNumber2";
            this.textBoxTransactNumber2.Size = new System.Drawing.Size(131, 20);
            this.textBoxTransactNumber2.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.richTextBoxDisplay);
            this.groupBox11.Location = new System.Drawing.Point(38, 231);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1030, 283);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Data Display :";
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBoxDisplay.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(1017, 257);
            this.richTextBoxDisplay.TabIndex = 0;
            this.richTextBoxDisplay.Text = "";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelMessageDisplay);
            this.groupBox12.Location = new System.Drawing.Point(38, 561);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1039, 88);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Message display :";
            // 
            // labelMessageDisplay
            // 
            this.labelMessageDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageDisplay.Location = new System.Drawing.Point(6, 25);
            this.labelMessageDisplay.Name = "labelMessageDisplay";
            this.labelMessageDisplay.Size = new System.Drawing.Size(1027, 60);
            this.labelMessageDisplay.TabIndex = 0;
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(39, 143);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(121, 23);
            this.buttonAddData.TabIndex = 12;
            this.buttonAddData.Text = "Write a record";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(166, 143);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(202, 23);
            this.buttonDeleteRecord.TabIndex = 13;
            this.buttonDeleteRecord.Text = "Delete a record by Transact #";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(505, 48);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(154, 31);
            this.buttonCreateFile.TabIndex = 14;
            this.buttonCreateFile.Text = "Create / Open File";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.Location = new System.Drawing.Point(38, 521);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplayData.TabIndex = 15;
            this.buttonDisplayData.Text = "Display Data";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // buttonCloseFile
            // 
            this.buttonCloseFile.Location = new System.Drawing.Point(120, 521);
            this.buttonCloseFile.Name = "buttonCloseFile";
            this.buttonCloseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseFile.TabIndex = 16;
            this.buttonCloseFile.Text = "Close File";
            this.buttonCloseFile.UseVisualStyleBackColor = true;
            this.buttonCloseFile.Click += new System.EventHandler(this.buttonCloseFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(201, 521);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFile.TabIndex = 17;
            this.buttonDeleteFile.Text = "Delete File";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonCloseFile);
            this.Controls.Add(this.buttonDisplayData);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Abc Manufacturing Inc.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.Button buttonCloseFile;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.RadioButton radioButtonCreate;
        private System.Windows.Forms.TextBox textBoxTransactNumber1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxToolPurchased;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxTransactNumber2;
        private System.Windows.Forms.Label labelMessageDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
    }
}

