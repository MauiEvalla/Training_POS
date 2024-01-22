using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_POS
{
    public partial class RecipeCardControl : UserControl
    {
        public RecipeCardControl()
        {
            InitializeComponent();
        }

        private Recipe recipe;

        public RecipeCardControl(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            UpdateCard();
        }

        private void UpdateCard()
        {
            // Customize this method based on your controls
            labelRecipeName.Text = recipe.RecipeName;
            labelCookingTime.Text = $"Cooking Time: {recipe.CookingTime} mins";
            labelIngredients.Text = $"Ingredients: {recipe.Ingredients}";
            labelServings.Text = $"Servings: {recipe.Servings}";
            
            // Add more controls as needed

            // Adjust text formatting as needed
            labelRecipeName.MaximumSize = new System.Drawing.Size(200, 0); // Adjust the maximum width
            labelCookingTime.MaximumSize = new System.Drawing.Size(200, 0); // Adjust the maximum width

            // Configure labelIngredients
            labelIngredients.MaximumSize = new System.Drawing.Size(200, 0); // Adjust the maximum width
            labelIngredients.AutoSize = true; // Enable auto size for ingredients
            labelIngredients.AutoEllipsis = false; // Disable auto ellipsis

            // Enable text wrapping if needed
            labelIngredients.TextAlign = ContentAlignment.TopLeft;

            byte[] imageBytes = recipe.RecipeImage; // Call a method to retrieve the byte array from the database
            if (imageBytes != null)
            {
                Image image = ByteArrayToImage(imageBytes);
                imgFood.Image = image;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
