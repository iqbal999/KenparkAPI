namespace KenparyWinforms
{
    partial class EmployeeForm
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
            label1 = new Label();
            TxtIdNumber = new TextBox();
            TxtCN = new TextBox();
            label2 = new Label();
            TxtAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CmbActiveStatus = new ComboBox();
            BtnAction = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Number";
            // 
            // TxtIdNumber
            // 
            TxtIdNumber.Location = new Point(132, 22);
            TxtIdNumber.Name = "TxtIdNumber";
            TxtIdNumber.Size = new Size(209, 23);
            TxtIdNumber.TabIndex = 1;
            // 
            // TxtCN
            // 
            TxtCN.Location = new Point(132, 51);
            TxtCN.Name = "TxtCN";
            TxtCN.Size = new Size(209, 23);
            TxtCN.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 54);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Contact Number";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(132, 80);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(209, 23);
            TxtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 112);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Active Status";
            // 
            // CmbActiveStatus
            // 
            CmbActiveStatus.FormattingEnabled = true;
            CmbActiveStatus.Items.AddRange(new object[] { "Active", "InActive" });
            CmbActiveStatus.Location = new Point(132, 109);
            CmbActiveStatus.Name = "CmbActiveStatus";
            CmbActiveStatus.Size = new Size(209, 23);
            CmbActiveStatus.TabIndex = 7;
            // 
            // BtnAction
            // 
            BtnAction.Location = new Point(266, 138);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new Size(75, 23);
            BtnAction.TabIndex = 8;
            BtnAction.Text = "Save";
            BtnAction.UseVisualStyleBackColor = true;
            BtnAction.Click += BtnAction_Click;
            // 
            // button1
            // 
            button1.Location = new Point(185, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Load All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(528, 174);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(BtnAction);
            Controls.Add(CmbActiveStatus);
            Controls.Add(label4);
            Controls.Add(TxtAddress);
            Controls.Add(label3);
            Controls.Add(TxtCN);
            Controls.Add(label2);
            Controls.Add(TxtIdNumber);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtIdNumber;
        private TextBox TxtCN;
        private Label label2;
        private TextBox TxtAddress;
        private Label label3;
        private Label label4;
        private ComboBox CmbActiveStatus;
        private Button BtnAction;
        private Button button1;
        private DataGridView dataGridView1;
    }
}