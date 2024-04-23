namespace PressureConventer
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
            buttonCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxkPa = new TextBox();
            textBoxPsi = new TextBox();
            textBoxBar = new TextBox();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
            buttonCalculate.Location = new Point(233, 168);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Laske";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Paine kPa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 51);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Paine psi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 51);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Paine bar";
            // 
            // textBoxkPa
            // 
            textBoxkPa.Location = new Point(19, 88);
            textBoxkPa.Name = "textBoxkPa";
            textBoxkPa.Size = new Size(75, 23);
            textBoxkPa.TabIndex = 4;
            textBoxkPa.Leave += textBoxkPa_Leave;
            // 
            // textBoxPsi
            // 
            textBoxPsi.Enabled = false;
            textBoxPsi.Location = new Point(125, 88);
            textBoxPsi.Name = "textBoxPsi";
            textBoxPsi.Size = new Size(75, 23);
            textBoxPsi.TabIndex = 5;
            // 
            // textBoxBar
            // 
            textBoxBar.Enabled = false;
            textBoxBar.Location = new Point(233, 88);
            textBoxBar.Name = "textBoxBar";
            textBoxBar.Size = new Size(75, 23);
            textBoxBar.TabIndex = 6;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(125, 168);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Tyhjennä";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 280);
            Controls.Add(buttonClear);
            Controls.Add(textBoxBar);
            Controls.Add(textBoxPsi);
            Controls.Add(textBoxkPa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxkPa;
        private TextBox textBoxPsi;
        private TextBox textBoxBar;
        private Button buttonClear;
    }
}
