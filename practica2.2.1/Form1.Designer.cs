namespace practica2._2._1
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
            textBoxX = new TextBox();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            buttonCalculate = new Button();
            label1 = new Label();
            dataGridViewResults = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lable5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(133, 101);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 0;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(133, 145);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 1;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(133, 188);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 2;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(133, 232);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 3;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(152, 371);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "go";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 101);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 5;
            label1.Text = "x";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(563, 51);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewResults.Size = new Size(322, 385);
            dataGridViewResults.TabIndex = 6;
            dataGridViewResults.CellContentClick += dataGridViewResults_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 148);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 7;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 191);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 239);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 9;
            label4.Text = "c";
            // 
            // lable5
            // 
            lable5.AutoSize = true;
            lable5.Location = new Point(789, 28);
            lable5.Name = "lable5";
            lable5.Size = new Size(87, 20);
            lable5.TabIndex = 10;
            lable5.Text = "Result table";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 502);
            Controls.Add(lable5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewResults);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(textBoxX);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button buttonCalculate;
        private Label label1;
        private DataGridView dataGridViewResults;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lable5;
    }
}
