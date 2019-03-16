namespace MyBrrrrowser
{
    partial class temp
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
            this.Calc_but = new System.Windows.Forms.Button();
            this.Note_but = new System.Windows.Forms.Button();
            this.OpenPDF_but = new System.Windows.Forms.Button();
            this.OpenMP3_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calc_but
            // 
            this.Calc_but.Location = new System.Drawing.Point(56, 60);
            this.Calc_but.Name = "Calc_but";
            this.Calc_but.Size = new System.Drawing.Size(309, 53);
            this.Calc_but.TabIndex = 0;
            this.Calc_but.Text = "Запустить калькулятор";
            this.Calc_but.UseVisualStyleBackColor = true;
            this.Calc_but.Click += new System.EventHandler(this.Calc_but_Click);
            // 
            // Note_but
            // 
            this.Note_but.Location = new System.Drawing.Point(56, 119);
            this.Note_but.Name = "Note_but";
            this.Note_but.Size = new System.Drawing.Size(309, 53);
            this.Note_but.TabIndex = 1;
            this.Note_but.Text = "Запустить блокнот";
            this.Note_but.UseVisualStyleBackColor = true;
            this.Note_but.Click += new System.EventHandler(this.Note_but_Click);
            // 
            // OpenPDF_but
            // 
            this.OpenPDF_but.Location = new System.Drawing.Point(56, 178);
            this.OpenPDF_but.Name = "OpenPDF_but";
            this.OpenPDF_but.Size = new System.Drawing.Size(309, 53);
            this.OpenPDF_but.TabIndex = 2;
            this.OpenPDF_but.Text = "Открыть PDF";
            this.OpenPDF_but.UseVisualStyleBackColor = true;
            this.OpenPDF_but.Click += new System.EventHandler(this.OpenPDF_but_Click);
            // 
            // OpenMP3_but
            // 
            this.OpenMP3_but.Location = new System.Drawing.Point(56, 237);
            this.OpenMP3_but.Name = "OpenMP3_but";
            this.OpenMP3_but.Size = new System.Drawing.Size(309, 53);
            this.OpenMP3_but.TabIndex = 3;
            this.OpenMP3_but.Text = "Открыть MP3";
            this.OpenMP3_but.UseVisualStyleBackColor = true;
            this.OpenMP3_but.Click += new System.EventHandler(this.OpenMP3_but_Click);
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenMP3_but);
            this.Controls.Add(this.OpenPDF_but);
            this.Controls.Add(this.Note_but);
            this.Controls.Add(this.Calc_but);
            this.Name = "temp";
            this.Text = "temp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calc_but;
        private System.Windows.Forms.Button Note_but;
        private System.Windows.Forms.Button OpenPDF_but;
        private System.Windows.Forms.Button OpenMP3_but;
    }
}