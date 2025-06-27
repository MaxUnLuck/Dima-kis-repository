namespace MatrixNegativeElements
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(20, 20);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(101, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Количество строк:";
            // 
            // txtRows
            // 
            this.txtRows.BackColor = System.Drawing.Color.PowderBlue;
            this.txtRows.Location = new System.Drawing.Point(150, 50);
            this.txtRows.Multiline = true;
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(158, 23);
            this.txtRows.TabIndex = 1;
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(20, 50);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(119, 13);
            this.lblCols.TabIndex = 2;
            this.lblCols.Text = "Количество столбцов:";
            // 
            // txtCols
            // 
            this.txtCols.BackColor = System.Drawing.Color.PowderBlue;
            this.txtCols.Location = new System.Drawing.Point(150, 20);
            this.txtCols.Multiline = true;
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(158, 23);
            this.txtCols.TabIndex = 3;
            this.txtCols.TextChanged += new System.EventHandler(this.txtCols_TextChanged);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(13, 90);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(131, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Минимальное значение:";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMin.Location = new System.Drawing.Point(150, 87);
            this.txtMin.Multiline = true;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(158, 24);
            this.txtMin.TabIndex = 5;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 120);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(137, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Максимальное значение:";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMax.Location = new System.Drawing.Point(150, 117);
            this.txtMax.Multiline = true;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(158, 24);
            this.txtMax.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGenerate.Location = new System.Drawing.Point(355, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(254, 56);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Сгенерировать матрицу";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCount.Location = new System.Drawing.Point(355, 87);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(254, 59);
            this.btnCount.TabIndex = 9;
            this.btnCount.Text = "Подсчитать отрицательные";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatrix.BackColor = System.Drawing.Color.MediumPurple;
            this.txtMatrix.Font = new System.Drawing.Font("Courier New", 10F);
            this.errorProvider.SetIconAlignment(this.txtMatrix, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.txtMatrix.Location = new System.Drawing.Point(23, 154);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(586, 402);
            this.txtMatrix.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 572);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Результат:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 503);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1050, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblRows);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Подсчет отрицательных элементов в матрице";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}