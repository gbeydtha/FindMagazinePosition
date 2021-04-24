namespace FindMagazinePosition
{
    partial class FindPostionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpRandomPosition = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRandomPosition = new System.Windows.Forms.TextBox();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.grpFindPosition = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequiredPositions = new System.Windows.Forms.TextBox();
            this.btnFindPosition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLinear = new System.Windows.Forms.RadioButton();
            this.btnBuildMagazine = new System.Windows.Forms.Button();
            this.rdbIsRotary = new System.Windows.Forms.RadioButton();
            this.txtPositionsInMagazine = new System.Windows.Forms.TextBox();
            this.magazinePanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.magazineToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.grpRandomPosition.SuspendLayout();
            this.grpFindPosition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postions in Magazine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.grpRandomPosition);
            this.groupBox1.Controls.Add(this.grpFindPosition);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(716, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 57);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpRandomPosition
            // 
            this.grpRandomPosition.Controls.Add(this.label3);
            this.grpRandomPosition.Controls.Add(this.txtRandomPosition);
            this.grpRandomPosition.Controls.Add(this.btnOccupied);
            this.grpRandomPosition.Location = new System.Drawing.Point(453, 11);
            this.grpRandomPosition.Name = "grpRandomPosition";
            this.grpRandomPosition.Size = new System.Drawing.Size(353, 82);
            this.grpRandomPosition.TabIndex = 2;
            this.grpRandomPosition.TabStop = false;
            this.grpRandomPosition.Text = "Set Single Random Postion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Random Postion";
            // 
            // txtRandomPosition
            // 
            this.txtRandomPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomPosition.Location = new System.Drawing.Point(131, 19);
            this.txtRandomPosition.Name = "txtRandomPosition";
            this.txtRandomPosition.Size = new System.Drawing.Size(56, 22);
            this.txtRandomPosition.TabIndex = 7;
            this.txtRandomPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRandomPosition_KeyPress);
            // 
            // btnOccupied
            // 
            this.btnOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupied.Location = new System.Drawing.Point(254, 16);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(84, 57);
            this.btnOccupied.TabIndex = 5;
            this.btnOccupied.Text = "Occupied";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // grpFindPosition
            // 
            this.grpFindPosition.Controls.Add(this.label2);
            this.grpFindPosition.Controls.Add(this.txtRequiredPositions);
            this.grpFindPosition.Controls.Add(this.btnFindPosition);
            this.grpFindPosition.Location = new System.Drawing.Point(12, 109);
            this.grpFindPosition.Name = "grpFindPosition";
            this.grpFindPosition.Size = new System.Drawing.Size(390, 85);
            this.grpFindPosition.TabIndex = 1;
            this.grpFindPosition.TabStop = false;
            this.grpFindPosition.Text = "Find Postion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Needed Places";
            // 
            // txtRequiredPositions
            // 
            this.txtRequiredPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredPositions.Location = new System.Drawing.Point(134, 31);
            this.txtRequiredPositions.Name = "txtRequiredPositions";
            this.txtRequiredPositions.Size = new System.Drawing.Size(56, 22);
            this.txtRequiredPositions.TabIndex = 7;
            this.txtRequiredPositions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequiredPositions_KeyPress);
            // 
            // btnFindPosition
            // 
            this.btnFindPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPosition.Location = new System.Drawing.Point(293, 19);
            this.btnFindPosition.Name = "btnFindPosition";
            this.btnFindPosition.Size = new System.Drawing.Size(84, 57);
            this.btnFindPosition.TabIndex = 5;
            this.btnFindPosition.Text = "Find Places";
            this.btnFindPosition.UseVisualStyleBackColor = true;
            this.btnFindPosition.Click += new System.EventHandler(this.btnFindPosition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLinear);
            this.groupBox2.Controls.Add(this.btnBuildMagazine);
            this.groupBox2.Controls.Add(this.rdbIsRotary);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPositionsInMagazine);
            this.groupBox2.Location = new System.Drawing.Point(14, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Magazine";
            // 
            // rdbLinear
            // 
            this.rdbLinear.AutoSize = true;
            this.rdbLinear.Location = new System.Drawing.Point(212, 48);
            this.rdbLinear.Name = "rdbLinear";
            this.rdbLinear.Size = new System.Drawing.Size(57, 17);
            this.rdbLinear.TabIndex = 3;
            this.rdbLinear.TabStop = true;
            this.rdbLinear.Text = "Linear ";
            this.rdbLinear.UseVisualStyleBackColor = true;
            // 
            // btnBuildMagazine
            // 
            this.btnBuildMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildMagazine.Location = new System.Drawing.Point(291, 13);
            this.btnBuildMagazine.Name = "btnBuildMagazine";
            this.btnBuildMagazine.Size = new System.Drawing.Size(84, 57);
            this.btnBuildMagazine.TabIndex = 4;
            this.btnBuildMagazine.Text = "Build Magazine";
            this.btnBuildMagazine.UseVisualStyleBackColor = true;
            this.btnBuildMagazine.Click += new System.EventHandler(this.btnBuildMagazine_Click);
            // 
            // rdbIsRotary
            // 
            this.rdbIsRotary.AutoSize = true;
            this.rdbIsRotary.Location = new System.Drawing.Point(132, 48);
            this.rdbIsRotary.Name = "rdbIsRotary";
            this.rdbIsRotary.Size = new System.Drawing.Size(56, 17);
            this.rdbIsRotary.TabIndex = 2;
            this.rdbIsRotary.TabStop = true;
            this.rdbIsRotary.Text = "Rotary";
            this.rdbIsRotary.UseVisualStyleBackColor = true;
            // 
            // txtPositionsInMagazine
            // 
            this.txtPositionsInMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionsInMagazine.Location = new System.Drawing.Point(132, 13);
            this.txtPositionsInMagazine.Name = "txtPositionsInMagazine";
            this.txtPositionsInMagazine.Size = new System.Drawing.Size(56, 22);
            this.txtPositionsInMagazine.TabIndex = 1;
            this.txtPositionsInMagazine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPositionsInMagazine_KeyPress);
            // 
            // magazinePanel
            // 
            this.magazinePanel.AutoScroll = true;
            this.magazinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.magazinePanel.Location = new System.Drawing.Point(0, 291);
            this.magazinePanel.Name = "magazinePanel";
            this.magazinePanel.Size = new System.Drawing.Size(873, 162);
            this.magazinePanel.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magazineToolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // magazineToolStripStatus
            // 
            this.magazineToolStripStatus.Name = "magazineToolStripStatus";
            this.magazineToolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FindPostionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(873, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.magazinePanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FindPostionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Places in Magazine";
            this.Load += new System.EventHandler(this.FindPostionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpRandomPosition.ResumeLayout(false);
            this.grpRandomPosition.PerformLayout();
            this.grpFindPosition.ResumeLayout(false);
            this.grpFindPosition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpFindPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequiredPositions;
        private System.Windows.Forms.Button btnFindPosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLinear;
        private System.Windows.Forms.Button btnBuildMagazine;
        private System.Windows.Forms.RadioButton rdbIsRotary;
        private System.Windows.Forms.TextBox txtPositionsInMagazine;
        private System.Windows.Forms.Panel magazinePanel;
        private System.Windows.Forms.GroupBox grpRandomPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRandomPosition;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel magazineToolStripStatus;
    }
}

