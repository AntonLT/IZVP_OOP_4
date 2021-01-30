namespace IZVP_OOP_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_AutoCode = new System.Windows.Forms.Label();
            this.textBox_AutoCode = new System.Windows.Forms.TextBox();
            this.textBox_Color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Names = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я власника";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(12, 39);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(154, 26);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(12, 98);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(154, 26);
            this.textBox_LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(12, 216);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(154, 26);
            this.textBox_Model.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Модель";
            // 
            // label_AutoCode
            // 
            this.label_AutoCode.Location = new System.Drawing.Point(12, 127);
            this.label_AutoCode.Name = "label_AutoCode";
            this.label_AutoCode.Size = new System.Drawing.Size(154, 27);
            this.label_AutoCode.TabIndex = 4;
            this.label_AutoCode.Text = "Номер ауто";
            // 
            // textBox_AutoCode
            // 
            this.textBox_AutoCode.Location = new System.Drawing.Point(12, 157);
            this.textBox_AutoCode.Name = "textBox_AutoCode";
            this.textBox_AutoCode.Size = new System.Drawing.Size(154, 26);
            this.textBox_AutoCode.TabIndex = 5;
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(12, 275);
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.Size = new System.Drawing.Size(154, 26);
            this.textBox_Color.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Колір";
            // 
            // listBox_Names
            // 
            this.listBox_Names.FormattingEnabled = true;
            this.listBox_Names.ItemHeight = 20;
            this.listBox_Names.Location = new System.Drawing.Point(190, 14);
            this.listBox_Names.Name = "listBox_Names";
            this.listBox_Names.Size = new System.Drawing.Size(219, 244);
            this.listBox_Names.TabIndex = 8;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(315, 274);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 29);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(190, 274);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(97, 29);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Додати";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 318);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.listBox_Names);
            this.Controls.Add(this.textBox_Color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_AutoCode);
            this.Controls.Add(this.label_AutoCode);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Автощось";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox_Names;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_AutoCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_AutoCode;
        private System.Windows.Forms.TextBox textBox_Color;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FirstName;

        #endregion
    }
}