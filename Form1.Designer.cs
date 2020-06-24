namespace lista4_zad2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFileB = new System.Windows.Forms.Button();
            this.FileDestBox = new System.Windows.Forms.TextBox();
            this.SaveFileB = new System.Windows.Forms.Button();
            this.NewFileB = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.RepleaseBox = new System.Windows.Forms.TextBox();
            this.RepleaseB = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ReadFileB
            // 
            this.ReadFileB.Location = new System.Drawing.Point(647, 68);
            this.ReadFileB.Margin = new System.Windows.Forms.Padding(2);
            this.ReadFileB.Name = "ReadFileB";
            this.ReadFileB.Size = new System.Drawing.Size(96, 29);
            this.ReadFileB.TabIndex = 0;
            this.ReadFileB.Text = "Wczytaj";
            this.ReadFileB.UseVisualStyleBackColor = true;
            this.ReadFileB.Click += new System.EventHandler(this.ReadFileB_Click);
            // 
            // FileDestBox
            // 
            this.FileDestBox.Location = new System.Drawing.Point(647, 43);
            this.FileDestBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileDestBox.Name = "FileDestBox";
            this.FileDestBox.Size = new System.Drawing.Size(92, 20);
            this.FileDestBox.TabIndex = 1;
            // 
            // SaveFileB
            // 
            this.SaveFileB.Location = new System.Drawing.Point(647, 100);
            this.SaveFileB.Margin = new System.Windows.Forms.Padding(2);
            this.SaveFileB.Name = "SaveFileB";
            this.SaveFileB.Size = new System.Drawing.Size(96, 29);
            this.SaveFileB.TabIndex = 2;
            this.SaveFileB.Text = "Zapisz";
            this.SaveFileB.UseVisualStyleBackColor = true;
            this.SaveFileB.Click += new System.EventHandler(this.SaveFileB_Click);
            // 
            // NewFileB
            // 
            this.NewFileB.Location = new System.Drawing.Point(647, 10);
            this.NewFileB.Margin = new System.Windows.Forms.Padding(2);
            this.NewFileB.Name = "NewFileB";
            this.NewFileB.Size = new System.Drawing.Size(96, 29);
            this.NewFileB.TabIndex = 3;
            this.NewFileB.Text = "Nowy";
            this.NewFileB.UseVisualStyleBackColor = true;
            this.NewFileB.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(647, 137);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(96, 20);
            this.SearchBox.TabIndex = 4;
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(647, 161);
            this.SearchB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(96, 29);
            this.SearchB.TabIndex = 5;
            this.SearchB.Text = "Wyszukaj";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // RepleaseBox
            // 
            this.RepleaseBox.Location = new System.Drawing.Point(647, 194);
            this.RepleaseBox.Margin = new System.Windows.Forms.Padding(2);
            this.RepleaseBox.Name = "RepleaseBox";
            this.RepleaseBox.Size = new System.Drawing.Size(96, 20);
            this.RepleaseBox.TabIndex = 6;
            // 
            // RepleaseB
            // 
            this.RepleaseB.Location = new System.Drawing.Point(647, 218);
            this.RepleaseB.Margin = new System.Windows.Forms.Padding(2);
            this.RepleaseB.Name = "RepleaseB";
            this.RepleaseB.Size = new System.Drawing.Size(96, 29);
            this.RepleaseB.TabIndex = 7;
            this.RepleaseB.Text = "Zamień";
            this.RepleaseB.UseVisualStyleBackColor = true;
            this.RepleaseB.Click += new System.EventHandler(this.RepleaseB_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(632, 439);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 458);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RepleaseB);
            this.Controls.Add(this.RepleaseBox);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.NewFileB);
            this.Controls.Add(this.SaveFileB);
            this.Controls.Add(this.FileDestBox);
            this.Controls.Add(this.ReadFileB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Edytor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFileB;
        private System.Windows.Forms.TextBox FileDestBox;
        private System.Windows.Forms.Button SaveFileB;
        private System.Windows.Forms.Button NewFileB;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox RepleaseBox;
        private System.Windows.Forms.Button RepleaseB;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

