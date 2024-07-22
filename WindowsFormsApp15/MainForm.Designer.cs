namespace WindowsFormsApp15
{
    partial class MainForm
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
            this.openParents = new MaterialSkin.Controls.MaterialFlatButton();
            this.openTeachers = new MaterialSkin.Controls.MaterialFlatButton();
            this.openUsers = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // openParents
            // 
            this.openParents.AutoSize = true;
            this.openParents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openParents.Depth = 0;
            this.openParents.Location = new System.Drawing.Point(116, 100);
            this.openParents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openParents.MouseState = MaterialSkin.MouseState.HOVER;
            this.openParents.Name = "openParents";
            this.openParents.Primary = false;
            this.openParents.Size = new System.Drawing.Size(65, 36);
            this.openParents.TabIndex = 1;
            this.openParents.Text = "Батьки";
            this.openParents.UseVisualStyleBackColor = true;
            this.openParents.Click += new System.EventHandler(this.openParents_Click);
            // 
            // openTeachers
            // 
            this.openTeachers.AutoSize = true;
            this.openTeachers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openTeachers.Depth = 0;
            this.openTeachers.Location = new System.Drawing.Point(116, 148);
            this.openTeachers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openTeachers.MouseState = MaterialSkin.MouseState.HOVER;
            this.openTeachers.Name = "openTeachers";
            this.openTeachers.Primary = false;
            this.openTeachers.Size = new System.Drawing.Size(70, 36);
            this.openTeachers.TabIndex = 3;
            this.openTeachers.Text = "Вчителі";
            this.openTeachers.UseVisualStyleBackColor = true;
            this.openTeachers.Click += new System.EventHandler(this.openTeachers_Click);
            // 
            // openUsers
            // 
            this.openUsers.AutoSize = true;
            this.openUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openUsers.Depth = 0;
            this.openUsers.Location = new System.Drawing.Point(116, 196);
            this.openUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.openUsers.Name = "openUsers";
            this.openUsers.Primary = false;
            this.openUsers.Size = new System.Drawing.Size(106, 36);
            this.openUsers.TabIndex = 4;
            this.openUsers.Text = "Користувачі";
            this.openUsers.UseVisualStyleBackColor = true;
            this.openUsers.Click += new System.EventHandler(this.openUsers_Click);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(405, 100);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(132, 36);
            this.materialFlatButton6.TabIndex = 5;
            this.materialFlatButton6.Text = "Зміна розкладу";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.openUsers);
            this.Controls.Add(this.openTeachers);
            this.Controls.Add(this.openParents);
            this.Name = "MainForm";
            this.Text = "Головна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton openParents;
        private MaterialSkin.Controls.MaterialFlatButton openTeachers;
        private MaterialSkin.Controls.MaterialFlatButton openUsers;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}