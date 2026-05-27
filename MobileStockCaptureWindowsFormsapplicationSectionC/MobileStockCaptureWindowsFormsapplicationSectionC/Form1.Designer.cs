namespace MobileStockCaptureWindowsFormsapplicationSectionC
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblOutput = new TextBox();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            tblMoblePhones = new RichTextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(119, 343);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(267, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 33);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(401, 343);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(87, 36);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 122);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Mobile Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 169);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 222);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(119, 35);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(369, 27);
            lblOutput.TabIndex = 6;
            lblOutput.TextChanged += lblOutput_TextChanged;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(310, 115);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(122, 27);
            txtCode.TabIndex = 7;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(310, 162);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(310, 219);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 9;
            // 
            // tblMoblePhones
            // 
            tblMoblePhones.Location = new Point(604, 150);
            tblMoblePhones.Name = "tblMoblePhones";
            tblMoblePhones.Size = new Size(184, 192);
            tblMoblePhones.TabIndex = 10;
            tblMoblePhones.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMoblePhones);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(lblOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lblOutput;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private RichTextBox tblMoblePhones;
    }
}
