namespace Calculator
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
            this.buttonTable = new System.Windows.Forms.TableLayoutPanel();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.currentValueBox = new System.Windows.Forms.Label();
            this.buttonTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTable
            // 
            this.buttonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTable.ColumnCount = 4;
            this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonTable.Controls.Add(this.dotButton, 2, 4);
            this.buttonTable.Controls.Add(this.zeroButton, 1, 4);
            this.buttonTable.Controls.Add(this.threeButton, 2, 3);
            this.buttonTable.Controls.Add(this.twoButton, 1, 3);
            this.buttonTable.Controls.Add(this.sixButton, 2, 2);
            this.buttonTable.Controls.Add(this.fiveButton, 1, 2);
            this.buttonTable.Controls.Add(this.fourButton, 0, 2);
            this.buttonTable.Controls.Add(this.nineButton, 2, 1);
            this.buttonTable.Controls.Add(this.eightButton, 1, 1);
            this.buttonTable.Controls.Add(this.sevenButton, 0, 1);
            this.buttonTable.Controls.Add(this.cancelButton, 2, 0);
            this.buttonTable.Controls.Add(this.ceButton, 1, 0);
            this.buttonTable.Controls.Add(this.backButton, 0, 0);
            this.buttonTable.Controls.Add(this.divideButton, 3, 0);
            this.buttonTable.Controls.Add(this.multiplyButton, 3, 1);
            this.buttonTable.Controls.Add(this.minusButton, 3, 2);
            this.buttonTable.Controls.Add(this.addButton, 3, 3);
            this.buttonTable.Controls.Add(this.equalsButton, 3, 4);
            this.buttonTable.Controls.Add(this.oneButton, 0, 3);
            this.buttonTable.Location = new System.Drawing.Point(12, 85);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.RowCount = 5;
            this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonTable.Size = new System.Drawing.Size(210, 165);
            this.buttonTable.TabIndex = 0;
            // 
            // dotButton
            // 
            this.dotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotButton.Location = new System.Drawing.Point(107, 135);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(46, 27);
            this.dotButton.TabIndex = 23;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Location = new System.Drawing.Point(55, 135);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(46, 27);
            this.zeroButton.TabIndex = 22;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Location = new System.Drawing.Point(107, 102);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(46, 27);
            this.threeButton.TabIndex = 20;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Location = new System.Drawing.Point(55, 102);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(46, 27);
            this.twoButton.TabIndex = 19;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Location = new System.Drawing.Point(107, 69);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(46, 27);
            this.sixButton.TabIndex = 18;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Location = new System.Drawing.Point(55, 69);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(46, 27);
            this.fiveButton.TabIndex = 17;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Location = new System.Drawing.Point(3, 69);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(46, 27);
            this.fourButton.TabIndex = 16;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(107, 36);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(46, 27);
            this.nineButton.TabIndex = 15;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Location = new System.Drawing.Point(55, 36);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(46, 27);
            this.eightButton.TabIndex = 14;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Location = new System.Drawing.Point(3, 36);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(46, 27);
            this.sevenButton.TabIndex = 13;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(107, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(46, 27);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "C";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ceButton
            // 
            this.ceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceButton.Location = new System.Drawing.Point(55, 3);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(46, 27);
            this.ceButton.TabIndex = 11;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 27);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Location = new System.Drawing.Point(159, 3);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(48, 27);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.Location = new System.Drawing.Point(159, 36);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(48, 27);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(159, 69);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(48, 27);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(159, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 27);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsButton.Location = new System.Drawing.Point(159, 135);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(48, 27);
            this.equalsButton.TabIndex = 7;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Location = new System.Drawing.Point(3, 102);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(46, 27);
            this.oneButton.TabIndex = 10;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(210, 20);
            this.UserInputText.TabIndex = 1;
            // 
            // currentValueBox
            // 
            this.currentValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValueBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentValueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValueBox.Location = new System.Drawing.Point(13, 35);
            this.currentValueBox.Name = "currentValueBox";
            this.currentValueBox.Size = new System.Drawing.Size(209, 47);
            this.currentValueBox.TabIndex = 2;
            this.currentValueBox.Text = "0";
            this.currentValueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(234, 262);
            this.Controls.Add(this.currentValueBox);
            this.Controls.Add(this.UserInputText);
            this.Controls.Add(this.buttonTable);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.buttonTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonTable;
        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label currentValueBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button oneButton;
    }
}

