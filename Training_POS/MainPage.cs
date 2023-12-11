using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using MaterialSkin;
using MaterialSkin.Controls;
using BusinessLogic;

namespace Training_POS
{
    public partial class MainPage : MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
            PopulateRecipeCards();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void PopulateRecipeCards()
        {
            AdminBL admin = new AdminBL();
            // Assuming you have a method to fetch recipe data from the database
            List<Recipe> recipes = admin.FetchRecipesFromDatabase();

            foreach (Recipe recipe in recipes)
            {
                RecipeCardControl recipeCard = new RecipeCardControl(recipe);
                recipeCard.Margin = new Padding(10);
                flowLayoutPanelRecipes.Controls.Add(recipeCard);
            }
        }                                                                                                                                                                                                       
    }
}
