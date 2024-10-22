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
            btnMatrix = new Button();
            btnSparseMatrix = new Button();
            checkBoxEdge = new CheckBox();
            pictureBox = new PictureBox();
            textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(16, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(385, 343);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // textBox
            // 
            textBox.Location = new Point(482, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(355, 343);
            textBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 443);
            Controls.Add(textBox);
            Controls.Add(pictureBox);
            Controls.Add(checkBoxEdge);
            Controls.Add(btnSparseMatrix);
            Controls.Add(btnMatrix);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMatrix;
        private Button btnSparseMatrix;
        private CheckBox checkBoxEdge;
        public PictureBox pictureBox;
        public TextBox textBox;
    }
}
