namespace Text_File_Sort
{
    partial class Text_File_Sort
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.lab_File_Count = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.labelUnsorted = new System.Windows.Forms.Label();
            this.labelSorted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(124, 427);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(235, 55);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(732, 427);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(235, 55);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(124, 62);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(384, 290);
            this.listBox.TabIndex = 2;
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(683, 364);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(90, 13);
            this.labelFileCount.TabIndex = 3;
            this.labelFileCount.Text = "Number of Words";
            // 
            // lab_File_Count
            // 
            this.lab_File_Count.AutoSize = true;
            this.lab_File_Count.Location = new System.Drawing.Point(953, 364);
            this.lab_File_Count.Name = "lab_File_Count";
            this.lab_File_Count.Size = new System.Drawing.Size(13, 13);
            this.lab_File_Count.TabIndex = 4;
            this.lab_File_Count.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 53);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.Location = new System.Drawing.Point(583, 62);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(384, 290);
            this.listBoxSorted.TabIndex = 6;
            // 
            // labelUnsorted
            // 
            this.labelUnsorted.AutoSize = true;
            this.labelUnsorted.Location = new System.Drawing.Point(121, 33);
            this.labelUnsorted.Name = "labelUnsorted";
            this.labelUnsorted.Size = new System.Drawing.Size(59, 13);
            this.labelUnsorted.TabIndex = 7;
            this.labelUnsorted.Text = "Orginal List";
            // 
            // labelSorted
            // 
            this.labelSorted.AutoSize = true;
            this.labelSorted.Location = new System.Drawing.Point(580, 33);
            this.labelSorted.Name = "labelSorted";
            this.labelSorted.Size = new System.Drawing.Size(57, 13);
            this.labelSorted.TabIndex = 8;
            this.labelSorted.Text = "List Sorted";
            // 
            // Text_File_Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 494);
            this.Controls.Add(this.labelSorted);
            this.Controls.Add(this.labelUnsorted);
            this.Controls.Add(this.listBoxSorted);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lab_File_Count);
            this.Controls.Add(this.labelFileCount);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLoad);
            this.Name = "Text_File_Sort";
            this.Text = "Text File Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Label lab_File_Count;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.Label labelUnsorted;
        private System.Windows.Forms.Label labelSorted;
    }
}

