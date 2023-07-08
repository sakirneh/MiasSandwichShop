namespace MiasSandwichShop
{
    partial class WelcomeForm
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
            this.clcToShopBTN = new System.Windows.Forms.Button();
            this.logoPicBoxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.helpBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // clcToShopBTN
            // 
            this.clcToShopBTN.Location = new System.Drawing.Point(291, 309);
            this.clcToShopBTN.Name = "clcToShopBTN";
            this.clcToShopBTN.Size = new System.Drawing.Size(200, 55);
            this.clcToShopBTN.TabIndex = 0;
            this.clcToShopBTN.Text = "Click to Shop";
            this.clcToShopBTN.UseVisualStyleBackColor = true;
            this.clcToShopBTN.Click += new System.EventHandler(this.clcToShopBTN_Click);
            // 
            // logoPicBoxImage
            // 
            this.logoPicBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPicBoxImage.Location = new System.Drawing.Point(291, 12);
            this.logoPicBoxImage.Name = "logoPicBoxImage";
            this.logoPicBoxImage.Size = new System.Drawing.Size(200, 200);
            this.logoPicBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBoxImage.TabIndex = 1;
            this.logoPicBoxImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Mia\'s Sandwich Shop";
            // 
            // helpBTN
            // 
            this.helpBTN.Location = new System.Drawing.Point(291, 386);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(200, 55);
            this.helpBTN.TabIndex = 3;
            this.helpBTN.Text = "Help";
            this.helpBTN.UseVisualStyleBackColor = true;
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.helpBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPicBoxImage);
            this.Controls.Add(this.clcToShopBTN);
            this.Name = "WelcomeForm";
            this.Text = "Mia\'s Sandwich Shop";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clcToShopBTN;
        private PictureBox logoPicBoxImage;
        private Label label1;
        private Button helpBTN;
    }
}