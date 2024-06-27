namespace ToDoList
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.saveaButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1277, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(10, 105);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1278, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(10, 156);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(1278, 22);
            this.descriptionTextbox.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(13, 131);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(1276, 23);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 79);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1276, 23);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(10, 182);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(262, 45);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveaButton
            // 
            this.saveaButton.Location = new System.Drawing.Point(1026, 182);
            this.saveaButton.Name = "saveaButton";
            this.saveaButton.Size = new System.Drawing.Size(262, 45);
            this.saveaButton.TabIndex = 6;
            this.saveaButton.Text = "Save";
            this.saveaButton.UseVisualStyleBackColor = true;
            this.saveaButton.Click += new System.EventHandler(this.saveaButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(338, 182);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(262, 45);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(681, 182);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(262, 45);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.Color.White;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.GridColor = System.Drawing.Color.White;
            this.toDoListView.Location = new System.Drawing.Point(10, 232);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowHeadersWidth = 51;
            this.toDoListView.RowTemplate.Height = 24;
            this.toDoListView.Size = new System.Drawing.Size(1278, 366);
            this.toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1302, 610);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveaButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveaButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView toDoListView;
    }
}

