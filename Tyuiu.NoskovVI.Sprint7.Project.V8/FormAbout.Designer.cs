namespace Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_NVI = new PictureBox();
            labelText_NVI = new Label();
            buttonOk_NVI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NVI).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_NVI
            // 
            pictureBoxAvatar_NVI.BackgroundImage = Properties.Resources.avatar;
            pictureBoxAvatar_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_NVI.Location = new Point(12, 12);
            pictureBoxAvatar_NVI.Name = "pictureBoxAvatar_NVI";
            pictureBoxAvatar_NVI.Size = new Size(178, 214);
            pictureBoxAvatar_NVI.TabIndex = 0;
            pictureBoxAvatar_NVI.TabStop = false;
            // 
            // labelText_NVI
            // 
            labelText_NVI.AutoSize = true;
            labelText_NVI.Location = new Point(223, 12);
            labelText_NVI.Name = "labelText_NVI";
            labelText_NVI.Size = new Size(387, 220);
            labelText_NVI.TabIndex = 1;
            labelText_NVI.Text = resources.GetString("labelText_NVI.Text");
            // 
            // buttonOk_NVI
            // 
            buttonOk_NVI.Location = new Point(579, 235);
            buttonOk_NVI.Name = "buttonOk_NVI";
            buttonOk_NVI.Size = new Size(99, 28);
            buttonOk_NVI.TabIndex = 2;
            buttonOk_NVI.Text = "ОК";
            buttonOk_NVI.UseVisualStyleBackColor = true;
            buttonOk_NVI.Click += buttonOk_NVI_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 275);
            Controls.Add(buttonOk_NVI);
            Controls.Add(labelText_NVI);
            Controls.Add(pictureBoxAvatar_NVI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NVI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_NVI;
        private Label labelText_NVI;
        private Button buttonOk_NVI;
    }
}