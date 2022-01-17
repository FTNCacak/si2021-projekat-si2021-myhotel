
namespace My_Hotel
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Reservations = new System.Windows.Forms.Button();
            this.button_Guests = new System.Windows.Forms.Button();
            this.button_Owners = new System.Windows.Forms.Button();
            this.button_Apartments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(164, 14);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(296, 266);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_Reservations
            // 
            this.button_Reservations.BackColor = System.Drawing.Color.LightGreen;
            this.button_Reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reservations.Location = new System.Drawing.Point(65, 284);
            this.button_Reservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Reservations.Name = "button_Reservations";
            this.button_Reservations.Size = new System.Drawing.Size(468, 62);
            this.button_Reservations.TabIndex = 1;
            this.button_Reservations.Text = "Reservations";
            this.button_Reservations.UseVisualStyleBackColor = false;
            this.button_Reservations.Click += new System.EventHandler(this.button_Reservations_Click);
            // 
            // button_Guests
            // 
            this.button_Guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Guests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guests.Location = new System.Drawing.Point(15, 351);
            this.button_Guests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Guests.Name = "button_Guests";
            this.button_Guests.Size = new System.Drawing.Size(133, 87);
            this.button_Guests.TabIndex = 2;
            this.button_Guests.Text = "Guests";
            this.button_Guests.UseVisualStyleBackColor = false;
            this.button_Guests.Click += new System.EventHandler(this.button_Guests_Click);
            // 
            // button_Owners
            // 
            this.button_Owners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Owners.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Owners.Location = new System.Drawing.Point(465, 351);
            this.button_Owners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Owners.Name = "button_Owners";
            this.button_Owners.Size = new System.Drawing.Size(139, 87);
            this.button_Owners.TabIndex = 3;
            this.button_Owners.Text = "Owners";
            this.button_Owners.UseVisualStyleBackColor = false;
            this.button_Owners.Click += new System.EventHandler(this.button_Owners_Click);
            // 
            // button_Apartments
            // 
            this.button_Apartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Apartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Apartments.Location = new System.Drawing.Point(205, 351);
            this.button_Apartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Apartments.Name = "button_Apartments";
            this.button_Apartments.Size = new System.Drawing.Size(205, 87);
            this.button_Apartments.TabIndex = 4;
            this.button_Apartments.Text = "Apartments";
            this.button_Apartments.UseVisualStyleBackColor = false;
            this.button_Apartments.Click += new System.EventHandler(this.button_Apartments_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(619, 452);
            this.Controls.Add(this.button_Apartments);
            this.Controls.Add(this.button_Owners);
            this.Controls.Add(this.button_Guests);
            this.Controls.Add(this.button_Reservations);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "My Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Reservations;
        private System.Windows.Forms.Button button_Guests;
        private System.Windows.Forms.Button button_Owners;
        private System.Windows.Forms.Button button_Apartments;
    }
}

