namespace WinForms3
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
            lstSource = new ListBox();
            lstDest = new ListBox();
            buttonAddDest = new Button();
            buttonAddDestAll = new Button();
            buttonClearDest = new Button();
            checkDell = new CheckBox();
            buttonDellDest = new Button();
            buttonDellDestAll = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            btnForm2 = new Button();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.ItemHeight = 15;
            lstSource.Items.AddRange(new object[] { "физика", "химия", "литература", "математика", "биология" });
            lstSource.Location = new Point(12, 29);
            lstSource.Name = "lstSource";
            lstSource.SelectionMode = SelectionMode.MultiSimple;
            lstSource.Size = new Size(120, 379);
            lstSource.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.ItemHeight = 15;
            lstDest.Location = new Point(285, 29);
            lstDest.Name = "lstDest";
            lstDest.Size = new Size(120, 379);
            lstDest.TabIndex = 1;
            // 
            // buttonAddDest
            // 
            buttonAddDest.Location = new Point(169, 65);
            buttonAddDest.Name = "buttonAddDest";
            buttonAddDest.Size = new Size(75, 23);
            buttonAddDest.TabIndex = 2;
            buttonAddDest.Text = "->";
            buttonAddDest.UseVisualStyleBackColor = true;
            buttonAddDest.Click += buttonAddDest_Click;
            // 
            // buttonAddDestAll
            // 
            buttonAddDestAll.Location = new Point(169, 103);
            buttonAddDestAll.Name = "buttonAddDestAll";
            buttonAddDestAll.Size = new Size(75, 23);
            buttonAddDestAll.TabIndex = 3;
            buttonAddDestAll.Text = "->>";
            buttonAddDestAll.UseVisualStyleBackColor = true;
            buttonAddDestAll.Click += buttonAddDestAll_Click;
            // 
            // buttonClearDest
            // 
            buttonClearDest.Enabled = false;
            buttonClearDest.Location = new Point(169, 327);
            buttonClearDest.Name = "buttonClearDest";
            buttonClearDest.Size = new Size(75, 23);
            buttonClearDest.TabIndex = 4;
            buttonClearDest.Text = "Clear";
            buttonClearDest.UseVisualStyleBackColor = true;
            buttonClearDest.Click += buttonClearDest_Click;
            // 
            // checkDell
            // 
            checkDell.AutoSize = true;
            checkDell.Location = new Point(434, 29);
            checkDell.Name = "checkDell";
            checkDell.Size = new Size(145, 19);
            checkDell.TabIndex = 5;
            checkDell.Text = "Удалять из источника";
            checkDell.UseVisualStyleBackColor = true;
            // 
            // buttonDellDest
            // 
            buttonDellDest.Enabled = false;
            buttonDellDest.Location = new Point(169, 192);
            buttonDellDest.Name = "buttonDellDest";
            buttonDellDest.Size = new Size(75, 23);
            buttonDellDest.TabIndex = 6;
            buttonDellDest.Text = "<-";
            buttonDellDest.UseVisualStyleBackColor = true;
            buttonDellDest.Click += buttonDellDest_Click;
            // 
            // buttonDellDestAll
            // 
            buttonDellDestAll.Enabled = false;
            buttonDellDestAll.Location = new Point(169, 230);
            buttonDellDestAll.Name = "buttonDellDestAll";
            buttonDellDestAll.Size = new Size(75, 23);
            buttonDellDestAll.TabIndex = 7;
            buttonDellDestAll.Text = "<<-";
            buttonDellDestAll.UseVisualStyleBackColor = true;
            buttonDellDestAll.Click += buttonDellDestAll_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(285, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(120, 14);
            progressBar1.TabIndex = 8;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 414);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(120, 15);
            progressBar2.TabIndex = 9;
            progressBar2.Click += progressBar2_Click;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(434, 54);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(75, 23);
            btnForm2.TabIndex = 10;
            btnForm2.Text = "Открыть";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(buttonDellDestAll);
            Controls.Add(buttonDellDest);
            Controls.Add(checkDell);
            Controls.Add(buttonClearDest);
            Controls.Add(buttonAddDestAll);
            Controls.Add(buttonAddDest);
            Controls.Add(lstDest);
            Controls.Add(lstSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private ListBox lstDest;
        private Button buttonAddDest;
        private Button buttonAddDestAll;
        private Button buttonClearDest;
        private CheckBox checkDell;
        private Button buttonDellDest;
        private Button buttonDellDestAll;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Button btnForm2;
    }
}
