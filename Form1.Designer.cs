namespace bar
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtlabels = new TextBox();
            txtValues = new TextBox();
            bar1 = new bar();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(567, 394);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(106, 48);
            button1.TabIndex = 0;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 394);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 1;
            label1.Text = "Enter Labels ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 424);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 2;
            label2.Text = "Enter Values";
            // 
            // txtlabels
            // 
            txtlabels.Location = new Point(148, 389);
            txtlabels.Margin = new Padding(2);
            txtlabels.Name = "txtlabels";
            txtlabels.Size = new Size(336, 27);
            txtlabels.TabIndex = 3;
            // 
            // txtValues
            // 
            txtValues.Location = new Point(148, 420);
            txtValues.Margin = new Padding(2);
            txtValues.Name = "txtValues";
            txtValues.Size = new Size(336, 27);
            txtValues.TabIndex = 4;
            // 
            // bar1
            // 
            bar1.Location = new Point(58, 89);
            bar1.Margin = new Padding(2, 2, 2, 2);
            bar1.Name = "bar1";
            bar1.Size = new Size(561, 275);
            bar1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 455);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(460, 28);
            label3.TabIndex = 6;
            label3.Text = "Note: Please enter the values separated by commas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 22);
            label4.Name = "label4";
            label4.Size = new Size(188, 34);
            label4.TabIndex = 7;
            label4.Text = "BAR CHART";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(693, 492);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bar1);
            Controls.Add(txtValues);
            Controls.Add(txtlabels);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtlabels;
        private TextBox txtValues;
        private bar bar1;
        private Label label3;
        private Label label4;
    }
}
