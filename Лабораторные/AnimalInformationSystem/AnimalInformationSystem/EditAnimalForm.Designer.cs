namespace AnimalInformationSystem
{
    partial class EditAnimalForm
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtSpecies = new TextBox();
            label4 = new Label();
            numAge = new NumericUpDown();
            label5 = new Label();
            numWeight = new NumericUpDown();
            label6 = new Label();
            txtDescription = new TextBox();
            label7 = new Label();
            dtpAdmissionDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(82, 14);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Имя:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(122, 11);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(87, 41);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Вид:";
            // 
            // txtSpecies
            // 
            txtSpecies.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSpecies.Location = new Point(122, 38);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(219, 23);
            txtSpecies.TabIndex = 3;
            txtSpecies.Validating += txtSpecies_Validating;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(63, 67);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Возраст:";
            // 
            // numAge
            // 
            numAge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numAge.Location = new Point(122, 65);
            numAge.Margin = new Padding(3, 2, 3, 2);
            numAge.Name = "numAge";
            numAge.Size = new Size(88, 23);
            numAge.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(87, 94);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 6;
            label5.Text = "Вес:";
            // 
            // numWeight
            // 
            numWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numWeight.DecimalPlaces = 1;
            numWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numWeight.Location = new Point(122, 92);
            numWeight.Margin = new Padding(3, 2, 3, 2);
            numWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(88, 23);
            numWeight.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(51, 122);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 8;
            label6.Text = "Описание:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.Location = new Point(122, 119);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(219, 61);
            txtDescription.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(7, 190);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 10;
            label7.Text = "Дата поступления:";
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpAdmissionDate.Location = new Point(122, 184);
            dtpAdmissionDate.Margin = new Padding(3, 2, 3, 2);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(219, 23);
            dtpAdmissionDate.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(122, 214);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 26);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(236, 214);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 26);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EditAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 261);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpAdmissionDate);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(numWeight);
            Controls.Add(label5);
            Controls.Add(numAge);
            Controls.Add(label4);
            Controls.Add(txtSpecies);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(380, 300);
            Name = "EditAnimalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование животного";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSpecies;
        private Label label4;
        private NumericUpDown numAge;
        private Label label5;
        private NumericUpDown numWeight;
        private Label label6;
        private TextBox txtDescription;
        private Label label7;
        private DateTimePicker dtpAdmissionDate;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}