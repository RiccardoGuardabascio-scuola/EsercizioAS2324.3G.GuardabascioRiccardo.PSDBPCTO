namespace EsercizioAS2324._3G.GuardabascioRiccardo.PSDBPCTO
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
            components = new System.ComponentModel.Container();
            dgvDati = new DataGridView();
            btnPiloti = new Button();
            btnGare = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
            SuspendLayout();
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(121, 194);
            dgvDati.Name = "dgvDati";
            dgvDati.RowTemplate.Height = 25;
            dgvDati.Size = new Size(509, 214);
            dgvDati.TabIndex = 0;
            // 
            // btnPiloti
            // 
            btnPiloti.Location = new Point(82, 81);
            btnPiloti.Name = "btnPiloti";
            btnPiloti.Size = new Size(75, 23);
            btnPiloti.TabIndex = 1;
            btnPiloti.Text = "Piloti";
            btnPiloti.UseVisualStyleBackColor = true;
            btnPiloti.Click += btnPiloti_Click;
            // 
            // btnGare
            // 
            btnGare.Location = new Point(232, 81);
            btnGare.Name = "btnGare";
            btnGare.Size = new Size(75, 23);
            btnGare.TabIndex = 2;
            btnGare.Text = "Gare";
            btnGare.UseVisualStyleBackColor = true;
            btnGare.Click += btnGare_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGare);
            Controls.Add(btnPiloti);
            Controls.Add(dgvDati);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDati;
        private Button btnPiloti;
        private Button btnGare;
        private ToolTip toolTip1;
    }
}
