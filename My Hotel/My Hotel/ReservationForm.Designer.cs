
namespace My_Hotel
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Reservaions = new System.Windows.Forms.ListBox();
            this.comboBox_Guest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Apartment = new System.Windows.Forms.ComboBox();
            this.label_ChoseApartment = new System.Windows.Forms.Label();
            this.dateTimePicker_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.label_StartingOn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // listBox_Reservaions
            // 
            this.listBox_Reservaions.FormattingEnabled = true;
            this.listBox_Reservaions.ItemHeight = 16;
            this.listBox_Reservaions.Location = new System.Drawing.Point(30, 23);
            this.listBox_Reservaions.Name = "listBox_Reservaions";
            this.listBox_Reservaions.Size = new System.Drawing.Size(728, 164);
            this.listBox_Reservaions.TabIndex = 1;
            // 
            // comboBox_Guest
            // 
            this.comboBox_Guest.FormattingEnabled = true;
            this.comboBox_Guest.Location = new System.Drawing.Point(46, 242);
            this.comboBox_Guest.Name = "comboBox_Guest";
            this.comboBox_Guest.Size = new System.Drawing.Size(184, 24);
            this.comboBox_Guest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chose guest";
            // 
            // comboBox_Apartment
            // 
            this.comboBox_Apartment.FormattingEnabled = true;
            this.comboBox_Apartment.Location = new System.Drawing.Point(46, 295);
            this.comboBox_Apartment.Name = "comboBox_Apartment";
            this.comboBox_Apartment.Size = new System.Drawing.Size(228, 24);
            this.comboBox_Apartment.TabIndex = 4;
            // 
            // label_ChoseApartment
            // 
            this.label_ChoseApartment.AutoSize = true;
            this.label_ChoseApartment.Location = new System.Drawing.Point(59, 275);
            this.label_ChoseApartment.Name = "label_ChoseApartment";
            this.label_ChoseApartment.Size = new System.Drawing.Size(116, 17);
            this.label_ChoseApartment.TabIndex = 5;
            this.label_ChoseApartment.Text = "Chose apartment";
            this.label_ChoseApartment.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker_BeginDate
            // 
            this.dateTimePicker_BeginDate.Location = new System.Drawing.Point(291, 244);
            this.dateTimePicker_BeginDate.Name = "dateTimePicker_BeginDate";
            this.dateTimePicker_BeginDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_BeginDate.TabIndex = 6;
            // 
            // label_StartingOn
            // 
            this.label_StartingOn.AutoSize = true;
            this.label_StartingOn.Location = new System.Drawing.Point(330, 224);
            this.label_StartingOn.Name = "label_StartingOn";
            this.label_StartingOn.Size = new System.Drawing.Size(77, 17);
            this.label_StartingOn.TabIndex = 7;
            this.label_StartingOn.Text = "Starting on";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of days staying:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(226, 334);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deposit:";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(307, 297);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(100, 22);
            this.textBoxPayment.TabIndex = 11;
            // 
            // Button_Insert
            // 
            this.Button_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Insert.Location = new System.Drawing.Point(608, 212);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(125, 71);
            this.Button_Insert.TabIndex = 12;
            this.Button_Insert.Text = "Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(584, 295);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(149, 71);
            this.button_Refresh.TabIndex = 13;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(608, 382);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(125, 71);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_StartingOn);
            this.Controls.Add(this.dateTimePicker_BeginDate);
            this.Controls.Add(this.label_ChoseApartment);
            this.Controls.Add(this.comboBox_Apartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Guest);
            this.Controls.Add(this.listBox_Reservaions);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Reservaions;
        private System.Windows.Forms.ComboBox comboBox_Guest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Apartment;
        private System.Windows.Forms.Label label_ChoseApartment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BeginDate;
        private System.Windows.Forms.Label label_StartingOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Delete;
    }
}