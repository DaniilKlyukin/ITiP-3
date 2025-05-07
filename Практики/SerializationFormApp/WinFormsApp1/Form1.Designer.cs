namespace WinFormsApp1
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
            btnSave = new Button();
            btnLoad = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            groupBox = new GroupBox();
            checkBoxIsMilitary = new CheckBox();
            numericUpDownMaxSpeed = new NumericUpDown();
            numericUpDownDisplacement = new NumericUpDown();
            comboBoxType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisplacement).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(158, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(146, 23);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Название:";
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(checkBoxIsMilitary);
            groupBox.Controls.Add(numericUpDownMaxSpeed);
            groupBox.Controls.Add(numericUpDownDisplacement);
            groupBox.Controls.Add(comboBoxType);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(textBoxName);
            groupBox.Location = new Point(12, 41);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(310, 183);
            groupBox.TabIndex = 4;
            groupBox.TabStop = false;
            groupBox.Text = "Параметры корабля";
            // 
            // checkBoxIsMilitary
            // 
            checkBoxIsMilitary.AutoSize = true;
            checkBoxIsMilitary.Location = new Point(96, 138);
            checkBoxIsMilitary.Name = "checkBoxIsMilitary";
            checkBoxIsMilitary.RightToLeft = RightToLeft.Yes;
            checkBoxIsMilitary.Size = new Size(76, 19);
            checkBoxIsMilitary.TabIndex = 13;
            checkBoxIsMilitary.Text = "Военный";
            checkBoxIsMilitary.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxSpeed
            // 
            numericUpDownMaxSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMaxSpeed.Location = new Point(158, 109);
            numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            numericUpDownMaxSpeed.Size = new Size(146, 23);
            numericUpDownMaxSpeed.TabIndex = 12;
            // 
            // numericUpDownDisplacement
            // 
            numericUpDownDisplacement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownDisplacement.Location = new Point(158, 80);
            numericUpDownDisplacement.Name = "numericUpDownDisplacement";
            numericUpDownDisplacement.Size = new Size(146, 23);
            numericUpDownDisplacement.TabIndex = 11;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(158, 51);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(146, 23);
            comboBoxType.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 111);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 8;
            label5.Text = "Макс. скорость, узлов:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 82);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 7;
            label4.Text = "Водоизмещение, тонн:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 54);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Тип:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 236);
            Controls.Add(groupBox);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            MinimumSize = new Size(350, 275);
            Name = "Form1";
            Text = "Редактор корабля";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisplacement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnLoad;
        private TextBox textBoxName;
        private Label label1;
        private GroupBox groupBox;
        private Label label4;
        private Label label3;
        private Label label5;
        private ComboBox comboBoxType;
        private NumericUpDown numericUpDownDisplacement;
        private NumericUpDown numericUpDownMaxSpeed;
        private CheckBox checkBoxIsMilitary;
    }
}
