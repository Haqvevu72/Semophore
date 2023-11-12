namespace Semophore
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
            Working_Threads = new ListBox();
            Waiting_Threads = new ListBox();
            Created_Threads = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Create_Button = new Button();
            SuspendLayout();
            // 
            // Working_Threads
            // 
            Working_Threads.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Working_Threads.ForeColor = Color.SaddleBrown;
            Working_Threads.FormattingEnabled = true;
            Working_Threads.ItemHeight = 20;
            Working_Threads.Location = new Point(22, 45);
            Working_Threads.Name = "Working_Threads";
            Working_Threads.Size = new Size(175, 204);
            Working_Threads.TabIndex = 0;
            // 
            // Waiting_Threads
            // 
            Waiting_Threads.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Waiting_Threads.ForeColor = Color.SaddleBrown;
            Waiting_Threads.FormattingEnabled = true;
            Waiting_Threads.ItemHeight = 20;
            Waiting_Threads.Location = new Point(312, 45);
            Waiting_Threads.Name = "Waiting_Threads";
            Waiting_Threads.Size = new Size(175, 204);
            Waiting_Threads.TabIndex = 1;
            Waiting_Threads.MouseDoubleClick += Waiting_Threads_MouseDoubleClick;
            // 
            // Created_Threads
            // 
            Created_Threads.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Created_Threads.ForeColor = Color.SaddleBrown;
            Created_Threads.FormattingEnabled = true;
            Created_Threads.ItemHeight = 20;
            Created_Threads.Location = new Point(599, 45);
            Created_Threads.Name = "Created_Threads";
            Created_Threads.Size = new Size(175, 204);
            Created_Threads.TabIndex = 2;
            Created_Threads.MouseDoubleClick += Created_Threads_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 3;
            label1.Text = "Working Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(312, 19);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 4;
            label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(599, 19);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 5;
            label3.Text = "Created Thread";
            // 
            // Create_Button
            // 
            Create_Button.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Create_Button.Location = new Point(653, 328);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(103, 37);
            Create_Button.TabIndex = 6;
            Create_Button.Text = "Create";
            Create_Button.UseVisualStyleBackColor = true;
            Create_Button.Click += Create_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(Create_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Created_Threads);
            Controls.Add(Waiting_Threads);
            Controls.Add(Working_Threads);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Working_Threads;
        private ListBox Waiting_Threads;
        private ListBox Created_Threads;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Create_Button;
    }
}