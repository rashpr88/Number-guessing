
namespace number_guessing
{
    partial class f
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
            this.game = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Guessing";
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.DarkOrange;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.ForeColor = System.Drawing.Color.Black;
            this.game.Location = new System.Drawing.Point(125, 139);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(157, 36);
            this.game.TabIndex = 1;
            this.game.Text = "Start Game";
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.SpringGreen;
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(292, 86);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(63, 26);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // box
            // 
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(113, 90);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(157, 22);
            this.box.TabIndex = 3;
            this.box.Visible = false;
            this.box.TextChanged += new System.EventHandler(this.box_TextChanged);
            this.box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num.Location = new System.Drawing.Point(8, 93);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(99, 16);
            this.num.TabIndex = 4;
            this.num.Text = "Enter Number : ";
            this.num.Visible = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.BlueViolet;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.Black;
            this.home.Location = new System.Drawing.Point(326, 219);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 34);
            this.home.TabIndex = 5;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Visible = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.home);
            this.Controls.Add(this.num);
            this.Controls.Add(this.box);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.game);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "f";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button home;
    }
}

