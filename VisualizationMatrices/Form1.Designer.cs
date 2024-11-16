namespace VisualizationMatrices
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnMatrix = new Button();
            btnSparseMatrix = new Button();
            checkBoxEdge = new CheckBox();
            textBox = new TextBox();
            dataGridView = new DataGridView();
            renum = new Button();
            recover = new Button();
            btnHGroupMatrix = new Button();
            lblVGroup = new Label();
            btnHGroupSparseMatrix = new Button();
            lblHGroup = new Label();
            btnVGroupMatrix = new Button();
            btnVGroupSparseMatrix = new Button();
            label1 = new Label();
            lblChange = new Label();
            btnChange = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnMatrix
            // 
            btnMatrix.Location = new Point(10, 402);
            btnMatrix.Margin = new Padding(2, 2, 2, 2);
            btnMatrix.Name = "btnMatrix";
            btnMatrix.Size = new Size(195, 20);
            btnMatrix.TabIndex = 0;
            btnMatrix.Text = "Генерация обычной матрицы";
            btnMatrix.UseVisualStyleBackColor = true;
            btnMatrix.Click += btnGenerateMatrix;
            // 
            // btnSparseMatrix
            // 
            btnSparseMatrix.Location = new Point(219, 402);
            btnSparseMatrix.Margin = new Padding(2, 2, 2, 2);
            btnSparseMatrix.Name = "btnSparseMatrix";
            btnSparseMatrix.Size = new Size(216, 20);
            btnSparseMatrix.TabIndex = 1;
            btnSparseMatrix.Text = "Генерация разреженной матрицы";
            btnSparseMatrix.UseVisualStyleBackColor = true;
            btnSparseMatrix.Click += btnSparseMatrix_Click;
            // 
            // checkBoxEdge
            // 
            checkBoxEdge.AutoSize = true;
            checkBoxEdge.Location = new Point(456, 404);
            checkBoxEdge.Margin = new Padding(2, 2, 2, 2);
            checkBoxEdge.Name = "checkBoxEdge";
            checkBoxEdge.Size = new Size(125, 19);
            checkBoxEdge.TabIndex = 2;
            checkBoxEdge.Text = "Граница матрицы";
            checkBoxEdge.UseVisualStyleBackColor = true;
            checkBoxEdge.CheckedChanged += checkBoxEdge_CheckedChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(337, 7);
            textBox.Margin = new Padding(2, 2, 2, 2);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(250, 207);
            textBox.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Location = new Point(11, 7);
            dataGridView.Margin = new Padding(2, 2, 2, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(264, 206);
            dataGridView.TabIndex = 5;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // renum
            // 
            renum.Enabled = false;
            renum.Location = new Point(11, 376);
            renum.Margin = new Padding(2, 2, 2, 2);
            renum.Name = "renum";
            renum.Size = new Size(194, 20);
            renum.TabIndex = 6;
            renum.Text = "Перенумеровать";
            renum.UseVisualStyleBackColor = true;
            renum.Click += renum_Click;
            // 
            // recover
            // 
            recover.Enabled = false;
            recover.Location = new Point(219, 376);
            recover.Margin = new Padding(2, 2, 2, 2);
            recover.Name = "recover";
            recover.Size = new Size(216, 20);
            recover.TabIndex = 7;
            recover.Text = "Восстановить";
            recover.UseVisualStyleBackColor = true;
            recover.Click += recover_Click;
            // 
            // btnHGroupMatrix
            // 
            btnHGroupMatrix.Location = new Point(10, 285);
            btnHGroupMatrix.Margin = new Padding(2, 2, 2, 2);
            btnHGroupMatrix.Name = "btnHGroupMatrix";
            btnHGroupMatrix.Size = new Size(195, 20);
            btnHGroupMatrix.TabIndex = 8;
            btnHGroupMatrix.Text = "Генерация обычной группы";
            btnHGroupMatrix.UseVisualStyleBackColor = true;
            btnHGroupMatrix.Click += btnHGroupMatrix_Click;
            // 
            // lblVGroup
            // 
            lblVGroup.AutoSize = true;
            lblVGroup.Location = new Point(92, 266);
            lblVGroup.Margin = new Padding(2, 0, 2, 0);
            lblVGroup.Name = "lblVGroup";
            lblVGroup.Size = new Size(246, 15);
            lblVGroup.TabIndex = 9;
            lblVGroup.Text = "Генерация горизонтальной группы матриц";
            // 
            // btnHGroupSparseMatrix
            // 
            btnHGroupSparseMatrix.Location = new Point(218, 285);
            btnHGroupSparseMatrix.Margin = new Padding(2, 2, 2, 2);
            btnHGroupSparseMatrix.Name = "btnHGroupSparseMatrix";
            btnHGroupSparseMatrix.Size = new Size(218, 20);
            btnHGroupSparseMatrix.TabIndex = 10;
            btnHGroupSparseMatrix.Text = "Генерация разреженной группы";
            btnHGroupSparseMatrix.UseVisualStyleBackColor = true;
            btnHGroupSparseMatrix.Click += btnHGroupSparseMatrix_Click;
            // 
            // lblHGroup
            // 
            lblHGroup.AutoSize = true;
            lblHGroup.Location = new Point(92, 313);
            lblHGroup.Margin = new Padding(2, 0, 2, 0);
            lblHGroup.Name = "lblHGroup";
            lblHGroup.Size = new Size(245, 15);
            lblHGroup.TabIndex = 11;
            lblHGroup.Text = "Генеризация вертикальной группы матриц";
            // 
            // btnVGroupMatrix
            // 
            btnVGroupMatrix.Location = new Point(13, 335);
            btnVGroupMatrix.Margin = new Padding(2, 2, 2, 2);
            btnVGroupMatrix.Name = "btnVGroupMatrix";
            btnVGroupMatrix.Size = new Size(192, 20);
            btnVGroupMatrix.TabIndex = 12;
            btnVGroupMatrix.Text = "Генерация обычной группы";
            btnVGroupMatrix.UseVisualStyleBackColor = true;
            btnVGroupMatrix.Click += btnVGroupMatrix_Click;
            // 
            // btnVGroupSparseMatrix
            // 
            btnVGroupSparseMatrix.Location = new Point(219, 335);
            btnVGroupSparseMatrix.Margin = new Padding(2, 2, 2, 2);
            btnVGroupSparseMatrix.Name = "btnVGroupSparseMatrix";
            btnVGroupSparseMatrix.Size = new Size(216, 20);
            btnVGroupSparseMatrix.TabIndex = 13;
            btnVGroupSparseMatrix.Text = "Генерация разреженной группы";
            btnVGroupSparseMatrix.UseVisualStyleBackColor = true;
            btnVGroupSparseMatrix.Click += btnVGroupSparseMatrix_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 359);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 15);
            label1.TabIndex = 14;
            label1.Text = "______________________________________________________________________________________";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(135, 223);
            lblChange.Margin = new Padding(2, 0, 2, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(167, 15);
            lblChange.TabIndex = 15;
            lblChange.Text = "Механизм отмены операций";
            // 
            // btnChange
            // 
            btnChange.Enabled = false;
            btnChange.Location = new Point(13, 244);
            btnChange.Margin = new Padding(2, 2, 2, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(192, 20);
            btnChange.TabIndex = 16;
            btnChange.Text = "Изменить";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(219, 244);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(216, 20);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 430);
            Controls.Add(btnCancel);
            Controls.Add(btnChange);
            Controls.Add(lblChange);
            Controls.Add(label1);
            Controls.Add(btnVGroupSparseMatrix);
            Controls.Add(btnVGroupMatrix);
            Controls.Add(lblHGroup);
            Controls.Add(btnHGroupSparseMatrix);
            Controls.Add(lblVGroup);
            Controls.Add(btnHGroupMatrix);
            Controls.Add(recover);
            Controls.Add(renum);
            Controls.Add(dataGridView);
            Controls.Add(textBox);
            Controls.Add(checkBoxEdge);
            Controls.Add(btnSparseMatrix);
            Controls.Add(btnMatrix);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMatrix;
        private Button btnSparseMatrix;
        private CheckBox checkBoxEdge;
        private TextBox textBox;
        private DataGridView dataGridView;
        private Button renum;
        private Button recover;
        private Button btnHGroupMatrix;
        private Label lblVGroup;
        private Button btnHGroupSparseMatrix;
        private Label lblHGroup;
        private Button btnVGroupMatrix;
        private Button btnVGroupSparseMatrix;
        private Label label1;
        private Label lblChange;
        private Button btnChange;
        private Button btnCancel;
    }
}
