
namespace Sortowanie
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
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.Label();
            this.Liczby = new System.Windows.Forms.Label();
            this.Czas = new System.Windows.Forms.Label();
            this.NumericUpDownLiczby = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonQuickSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLiczby)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(12, 12);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(109, 23);
            this.ButtonBubbleSort.TabIndex = 0;
            this.ButtonBubbleSort.Text = "Sortuj Bąbelkowo";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wynik.Location = new System.Drawing.Point(12, 60);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(30, 21);
            this.Wynik.TabIndex = 1;
            this.Wynik.Text = "nic";
            // 
            // Liczby
            // 
            this.Liczby.AutoSize = true;
            this.Liczby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Liczby.Location = new System.Drawing.Point(619, 60);
            this.Liczby.Name = "Liczby";
            this.Liczby.Size = new System.Drawing.Size(30, 21);
            this.Liczby.TabIndex = 2;
            this.Liczby.Text = "nic";
            this.Liczby.Click += new System.EventHandler(this.Liczby_Click);
            // 
            // Czas
            // 
            this.Czas.AutoSize = true;
            this.Czas.Location = new System.Drawing.Point(256, 16);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(16, 15);
            this.Czas.TabIndex = 3;
            this.Czas.Text = "...";
            // 
            // NumericUpDownLiczby
            // 
            this.NumericUpDownLiczby.Location = new System.Drawing.Point(519, 14);
            this.NumericUpDownLiczby.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumericUpDownLiczby.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownLiczby.Name = "NumericUpDownLiczby";
            this.NumericUpDownLiczby.Size = new System.Drawing.Size(120, 23);
            this.NumericUpDownLiczby.TabIndex = 4;
            this.NumericUpDownLiczby.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilosc generowanych liczb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Input";
            // 
            // ButtonQuickSort
            // 
            this.ButtonQuickSort.Location = new System.Drawing.Point(127, 12);
            this.ButtonQuickSort.Name = "ButtonQuickSort";
            this.ButtonQuickSort.Size = new System.Drawing.Size(129, 23);
            this.ButtonQuickSort.TabIndex = 8;
            this.ButtonQuickSort.Text = "Quick";
            this.ButtonQuickSort.UseVisualStyleBackColor = true;
            this.ButtonQuickSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.ButtonQuickSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownLiczby);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.Liczby);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLiczby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Label Liczby;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.NumericUpDown NumericUpDownLiczby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonQuickSort;
    }
}

