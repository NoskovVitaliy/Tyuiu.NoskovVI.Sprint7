namespace Project.V8
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            labelGuide_NVI = new Label();
            buttonClose_NVI = new Button();
            SuspendLayout();
            // 
            // labelGuide_NVI
            // 
            labelGuide_NVI.AutoSize = true;
            labelGuide_NVI.Location = new Point(3, 50);
            labelGuide_NVI.Name = "labelGuide_NVI";
            labelGuide_NVI.Size = new Size(790, 300);
            labelGuide_NVI.TabIndex = 0;
            labelGuide_NVI.Text = resources.GetString("labelGuide_NVI.Text");
            // 
            // buttonClose_NVI
            // 
            buttonClose_NVI.Location = new Point(694, 409);
            buttonClose_NVI.Name = "buttonClose_NVI";
            buttonClose_NVI.Size = new Size(94, 29);
            buttonClose_NVI.TabIndex = 1;
            buttonClose_NVI.Text = "ОК";
            buttonClose_NVI.UseVisualStyleBackColor = true;
            buttonClose_NVI.Click += buttonClose_NVI_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose_NVI);
            Controls.Add(labelGuide_NVI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuide_NVI;
        private Button buttonClose_NVI;
    }
}