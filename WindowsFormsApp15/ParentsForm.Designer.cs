namespace WindowsFormsApp15
{
    partial class ParentsForm
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
            this.LastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FirstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ContactInfoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.InsertBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            this.LoadBtn = new MetroFramework.Controls.MetroButton();
            this.IDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(79, 116);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(105, 23);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(190, 116);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(115, 23);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // ContactInfoTextBox
            // 
            this.ContactInfoTextBox.Location = new System.Drawing.Point(311, 116);
            this.ContactInfoTextBox.Name = "ContactInfoTextBox";
            this.ContactInfoTextBox.Size = new System.Drawing.Size(123, 23);
            this.ContactInfoTextBox.TabIndex = 3;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(359, 158);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 4;
            this.InsertBtn.Text = "Внести";
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(359, 187);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Видалити";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(828, 313);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Оновити";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(41, 116);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(32, 23);
            this.IDTextBox.TabIndex = 7;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(805, 368);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "На головну";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Прізвище:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(190, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Ім\'я:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(311, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Контакт:";
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 430);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.ContactInfoTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ParentsForm";
            this.Text = "Батьки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox LastNameTextBox;
        private MetroFramework.Controls.MetroTextBox FirstNameTextBox;
        private MetroFramework.Controls.MetroTextBox ContactInfoTextBox;
        private MetroFramework.Controls.MetroButton InsertBtn;
        private MetroFramework.Controls.MetroButton DeleteBtn;
        private MetroFramework.Controls.MetroButton LoadBtn;
        private MetroFramework.Controls.MetroTextBox IDTextBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}