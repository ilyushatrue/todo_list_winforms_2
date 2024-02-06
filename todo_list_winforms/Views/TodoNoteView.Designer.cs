namespace todo_list_winforms
{
    partial class TodoNoteView
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
            components = new System.ComponentModel.Container();
            todo_dataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDoneDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            todoNoteBindingSource = new BindingSource(components);
            title_label = new Label();
            title_textBox = new TextBox();
            description_textBox = new TextBox();
            description_label = new Label();
            create_button = new Button();
            save_button = new Button();
            delete_button = new Button();
            contextBindingSource = new BindingSource(components);
            contextBindingSource1 = new BindingSource(components);
            deadline_label = new Label();
            deadline_dateTimePicker = new DateTimePicker();
            isCompleted_checkBox = new CheckBox();
            isDone_checkBox = new CheckBox();
            startDate_label = new Label();
            startDate_dateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)todo_dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)todoNoteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // todo_dataGrid
            // 
            todo_dataGrid.AutoGenerateColumns = false;
            todo_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todo_dataGrid.BackgroundColor = SystemColors.Control;
            todo_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todo_dataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, isDoneDataGridViewCheckBoxColumn });
            todo_dataGrid.DataSource = todoNoteBindingSource;
            todo_dataGrid.GridColor = SystemColors.ButtonShadow;
            todo_dataGrid.Location = new Point(12, 195);
            todo_dataGrid.Name = "todo_dataGrid";
            todo_dataGrid.RowTemplate.Height = 25;
            todo_dataGrid.Size = new Size(776, 331);
            todo_dataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Задача";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Дата постановки";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "Крайний срок";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
            isDoneDataGridViewCheckBoxColumn.HeaderText = "Выполнено";
            isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            isDoneDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // todoNoteBindingSource
            // 
            todoNoteBindingSource.DataSource = typeof(DAL.Models.TodoNote);
            // 
            // title_label
            // 
            title_label.Location = new Point(12, 6);
            title_label.Name = "title_label";
            title_label.Size = new Size(159, 18);
            title_label.TabIndex = 1;
            title_label.Text = "Задача";
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(12, 25);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(671, 23);
            title_textBox.TabIndex = 2;
            // 
            // description_textBox
            // 
            description_textBox.Location = new Point(12, 73);
            description_textBox.Name = "description_textBox";
            description_textBox.Size = new Size(776, 23);
            description_textBox.TabIndex = 3;
            // 
            // description_label
            // 
            description_label.Location = new Point(12, 53);
            description_label.Name = "description_label";
            description_label.Size = new Size(776, 19);
            description_label.TabIndex = 1;
            description_label.Text = "Описание";
            // 
            // create_button
            // 
            create_button.Location = new Point(12, 164);
            create_button.Name = "create_button";
            create_button.Size = new Size(129, 25);
            create_button.TabIndex = 4;
            create_button.Text = "Новая задача";
            create_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            save_button.Location = new Point(659, 535);
            save_button.Name = "save_button";
            save_button.Size = new Size(129, 25);
            save_button.TabIndex = 4;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(525, 535);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(129, 25);
            delete_button.TabIndex = 4;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            // 
            // contextBindingSource
            // 
            contextBindingSource.DataSource = typeof(DAL.Context);
            // 
            // contextBindingSource1
            // 
            contextBindingSource1.DataSource = typeof(DAL.Context);
            // 
            // deadline_label
            // 
            deadline_label.Location = new Point(415, 101);
            deadline_label.Name = "deadline_label";
            deadline_label.Size = new Size(373, 19);
            deadline_label.TabIndex = 1;
            deadline_label.Text = "Крайний срок";
            // 
            // deadline_dateTimePicker
            // 
            deadline_dateTimePicker.Format = DateTimePickerFormat.Custom;
            deadline_dateTimePicker.Location = new Point(402, 121);
            deadline_dateTimePicker.Name = "deadline_dateTimePicker";
            deadline_dateTimePicker.Size = new Size(386, 23);
            deadline_dateTimePicker.TabIndex = 5;
            // 
            // isCompleted_checkBox
            // 
            isCompleted_checkBox.AutoSize = true;
            isCompleted_checkBox.Location = new Point(668, 170);
            isCompleted_checkBox.Name = "isCompleted_checkBox";
            isCompleted_checkBox.Size = new Size(120, 19);
            isCompleted_checkBox.TabIndex = 6;
            isCompleted_checkBox.Text = "Только активные";
            isCompleted_checkBox.UseVisualStyleBackColor = true;
            // 
            // isDone_checkBox
            // 
            isDone_checkBox.AutoSize = true;
            isDone_checkBox.Location = new Point(699, 24);
            isDone_checkBox.Name = "isDone_checkBox";
            isDone_checkBox.Size = new Size(90, 19);
            isDone_checkBox.TabIndex = 7;
            isDone_checkBox.Text = "Выполнено";
            isDone_checkBox.UseVisualStyleBackColor = true;
            // 
            // startDate_label
            // 
            startDate_label.Location = new Point(12, 101);
            startDate_label.Name = "startDate_label";
            startDate_label.Size = new Size(373, 19);
            startDate_label.TabIndex = 1;
            startDate_label.Text = "Дата постановки";
            // 
            // startDate_dateTimePicker
            // 
            startDate_dateTimePicker.Enabled = false;
            startDate_dateTimePicker.Format = DateTimePickerFormat.Custom;
            startDate_dateTimePicker.Location = new Point(12, 121);
            startDate_dateTimePicker.Name = "startDate_dateTimePicker";
            startDate_dateTimePicker.Size = new Size(373, 23);
            startDate_dateTimePicker.TabIndex = 5;
            // 
            // TodoNoteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(isDone_checkBox);
            Controls.Add(isCompleted_checkBox);
            Controls.Add(startDate_dateTimePicker);
            Controls.Add(deadline_dateTimePicker);
            Controls.Add(delete_button);
            Controls.Add(save_button);
            Controls.Add(create_button);
            Controls.Add(description_textBox);
            Controls.Add(title_textBox);
            Controls.Add(startDate_label);
            Controls.Add(deadline_label);
            Controls.Add(description_label);
            Controls.Add(title_label);
            Controls.Add(todo_dataGrid);
            Name = "TodoNoteView";
            Text = "Список задач";
            ((System.ComponentModel.ISupportInitialize)todo_dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)todoNoteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView todo_dataGrid;
        private Label title_label;
        private TextBox title_textBox;
        private TextBox description_textBox;
        private Label description_label;
        private Button create_button;
        private Button save_button;
        private Button delete_button;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource todoNoteBindingSource;
        private BindingSource contextBindingSource;
        private BindingSource contextBindingSource1;
        private Label deadline_label;
        private DateTimePicker deadline_dateTimePicker;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
        private CheckBox isCompleted_checkBox;
        private CheckBox isDone_checkBox;
        private Label startDate_label;
        private DateTimePicker startDate_dateTimePicker;
    }
}
