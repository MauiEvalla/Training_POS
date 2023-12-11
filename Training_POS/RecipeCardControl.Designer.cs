namespace Training_POS
{
    partial class RecipeCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRecipeName = new System.Windows.Forms.Label();
            this.labelCookingTime = new System.Windows.Forms.Label();
            this.labelServings = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRecipeName
            // 
            this.labelRecipeName.AutoSize = true;
            this.labelRecipeName.Font = new System.Drawing.Font("Roboto Bk", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipeName.Location = new System.Drawing.Point(77, 26);
            this.labelRecipeName.Name = "labelRecipeName";
            this.labelRecipeName.Size = new System.Drawing.Size(111, 22);
            this.labelRecipeName.TabIndex = 0;
            this.labelRecipeName.Text = "RecipeName";
            // 
            // labelCookingTime
            // 
            this.labelCookingTime.AutoSize = true;
            this.labelCookingTime.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCookingTime.Location = new System.Drawing.Point(19, 245);
            this.labelCookingTime.Name = "labelCookingTime";
            this.labelCookingTime.Size = new System.Drawing.Size(127, 18);
            this.labelCookingTime.TabIndex = 1;
            this.labelCookingTime.Text = "labelCookingTime";
            // 
            // labelServings
            // 
            this.labelServings.AutoSize = true;
            this.labelServings.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServings.Location = new System.Drawing.Point(19, 279);
            this.labelServings.Name = "labelServings";
            this.labelServings.Size = new System.Drawing.Size(66, 18);
            this.labelServings.TabIndex = 2;
            this.labelServings.Text = "Servings";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngredients.Location = new System.Drawing.Point(19, 160);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(82, 18);
            this.labelIngredients.TabIndex = 3;
            this.labelIngredients.Text = "Ingredients";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(19, 120);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(53, 18);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "UserID";
            // 
            // RecipeCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.labelServings);
            this.Controls.Add(this.labelCookingTime);
            this.Controls.Add(this.labelRecipeName);
            this.Name = "RecipeCardControl";
            this.Size = new System.Drawing.Size(261, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRecipeName;
        private System.Windows.Forms.Label labelCookingTime;
        private System.Windows.Forms.Label labelServings;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelUserID;
    }
}
