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
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Drawing.Imaging;
using BusinessObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BusinessLogic;

namespace Training_POS
{
    public partial class AddRecipeForm : MaterialForm
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Create a Bitmap from the selected image file
                    Bitmap originalImage = new Bitmap(imagePath);

                    if (originalImage.PropertyIdList.Contains(0x0112))
                    {
                        var orientation = (int)originalImage.GetPropertyItem(0x0112).Value[0];
                        if (orientation == 2 || orientation == 4 || orientation == 5 || orientation == 7)
                        {
                            originalImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        else if (orientation == 3 || orientation == 6 || orientation == 8)
                        {
                            originalImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        }
                    }

                    // Create a new Bitmap with a scaled size to fit the PictureBox
                    int maxWidth = pictureBoxRecipe.Width;
                    int maxHeight = pictureBoxRecipe.Height;
                    double widthRatio = (double)maxWidth / originalImage.Width;
                    double heightRatio = (double)maxHeight / originalImage.Height;
                    double ratio = Math.Min(widthRatio, heightRatio);
                    int newWidth = (int)(originalImage.Width * ratio);
                    int newHeight = (int)(originalImage.Height * ratio);
                    Bitmap scaledImage = new Bitmap(originalImage, newWidth, newHeight);

                    // Set the PictureBox Image and adjust the SizeMode property
                    pictureBoxRecipe.Image = scaledImage;
                    pictureBoxRecipe.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Determine image format (you can change this to the desired format)
                ImageFormat format = ImageFormat.Jpeg;

                // Save the image to the MemoryStream with the specified format
                image.Save(ms, format);

                return ms.ToArray();
            }
        }


        private void btnSubmitRecipe_Click(object sender, EventArgs e)
        {
            string name = this.txtRecipeName.Text;
            string ingredients = this.txtIngredients.Text;
            int cookingTime = Convert.ToInt32(this.inputTimer.Value);
            int Serving = Convert.ToInt32(this.inputServings.Value);

            try
            {

                int rowsAffected;
                byte[] imageBytes = ImageToByteArray(pictureBoxRecipe.Image);
                Recipe recipe = new Recipe(name, ingredients,cookingTime,Serving,imageBytes);
                AdminBL adminBL = new AdminBL();

                rowsAffected = adminBL.InsertRecipe(recipe);

                if (rowsAffected > 0) //Checks if any rows were changed or added.
                {
                    MessageBox.Show("Customer added successfully.");

                    

                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
