namespace GUI
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
            txtNumberOfItems = new TextBox();
            txtSeed = new TextBox();
            txtCapacity = new TextBox();
            button1 = new Button();
            lblNumberOfItems = new Label();
            lblSeed = new Label();
            lblCapacity = new Label();
            grpResults = new GroupBox();
            lblResults = new Label();
            grpInstance = new GroupBox();
            lblInstance = new Label();
            label4 = new Label();
            grpResults.SuspendLayout();
            grpInstance.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberOfItems
            // 
            txtNumberOfItems.Location = new Point(58, 106);
            txtNumberOfItems.Multiline = true;
            txtNumberOfItems.Name = "txtNumberOfItems";
            txtNumberOfItems.Size = new Size(94, 34);
            txtNumberOfItems.TabIndex = 0;
            txtNumberOfItems.Tag = "";
            txtNumberOfItems.TextChanged += textBox1_TextChanged;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(58, 166);
            txtSeed.Multiline = true;
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(94, 34);
            txtSeed.TabIndex = 1;
            txtSeed.TextChanged += textBox2_TextChanged;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(58, 225);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(94, 34);
            txtCapacity.TabIndex = 2;
            txtCapacity.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(351, 236);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 3;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNumberOfItems
            // 
            lblNumberOfItems.AutoSize = true;
            lblNumberOfItems.Location = new Point(58, 83);
            lblNumberOfItems.Name = "lblNumberOfItems";
            lblNumberOfItems.Size = new Size(358, 20);
            lblNumberOfItems.TabIndex = 4;
            lblNumberOfItems.Text = "Number of items - enter a number between 1 and 20";
            lblNumberOfItems.Click += label1_Click;
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new Point(58, 143);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(42, 20);
            lblSeed.TabIndex = 5;
            lblSeed.Text = "Seed";
            lblSeed.Click += label2_Click;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(58, 203);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(303, 20);
            lblCapacity.TabIndex = 6;
            lblCapacity.Text = "Capacity - enter a number between 1 and 20";
            lblCapacity.Click += label3_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblResults);
            grpResults.Location = new Point(58, 282);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(417, 202);
            grpResults.TabIndex = 7;
            grpResults.TabStop = false;
            grpResults.Text = "results";
            grpResults.Enter += groupBox1_Enter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(10, 23);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 20);
            lblResults.TabIndex = 0;
            lblResults.Click += lblResults_Click;
            // 
            // grpInstance
            // 
            grpInstance.Controls.Add(lblInstance);
            grpInstance.Location = new Point(481, 35);
            grpInstance.Name = "grpInstance";
            grpInstance.Size = new Size(316, 449);
            grpInstance.TabIndex = 8;
            grpInstance.TabStop = false;
            grpInstance.Text = "instance";
            grpInstance.Enter += groupBox2_Enter;
            // 
            // lblInstance
            // 
            lblInstance.AutoSize = true;
            lblInstance.Location = new Point(10, 26);
            lblInstance.Name = "lblInstance";
            lblInstance.Size = new Size(0, 20);
            lblInstance.TabIndex = 0;
            lblInstance.Click += lblInstance_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(55, 19);
            label4.Name = "label4";
            label4.Size = new Size(278, 41);
            label4.TabIndex = 9;
            label4.Text = "Problem plecakowy";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 496);
            Controls.Add(label4);
            Controls.Add(grpInstance);
            Controls.Add(grpResults);
            Controls.Add(lblCapacity);
            Controls.Add(lblSeed);
            Controls.Add(lblNumberOfItems);
            Controls.Add(button1);
            Controls.Add(txtCapacity);
            Controls.Add(txtSeed);
            Controls.Add(txtNumberOfItems);
            Name = "Form1";
            Text = "Form1";
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            grpInstance.ResumeLayout(false);
            grpInstance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberOfItems;
        private TextBox txtSeed;
        private TextBox txtCapacity;
        private Button button1;
        private Label lblNumberOfItems;
        private Label lblSeed;
        private Label lblCapacity;
        private GroupBox grpResults;
        private GroupBox grpInstance;
        private Label label4;
        private Label lblInstance;
        private Label lblResults;
    }
}
