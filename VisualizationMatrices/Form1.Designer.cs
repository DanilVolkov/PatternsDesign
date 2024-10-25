﻿namespace VisualizationMatrices
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnMatrix
            // 
            btnMatrix.Location = new Point(16, 380);
            btnMatrix.Name = "btnMatrix";
            btnMatrix.Size = new Size(278, 34);
            btnMatrix.TabIndex = 0;
            btnMatrix.Text = "Генерация обычной матрицы";
            btnMatrix.UseVisualStyleBackColor = true;
            btnMatrix.Click += btnGenerateMatrix;
            // 
            // btnSparseMatrix
            // 
            btnSparseMatrix.Location = new Point(314, 380);
            btnSparseMatrix.Name = "btnSparseMatrix";
            btnSparseMatrix.Size = new Size(309, 34);
            btnSparseMatrix.TabIndex = 1;
            btnSparseMatrix.Text = "Генерация разреженной матрицы";
            btnSparseMatrix.UseVisualStyleBackColor = true;
            btnSparseMatrix.Click += btnSparseMatrix_Click;
            // 
            // checkBoxEdge
            // 
            checkBoxEdge.AutoSize = true;
            checkBoxEdge.Location = new Point(652, 384);
            checkBoxEdge.Name = "checkBoxEdge";
            checkBoxEdge.Size = new Size(185, 29);
            checkBoxEdge.TabIndex = 2;
            checkBoxEdge.Text = "Граница матрицы";
            checkBoxEdge.UseVisualStyleBackColor = true;
            checkBoxEdge.CheckedChanged += checkBoxEdge_CheckedChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(482, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(355, 343);
            textBox.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
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
            dataGridView.Location = new Point(16, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(377, 343);
            dataGridView.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 443);
            Controls.Add(dataGridView);
            Controls.Add(textBox);
            Controls.Add(checkBoxEdge);
            Controls.Add(btnSparseMatrix);
            Controls.Add(btnMatrix);
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
        public TextBox textBox;
        public DataGridView dataGridView;
    }
}