namespace lab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxElement = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.groupBoxCreation = new System.Windows.Forms.GroupBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyboard = new System.Windows.Forms.RadioButton();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.textBoxUnsorted = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxCreation.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.textBoxElement);
            this.groupBoxInput.Controls.Add(this.textBoxSize);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxInput.ForeColor = System.Drawing.Color.White;
            this.groupBoxInput.Location = new System.Drawing.Point(12, 226);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(194, 122);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter element [-999;999]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter size (max 999):";
            // 
            // textBoxElement
            // 
            this.textBoxElement.Location = new System.Drawing.Point(6, 88);
            this.textBoxElement.Name = "textBoxElement";
            this.textBoxElement.Size = new System.Drawing.Size(182, 23);
            this.textBoxElement.TabIndex = 1;
            this.textBoxElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxElement_KeyPress);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(6, 39);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(182, 23);
            this.textBoxSize.TabIndex = 0;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // groupBoxCreation
            // 
            this.groupBoxCreation.Controls.Add(this.radioButtonRandom);
            this.groupBoxCreation.Controls.Add(this.radioButtonKeyboard);
            this.groupBoxCreation.Controls.Add(this.radioButtonFile);
            this.groupBoxCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxCreation.ForeColor = System.Drawing.Color.White;
            this.groupBoxCreation.Location = new System.Drawing.Point(12, 13);
            this.groupBoxCreation.Name = "groupBoxCreation";
            this.groupBoxCreation.Size = new System.Drawing.Size(194, 117);
            this.groupBoxCreation.TabIndex = 1;
            this.groupBoxCreation.TabStop = false;
            this.groupBoxCreation.Text = "Choose creation:";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 76);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(134, 21);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random creation";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonKeyboard
            // 
            this.radioButtonKeyboard.AutoSize = true;
            this.radioButtonKeyboard.Location = new System.Drawing.Point(6, 49);
            this.radioButtonKeyboard.Name = "radioButtonKeyboard";
            this.radioButtonKeyboard.Size = new System.Drawing.Size(142, 21);
            this.radioButtonKeyboard.TabIndex = 1;
            this.radioButtonKeyboard.TabStop = true;
            this.radioButtonKeyboard.Text = "Keyboard creation";
            this.radioButtonKeyboard.UseVisualStyleBackColor = true;
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.ForeColor = System.Drawing.Color.White;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 22);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(120, 21);
            this.radioButtonFile.TabIndex = 0;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "File generation";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.DarkGray;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(12, 136);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 39);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "(*.txt)|*.txt";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.label2);
            this.groupBoxOutput.Controls.Add(this.label1);
            this.groupBoxOutput.Controls.Add(this.textBoxSorted);
            this.groupBoxOutput.Controls.Add(this.textBoxUnsorted);
            this.groupBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxOutput.ForeColor = System.Drawing.Color.White;
            this.groupBoxOutput.Location = new System.Drawing.Point(212, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(206, 336);
            this.groupBoxOutput.TabIndex = 4;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sorted array";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unsorted array";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.Location = new System.Drawing.Point(7, 198);
            this.textBoxSorted.Multiline = true;
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSorted.Size = new System.Drawing.Size(187, 127);
            this.textBoxSorted.TabIndex = 5;
            // 
            // textBoxUnsorted
            // 
            this.textBoxUnsorted.Location = new System.Drawing.Point(6, 39);
            this.textBoxUnsorted.Multiline = true;
            this.textBoxUnsorted.Name = "textBoxUnsorted";
            this.textBoxUnsorted.ReadOnly = true;
            this.textBoxUnsorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUnsorted.Size = new System.Drawing.Size(188, 138);
            this.textBoxUnsorted.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(112, 136);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 39);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEnter.Location = new System.Drawing.Point(112, 181);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 39);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(12, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 39);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(429, 355);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBoxCreation);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "MainForm";
            this.Text = "1_lab";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxCreation.ResumeLayout(false);
            this.groupBoxCreation.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxElement;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.GroupBox groupBoxCreation;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonKeyboard;
        private System.Windows.Forms.RadioButton radioButtonFile;
        public System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxUnsorted;
        private System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
    }
}

