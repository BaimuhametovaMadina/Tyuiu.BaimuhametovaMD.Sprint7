namespace Project.V4
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxReadme_BMD = new TextBox();
            textBoxAbout_BMD = new TextBox();
            labelReadme_BMD = new Label();
            buttonClose_BMD = new Button();
            SuspendLayout();
            // 
            // textBoxReadme_BMD
            // 
            textBoxReadme_BMD.BackColor = Color.FromArgb(192, 255, 192);
            textBoxReadme_BMD.BorderStyle = BorderStyle.None;
            textBoxReadme_BMD.Location = new Point(12, 132);
            textBoxReadme_BMD.Multiline = true;
            textBoxReadme_BMD.Name = "textBoxReadme_BMD";
            textBoxReadme_BMD.ReadOnly = true;
            textBoxReadme_BMD.Size = new Size(776, 213);
            textBoxReadme_BMD.TabIndex = 0;
            textBoxReadme_BMD.TabStop = false;
            textBoxReadme_BMD.Text = resources.GetString("textBoxReadme_BMD.Text");
            // 
            // textBoxAbout_BMD
            // 
            textBoxAbout_BMD.BorderStyle = BorderStyle.None;
            textBoxAbout_BMD.Location = new Point(12, 12);
            textBoxAbout_BMD.Multiline = true;
            textBoxAbout_BMD.Name = "textBoxAbout_BMD";
            textBoxAbout_BMD.ReadOnly = true;
            textBoxAbout_BMD.Size = new Size(489, 55);
            textBoxAbout_BMD.TabIndex = 1;
            textBoxAbout_BMD.TabStop = false;
            textBoxAbout_BMD.Text = "Программа предназначена для управления внутренними базами данных библиотеки.\r\n\r\nРазработка: Баймухаметова М.Д., группа ИБКСб-24-1";
            // 
            // labelReadme_BMD
            // 
            labelReadme_BMD.AutoSize = true;
            labelReadme_BMD.Location = new Point(12, 103);
            labelReadme_BMD.Name = "labelReadme_BMD";
            labelReadme_BMD.Size = new Size(175, 15);
            labelReadme_BMD.TabIndex = 2;
            labelReadme_BMD.Text = "Как использовать программу?";
            // 
            // buttonClose_BMD
            // 
            buttonClose_BMD.Location = new Point(633, 351);
            buttonClose_BMD.Name = "buttonClose_BMD";
            buttonClose_BMD.Size = new Size(155, 33);
            buttonClose_BMD.TabIndex = 3;
            buttonClose_BMD.Text = "Хорошо, я понял(а)";
            buttonClose_BMD.UseVisualStyleBackColor = true;
            buttonClose_BMD.Click += buttonClose_BMD_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 390);
            Controls.Add(buttonClose_BMD);
            Controls.Add(labelReadme_BMD);
            Controls.Add(textBoxAbout_BMD);
            Controls.Add(textBoxReadme_BMD);
            Name = "FormHelp";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxReadme_BMD;
        private TextBox textBoxAbout_BMD;
        private Label labelReadme_BMD;
        private Button buttonClose_BMD;
    }
}