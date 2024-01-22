namespace Training_POS
{
    partial class AddRecipeForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRecipeName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtIngredients = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.pictureBoxRecipe = new System.Windows.Forms.PictureBox();
            this.btnSubmitRecipe = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.inputTimer = new System.Windows.Forms.NumericUpDown();
            this.inputServings = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblServings = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputServings)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(244, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(242, 58);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Add Recipe";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.AllowPromptAsInput = true;
            this.txtRecipeName.AnimateReadOnly = false;
            this.txtRecipeName.AsciiOnly = false;
            this.txtRecipeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRecipeName.BeepOnError = false;
            this.txtRecipeName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRecipeName.Depth = 0;
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecipeName.HidePromptOnLeave = false;
            this.txtRecipeName.HideSelection = true;
            this.txtRecipeName.Hint = "Enter name of recipe";
            this.txtRecipeName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRecipeName.LeadingIcon = null;
            this.txtRecipeName.Location = new System.Drawing.Point(30, 195);
            this.txtRecipeName.Mask = "";
            this.txtRecipeName.MaxLength = 32767;
            this.txtRecipeName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.PasswordChar = '\0';
            this.txtRecipeName.PrefixSuffixText = null;
            this.txtRecipeName.PromptChar = '_';
            this.txtRecipeName.ReadOnly = false;
            this.txtRecipeName.RejectInputOnFirstFailure = false;
            this.txtRecipeName.ResetOnPrompt = true;
            this.txtRecipeName.ResetOnSpace = true;
            this.txtRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecipeName.SelectedText = "";
            this.txtRecipeName.SelectionLength = 0;
            this.txtRecipeName.SelectionStart = 0;
            this.txtRecipeName.ShortcutsEnabled = true;
            this.txtRecipeName.Size = new System.Drawing.Size(250, 48);
            this.txtRecipeName.SkipLiterals = true;
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.TabStop = false;
            this.txtRecipeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRecipeName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRecipeName.TrailingIcon = null;
            this.txtRecipeName.UseSystemPasswordChar = false;
            this.txtRecipeName.ValidatingType = null;
            // 
            // txtIngredients
            // 
            this.txtIngredients.AnimateReadOnly = false;
            this.txtIngredients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIngredients.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIngredients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngredients.Depth = 0;
            this.txtIngredients.HideSelection = true;
            this.txtIngredients.Hint = "Enter Ingredients";
            this.txtIngredients.Location = new System.Drawing.Point(30, 265);
            this.txtIngredients.MaxLength = 32767;
            this.txtIngredients.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.PasswordChar = '\0';
            this.txtIngredients.ReadOnly = false;
            this.txtIngredients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIngredients.SelectedText = "";
            this.txtIngredients.SelectionLength = 0;
            this.txtIngredients.SelectionStart = 0;
            this.txtIngredients.ShortcutsEnabled = true;
            this.txtIngredients.Size = new System.Drawing.Size(250, 100);
            this.txtIngredients.TabIndex = 2;
            this.txtIngredients.TabStop = false;
            this.txtIngredients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIngredients.UseSystemPasswordChar = false;
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(550, 159);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(172, 176);
            this.pictureBoxRecipe.TabIndex = 3;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // btnSubmitRecipe
            // 
            this.btnSubmitRecipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmitRecipe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmitRecipe.Depth = 0;
            this.btnSubmitRecipe.HighEmphasis = true;
            this.btnSubmitRecipe.Icon = null;
            this.btnSubmitRecipe.Location = new System.Drawing.Point(317, 508);
            this.btnSubmitRecipe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmitRecipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmitRecipe.Name = "btnSubmitRecipe";
            this.btnSubmitRecipe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmitRecipe.Size = new System.Drawing.Size(158, 36);
            this.btnSubmitRecipe.TabIndex = 4;
            this.btnSubmitRecipe.Text = "Submit";
            this.btnSubmitRecipe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmitRecipe.UseAccentColor = false;
            this.btnSubmitRecipe.UseVisualStyleBackColor = true;
            this.btnSubmitRecipe.Click += new System.EventHandler(this.btnSubmitRecipe_Click);
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Location = new System.Drawing.Point(576, 342);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(121, 23);
            this.btnBrowseImg.TabIndex = 5;
            this.btnBrowseImg.Text = "Browse Image";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // inputTimer
            // 
            this.inputTimer.Location = new System.Drawing.Point(30, 403);
            this.inputTimer.Name = "inputTimer";
            this.inputTimer.Size = new System.Drawing.Size(250, 22);
            this.inputTimer.TabIndex = 7;
            // 
            // inputServings
            // 
            this.inputServings.Location = new System.Drawing.Point(30, 459);
            this.inputServings.Name = "inputServings";
            this.inputServings.Size = new System.Drawing.Size(250, 22);
            this.inputServings.TabIndex = 8;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Depth = 0;
            this.labelTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTime.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelTime.Location = new System.Drawing.Point(27, 381);
            this.labelTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(85, 17);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Cooking time";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Depth = 0;
            this.lblServings.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblServings.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lblServings.Location = new System.Drawing.Point(27, 437);
            this.lblServings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(56, 17);
            this.lblServings.TabIndex = 10;
            this.lblServings.Text = "Servings";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 607);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.inputServings);
            this.Controls.Add(this.inputTimer);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.btnSubmitRecipe);
            this.Controls.Add(this.pictureBoxRecipe);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddRecipeForm";
            this.Text = "Add Recipe Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputServings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRecipeName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtIngredients;
        private System.Windows.Forms.PictureBox pictureBoxRecipe;
        private MaterialSkin.Controls.MaterialButton btnSubmitRecipe;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.NumericUpDown inputTimer;
        private System.Windows.Forms.NumericUpDown inputServings;
        private MaterialSkin.Controls.MaterialLabel labelTime;
        private MaterialSkin.Controls.MaterialLabel lblServings;
    }
}