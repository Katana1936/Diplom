namespace WindowsFormsApp15
{
    partial class EditScheduleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.loadBtn = new MetroFramework.Controls.MetroButton();
            this.dateTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Start_timeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.End_timeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Teacher_IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.GroupTextBox = new MetroFramework.Controls.MetroTextBox();
            this.activityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(786, 90);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(83, 23);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.Text = "Внести";
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(786, 119);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(83, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Видалити";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(786, 148);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(83, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Оновити";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(786, 177);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(83, 23);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Завантажити";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(66, 84);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(201, 23);
            this.dateTextBox.TabIndex = 8;
            // 
            // Start_timeTextBox
            // 
            this.Start_timeTextBox.Location = new System.Drawing.Point(273, 85);
            this.Start_timeTextBox.Name = "Start_timeTextBox";
            this.Start_timeTextBox.Size = new System.Drawing.Size(122, 23);
            this.Start_timeTextBox.TabIndex = 9;
            // 
            // End_timeTextBox
            // 
            this.End_timeTextBox.Location = new System.Drawing.Point(401, 85);
            this.End_timeTextBox.Name = "End_timeTextBox";
            this.End_timeTextBox.Size = new System.Drawing.Size(104, 23);
            this.End_timeTextBox.TabIndex = 10;
            // 
            // Teacher_IDTextBox
            // 
            this.Teacher_IDTextBox.Location = new System.Drawing.Point(511, 85);
            this.Teacher_IDTextBox.Name = "Teacher_IDTextBox";
            this.Teacher_IDTextBox.Size = new System.Drawing.Size(76, 23);
            this.Teacher_IDTextBox.TabIndex = 11;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(593, 85);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(74, 23);
            this.GroupTextBox.TabIndex = 12;
            // 
            // activityTextBox
            // 
            this.activityTextBox.Location = new System.Drawing.Point(673, 85);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(105, 23);
            this.activityTextBox.TabIndex = 13;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(38, 84);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(23, 23);
            this.IDTextBox.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(66, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Дата:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(273, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Початок:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(401, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Кінець:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(511, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "ID вчителя:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(594, 58);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Група:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(673, 58);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Занаття:";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(788, 377);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 22;
            this.materialFlatButton1.Text = "На головну";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 445);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.activityTextBox);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.Teacher_IDTextBox);
            this.Controls.Add(this.End_timeTextBox);
            this.Controls.Add(this.Start_timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditScheduleForm";
            this.Text = "Зміна розкладу";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton insertBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton updateBtn;
        private MetroFramework.Controls.MetroButton loadBtn;
        private MetroFramework.Controls.MetroTextBox dateTextBox;
        private MetroFramework.Controls.MetroTextBox Start_timeTextBox;
        private MetroFramework.Controls.MetroTextBox End_timeTextBox;
        private MetroFramework.Controls.MetroTextBox Teacher_IDTextBox;
        private MetroFramework.Controls.MetroTextBox GroupTextBox;
        private MetroFramework.Controls.MetroTextBox activityTextBox;
        private MetroFramework.Controls.MetroTextBox IDTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}