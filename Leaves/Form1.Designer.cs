namespace Leaves
{
    partial class Form1
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.north = new System.Windows.Forms.Button();
            this.south = new System.Windows.Forms.Button();
            this.east = new System.Windows.Forms.Button();
            this.west = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.DarkRed;
            this.pb1.Location = new System.Drawing.Point(169, 213);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(37, 36);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.DarkRed;
            this.pb2.Location = new System.Drawing.Point(212, 213);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(37, 36);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.DarkRed;
            this.pb3.Location = new System.Drawing.Point(255, 213);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(37, 36);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.DarkRed;
            this.pb4.Location = new System.Drawing.Point(298, 213);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(37, 36);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.DarkRed;
            this.pb5.Location = new System.Drawing.Point(343, 213);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(37, 36);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            // 
            // north
            // 
            this.north.Location = new System.Drawing.Point(253, 79);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(39, 43);
            this.north.TabIndex = 5;
            this.north.Text = "north";
            this.north.UseVisualStyleBackColor = true;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // south
            // 
            this.south.Location = new System.Drawing.Point(253, 331);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(53, 26);
            this.south.TabIndex = 6;
            this.south.Text = "south";
            this.south.UseVisualStyleBackColor = true;
            this.south.Click += new System.EventHandler(this.south_Click);
            // 
            // east
            // 
            this.east.Location = new System.Drawing.Point(468, 206);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(39, 43);
            this.east.TabIndex = 7;
            this.east.Text = "east";
            this.east.UseVisualStyleBackColor = true;
            this.east.Click += new System.EventHandler(this.east_Click);
            // 
            // west
            // 
            this.west.Location = new System.Drawing.Point(39, 213);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(39, 43);
            this.west.TabIndex = 8;
            this.west.Text = "west";
            this.west.UseVisualStyleBackColor = true;
            this.west.Click += new System.EventHandler(this.west_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(468, 66);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(54, 66);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 10;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 483);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.west);
            this.Controls.Add(this.east);
            this.Controls.Add(this.south);
            this.Controls.Add(this.north);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Button north;
        private System.Windows.Forms.Button south;
        private System.Windows.Forms.Button east;
        private System.Windows.Forms.Button west;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
    }
}

