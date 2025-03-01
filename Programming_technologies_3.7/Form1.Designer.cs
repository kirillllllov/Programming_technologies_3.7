namespace Programming_technologies_3._7
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
            Numerator1 = new TextBox();
            Denominator1 = new TextBox();
            Sign = new TextBox();
            Numerator2 = new TextBox();
            Denominator2 = new TextBox();
            ResultNumerator = new TextBox();
            ResultDenominator = new TextBox();
            label1 = new Label();
            SumButton = new Button();
            DifButton = new Button();
            MultButton = new Button();
            DivButton = new Button();
            ReducButton = new Button();
            ComButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Numerator1
            // 
            Numerator1.Location = new Point(27, 84);
            Numerator1.Name = "Numerator1";
            Numerator1.Size = new Size(23, 23);
            Numerator1.TabIndex = 0;
            // 
            // Denominator1
            // 
            Denominator1.Location = new Point(27, 113);
            Denominator1.Name = "Denominator1";
            Denominator1.Size = new Size(23, 23);
            Denominator1.TabIndex = 1;
            // 
            // Sign
            // 
            Sign.Location = new Point(55, 98);
            Sign.Name = "Sign";
            Sign.Size = new Size(23, 23);
            Sign.TabIndex = 2;
            // 
            // Numerator2
            // 
            Numerator2.Location = new Point(84, 84);
            Numerator2.Name = "Numerator2";
            Numerator2.Size = new Size(23, 23);
            Numerator2.TabIndex = 3;
            // 
            // Denominator2
            // 
            Denominator2.Location = new Point(84, 113);
            Denominator2.Name = "Denominator2";
            Denominator2.Size = new Size(23, 23);
            Denominator2.TabIndex = 4;
            // 
            // ResultNumerator
            // 
            ResultNumerator.Location = new Point(134, 84);
            ResultNumerator.Name = "ResultNumerator";
            ResultNumerator.Size = new Size(23, 23);
            ResultNumerator.TabIndex = 5;
            // 
            // ResultDenominator
            // 
            ResultDenominator.Location = new Point(134, 113);
            ResultDenominator.Name = "ResultDenominator";
            ResultDenominator.Size = new Size(23, 23);
            ResultDenominator.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 101);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 7;
            label1.Text = "=";
            // 
            // SumButton
            // 
            SumButton.Location = new Point(200, 25);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(83, 23);
            SumButton.TabIndex = 8;
            SumButton.Text = "+";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // DifButton
            // 
            DifButton.Location = new Point(200, 54);
            DifButton.Name = "DifButton";
            DifButton.Size = new Size(83, 23);
            DifButton.TabIndex = 9;
            DifButton.Text = "-";
            DifButton.UseVisualStyleBackColor = true;
            DifButton.Click += DifButton_Click;
            // 
            // MultButton
            // 
            MultButton.Location = new Point(200, 83);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(83, 23);
            MultButton.TabIndex = 10;
            MultButton.Text = "*";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += MultButton_Click;
            // 
            // DivButton
            // 
            DivButton.Location = new Point(200, 112);
            DivButton.Name = "DivButton";
            DivButton.Size = new Size(83, 23);
            DivButton.TabIndex = 11;
            DivButton.Text = "/";
            DivButton.UseVisualStyleBackColor = true;
            DivButton.Click += DivButton_Click;
            // 
            // ReducButton
            // 
            ReducButton.Location = new Point(200, 141);
            ReducButton.Name = "ReducButton";
            ReducButton.Size = new Size(83, 23);
            ReducButton.TabIndex = 12;
            ReducButton.Text = "Reduction";
            ReducButton.UseVisualStyleBackColor = true;
            ReducButton.Click += ReducButton_Click;
            // 
            // ComButton
            // 
            ComButton.Location = new Point(200, 170);
            ComButton.Name = "ComButton";
            ComButton.Size = new Size(83, 23);
            ComButton.TabIndex = 13;
            ComButton.Text = "Comparison";
            ComButton.UseVisualStyleBackColor = true;
            ComButton.Click += ComButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 216);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 15;
            label3.Text = "—";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 101);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 16;
            label4.Text = "—";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 101);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 17;
            label5.Text = "—";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ComButton);
            Controls.Add(ReducButton);
            Controls.Add(DivButton);
            Controls.Add(MultButton);
            Controls.Add(DifButton);
            Controls.Add(SumButton);
            Controls.Add(label1);
            Controls.Add(ResultDenominator);
            Controls.Add(ResultNumerator);
            Controls.Add(Denominator2);
            Controls.Add(Numerator2);
            Controls.Add(Sign);
            Controls.Add(Denominator1);
            Controls.Add(Numerator1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "Form1";
            Text = "FractionCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numerator1;
        private TextBox Denominator1;
        private TextBox Sign;
        private TextBox Numerator2;
        private TextBox Denominator2;
        private TextBox ResultNumerator;
        private TextBox ResultDenominator;
        private Label label1;
        private Button SumButton;
        private Button DifButton;
        private Button MultButton;
        private Button DivButton;
        private Button ReducButton;
        private Button ComButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
