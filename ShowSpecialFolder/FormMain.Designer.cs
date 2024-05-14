namespace ShowSpecialFolder
{
    partial class FormMain
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
            txtMain = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // txtMain
            // 
            txtMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMain.Location = new Point(12, 12);
            txtMain.Multiline = true;
            txtMain.Name = "txtMain";
            txtMain.ReadOnly = true;
            txtMain.ScrollBars = ScrollBars.Both;
            txtMain.Size = new Size(866, 631);
            txtMain.TabIndex = 1;
            txtMain.WordWrap = false;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(758, 649);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 684);
            Controls.Add(btnOK);
            Controls.Add(txtMain);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMain;
        private Button btnOK;
    }
}