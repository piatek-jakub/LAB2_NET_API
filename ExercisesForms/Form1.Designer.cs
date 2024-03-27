using LAB2_NET_Simple;

namespace ExercisesForms
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
            type = new CheckBox();
            participants = new CheckBox();
            price = new CheckBox();
            accessibility = new CheckBox();
            requestButton = new Button();
            response = new TextBox();
            responseText = new Label();
            statusText = new Label();
            status = new TextBox();
            participantsBox = new NumericUpDown();
            priceBox = new NumericUpDown();
            accessibilityBox = new NumericUpDown();
            typeBox = new ComboBox();
            dataGridViewExercises = new DataGridView();
            clearSelected = new Button();
            sortBy = new ComboBox();
            SortByText = new Label();
            FilterText = new Label();
            filter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)participantsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accessibilityBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercises).BeginInit();
            SuspendLayout();
            // 
            // type
            // 
            type.AutoSize = true;
            type.Location = new Point(61, 39);
            type.Name = "type";
            type.Size = new Size(50, 19);
            type.TabIndex = 0;
            type.Text = "Type";
            type.UseVisualStyleBackColor = true;
            type.CheckedChanged += checkBox_CheckedChanged;
            // 
            // participants
            // 
            participants.AutoSize = true;
            participants.Location = new Point(61, 64);
            participants.Name = "participants";
            participants.Size = new Size(88, 19);
            participants.TabIndex = 1;
            participants.Text = "Participants";
            participants.UseVisualStyleBackColor = true;
            participants.CheckedChanged += checkBox_CheckedChanged;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(61, 89);
            price.Name = "price";
            price.Size = new Size(52, 19);
            price.TabIndex = 2;
            price.Text = "Price";
            price.UseVisualStyleBackColor = true;
            price.CheckedChanged += checkBox_CheckedChanged;
            // 
            // accessibility
            // 
            accessibility.AutoSize = true;
            accessibility.Location = new Point(61, 114);
            accessibility.Name = "accessibility";
            accessibility.Size = new Size(91, 19);
            accessibility.TabIndex = 3;
            accessibility.Text = "Accessibility";
            accessibility.UseVisualStyleBackColor = true;
            accessibility.CheckedChanged += checkBox_CheckedChanged;
            // 
            // requestButton
            // 
            requestButton.Location = new Point(61, 139);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(75, 23);
            requestButton.TabIndex = 4;
            requestButton.Text = "Request";
            requestButton.UseVisualStyleBackColor = true;
            requestButton.Click += requestButton_Click;
            // 
            // response
            // 
            response.Location = new Point(302, 28);
            response.Multiline = true;
            response.Name = "response";
            response.Size = new Size(194, 134);
            response.TabIndex = 5;
            // 
            // responseText
            // 
            responseText.AutoSize = true;
            responseText.Location = new Point(302, 10);
            responseText.Name = "responseText";
            responseText.Size = new Size(54, 15);
            responseText.TabIndex = 6;
            responseText.Text = "response";
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Location = new Point(550, 10);
            statusText.Name = "statusText";
            statusText.Size = new Size(38, 15);
            statusText.TabIndex = 8;
            statusText.Text = "status";
            // 
            // status
            // 
            status.Location = new Point(550, 28);
            status.Multiline = true;
            status.Name = "status";
            status.Size = new Size(194, 134);
            status.TabIndex = 7;
            // 
            // participantsBox
            // 
            participantsBox.Enabled = false;
            participantsBox.Location = new Point(167, 60);
            participantsBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            participantsBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            participantsBox.Name = "participantsBox";
            participantsBox.Size = new Size(75, 23);
            participantsBox.TabIndex = 9;
            participantsBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // priceBox
            // 
            priceBox.DecimalPlaces = 1;
            priceBox.Enabled = false;
            priceBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            priceBox.Location = new Point(167, 89);
            priceBox.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(75, 23);
            priceBox.TabIndex = 10;
            priceBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // accessibilityBox
            // 
            accessibilityBox.DecimalPlaces = 1;
            accessibilityBox.Enabled = false;
            accessibilityBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            accessibilityBox.Location = new Point(167, 118);
            accessibilityBox.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            accessibilityBox.Name = "accessibilityBox";
            accessibilityBox.Size = new Size(75, 23);
            accessibilityBox.TabIndex = 11;
            accessibilityBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // typeBox
            // 
            typeBox.Enabled = false;
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork" });
            typeBox.Location = new Point(167, 31);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(75, 23);
            typeBox.TabIndex = 12;
            // 
            // dataGridViewExercises
            // 
            dataGridViewExercises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExercises.Location = new Point(12, 217);
            dataGridViewExercises.Name = "dataGridViewExercises";
            dataGridViewExercises.Size = new Size(732, 221);
            dataGridViewExercises.TabIndex = 13;
            // 
            // clearSelected
            // 
            clearSelected.Location = new Point(61, 188);
            clearSelected.Name = "clearSelected";
            clearSelected.Size = new Size(91, 23);
            clearSelected.TabIndex = 14;
            clearSelected.Text = "Clear Selected";
            clearSelected.UseVisualStyleBackColor = true;
            clearSelected.Click += clearSelected_Click;
            // 
            // sortBy
            // 
            sortBy.FormattingEnabled = true;
            sortBy.Items.AddRange(new object[] { "Id", "price", "participants", "accessibility", "key" });
            sortBy.Location = new Point(645, 189);
            sortBy.Name = "sortBy";
            sortBy.Size = new Size(99, 23);
            sortBy.TabIndex = 15;
            sortBy.SelectedIndexChanged += sortBy_SelectedIndexChanged;
            // 
            // SortByText
            // 
            SortByText.AutoSize = true;
            SortByText.Location = new Point(601, 192);
            SortByText.Name = "SortByText";
            SortByText.Size = new Size(44, 15);
            SortByText.TabIndex = 16;
            SortByText.Text = "Sort By";
            // 
            // FilterText
            // 
            FilterText.AutoSize = true;
            FilterText.Location = new Point(601, 171);
            FilterText.Name = "FilterText";
            FilterText.Size = new Size(33, 15);
            FilterText.TabIndex = 18;
            FilterText.Text = "Filter";
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork" });
            filter.Location = new Point(645, 168);
            filter.Name = "filter";
            filter.Size = new Size(99, 23);
            filter.TabIndex = 17;
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterText);
            Controls.Add(filter);
            Controls.Add(SortByText);
            Controls.Add(sortBy);
            Controls.Add(clearSelected);
            Controls.Add(dataGridViewExercises);
            Controls.Add(typeBox);
            Controls.Add(accessibilityBox);
            Controls.Add(priceBox);
            Controls.Add(participantsBox);
            Controls.Add(statusText);
            Controls.Add(status);
            Controls.Add(responseText);
            Controls.Add(response);
            Controls.Add(requestButton);
            Controls.Add(accessibility);
            Controls.Add(price);
            Controls.Add(participants);
            Controls.Add(type);
            Name = "Form1";
            Text = "Exercises";
            ((System.ComponentModel.ISupportInitialize)participantsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)accessibilityBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercises).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox type;
        private CheckBox participants;
        private CheckBox price;
        private CheckBox accessibility;
        private Button requestButton;
        private TextBox response;
        private Label responseText;
        private Label statusText;
        private TextBox status;
        private NumericUpDown participantsBox;
        private NumericUpDown priceBox;
        private NumericUpDown accessibilityBox;
        private ComboBox typeBox;
        private DataGridView dataGridViewExercises;
        private Button clearSelected;
        private ComboBox sortBy;
        private Label SortByText;
        private Label FilterText;
        private ComboBox filter;
    }
}
