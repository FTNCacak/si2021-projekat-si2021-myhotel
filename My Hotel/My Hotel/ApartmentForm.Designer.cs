
namespace My_Hotel
{
    partial class ApartmentForm
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
            this.listBox_Apartments = new System.Windows.Forms.ListBox();
            this.label_Adress = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Apartments
            // 
            this.listBox_Apartments.FormattingEnabled = true;
            this.listBox_Apartments.ItemHeight = 16;
            this.listBox_Apartments.Location = new System.Drawing.Point(33, 12);
            this.listBox_Apartments.Name = "listBox_Apartments";
            this.listBox_Apartments.Size = new System.Drawing.Size(565, 132);
            this.listBox_Apartments.TabIndex = 0;
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(44, 198);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(56, 17);
            this.label_Adress.TabIndex = 1;
            this.label_Adress.Text = "Adress:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(44, 234);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 17);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(44, 264);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(44, 17);
            this.label_Price.TabIndex = 3;
            this.label_Price.Text = "Price:";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(120, 193);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 22);
            this.textBox_Adress.TabIndex = 4;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(120, 229);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(100, 22);
            this.textBox_Type.TabIndex = 5;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(120, 259);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 22);
            this.textBox_Price.TabIndex = 6;
            // 
            // Button_Insert
            // 
            this.Button_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Insert.Location = new System.Drawing.Point(459, 193);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(125, 71);
            this.Button_Insert.TabIndex = 10;
            this.Button_Insert.Text = "Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(620, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.listBox_Apartments);
            this.Name = "ApartmentForm";
            this.Text = "Apartments";
            this.Load += new System.EventHandler(this.Apartments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Apartments;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Button button1;
    }
}