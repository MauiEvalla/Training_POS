namespace Training_POS
{
    partial class MainPage
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
            this.flowLayoutPanelRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.addRecipeBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanelRecipes
            // 
            this.flowLayoutPanelRecipes.Location = new System.Drawing.Point(19, 142);
            this.flowLayoutPanelRecipes.Name = "flowLayoutPanelRecipes";
            this.flowLayoutPanelRecipes.Size = new System.Drawing.Size(1360, 289);
            this.flowLayoutPanelRecipes.TabIndex = 0;
            // 
            // addRecipeBtn
            // 
            this.addRecipeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addRecipeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addRecipeBtn.Depth = 0;
            this.addRecipeBtn.HighEmphasis = true;
            this.addRecipeBtn.Icon = null;
            this.addRecipeBtn.Location = new System.Drawing.Point(1179, 84);
            this.addRecipeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addRecipeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addRecipeBtn.Name = "addRecipeBtn";
            this.addRecipeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addRecipeBtn.Size = new System.Drawing.Size(132, 36);
            this.addRecipeBtn.TabIndex = 1;
            this.addRecipeBtn.Text = "Add Recipe";
            this.addRecipeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addRecipeBtn.UseAccentColor = false;
            this.addRecipeBtn.UseVisualStyleBackColor = true;
            this.addRecipeBtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1385, 450);
            this.Controls.Add(this.addRecipeBtn);
            this.Controls.Add(this.flowLayoutPanelRecipes);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecipes;
        private MaterialSkin.Controls.MaterialButton addRecipeBtn;
    }
}