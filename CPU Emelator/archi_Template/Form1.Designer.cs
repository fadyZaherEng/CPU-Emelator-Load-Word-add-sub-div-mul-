namespace archi_Template
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
            this.runCycleBtn = new System.Windows.Forms.Button();
            this.StartPc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.initialBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MemoryGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PiplineGridRegister = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GridRegister = new System.Windows.Forms.DataGridView();
            this.registerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCodeIns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGridRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // runCycleBtn
            // 
            this.runCycleBtn.Location = new System.Drawing.Point(533, 434);
            this.runCycleBtn.Name = "runCycleBtn";
            this.runCycleBtn.Size = new System.Drawing.Size(145, 57);
            this.runCycleBtn.TabIndex = 23;
            this.runCycleBtn.Text = "Run 1 cycle";
            this.runCycleBtn.UseVisualStyleBackColor = true;
            this.runCycleBtn.Click += new System.EventHandler(this.runCycleBtn_Click);
            // 
            // StartPc
            // 
            this.StartPc.Location = new System.Drawing.Point(49, 450);
            this.StartPc.Name = "StartPc";
            this.StartPc.Size = new System.Drawing.Size(100, 20);
            this.StartPc.TabIndex = 21;
            this.StartPc.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "PC:";
            // 
            // initialBtn
            // 
            this.initialBtn.Location = new System.Drawing.Point(249, 434);
            this.initialBtn.Name = "initialBtn";
            this.initialBtn.Size = new System.Drawing.Size(145, 57);
            this.initialBtn.TabIndex = 22;
            this.initialBtn.Text = "Inisialize";
            this.initialBtn.UseVisualStyleBackColor = true;
            this.initialBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data memory";
            // 
            // MemoryGridView
            // 
            this.MemoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.MemoryGridView.Location = new System.Drawing.Point(959, 55);
            this.MemoryGridView.Name = "MemoryGridView";
            this.MemoryGridView.ReadOnly = true;
            this.MemoryGridView.Size = new System.Drawing.Size(201, 373);
            this.MemoryGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pipline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "MIPS registers";
            // 
            // PiplineGridRegister
            // 
            this.PiplineGridRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiplineGridRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PiplineGridRegister.Location = new System.Drawing.Point(603, 55);
            this.PiplineGridRegister.Name = "PiplineGridRegister";
            this.PiplineGridRegister.ReadOnly = true;
            this.PiplineGridRegister.Size = new System.Drawing.Size(350, 373);
            this.PiplineGridRegister.TabIndex = 14;
            this.PiplineGridRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PiplineGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Register";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "user code";
            // 
            // GridRegister
            // 
            this.GridRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerCol,
            this.valueCol});
            this.GridRegister.Location = new System.Drawing.Point(362, 55);
            this.GridRegister.Name = "GridRegister";
            this.GridRegister.ReadOnly = true;
            this.GridRegister.Size = new System.Drawing.Size(222, 373);
            this.GridRegister.TabIndex = 13;
            this.GridRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MipsRegisterGrid_CellContentClick);
            // 
            // registerCol
            // 
            this.registerCol.HeaderText = "Register";
            this.registerCol.Name = "registerCol";
            this.registerCol.ReadOnly = true;
            this.registerCol.Width = 70;
            // 
            // valueCol
            // 
            this.valueCol.HeaderText = "Value";
            this.valueCol.Name = "valueCol";
            this.valueCol.ReadOnly = true;
            this.valueCol.Width = 120;
            // 
            // UserCodeIns
            // 
            this.UserCodeIns.Location = new System.Drawing.Point(16, 55);
            this.UserCodeIns.Multiline = true;
            this.UserCodeIns.Name = "UserCodeIns";
            this.UserCodeIns.Size = new System.Drawing.Size(311, 373);
            this.UserCodeIns.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 525);
            this.Controls.Add(this.runCycleBtn);
            this.Controls.Add(this.StartPc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.initialBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemoryGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PiplineGridRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridRegister);
            this.Controls.Add(this.UserCodeIns);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGridRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runCycleBtn;
        private System.Windows.Forms.TextBox StartPc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button initialBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MemoryGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PiplineGridRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridRegister;
        private System.Windows.Forms.TextBox UserCodeIns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueCol;
    }
}

