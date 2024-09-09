using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AlphaMerger
{
    public partial class Main : Form
    {
        private Bitmap? colorTexture ;
        private Bitmap? alphaTexture ;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                colorTexture = new Bitmap(ofd.FileName);
                PicboxTexture.Image = colorTexture;
            }
        }

        private void AlphaBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                alphaTexture = new Bitmap(ofd.FileName);
                PicboxAlpha.Image = alphaTexture;
            }

        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            {
                if (colorTexture == null || alphaTexture == null)
                {
                    MessageBox.Show("Please load both color and alpha textures.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (colorTexture.Width != alphaTexture.Width || colorTexture.Height != alphaTexture.Height)
                {
                    MessageBox.Show("Both textures must have the same dimensions (Size).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Bitmap mergedTexture = MergeTextures(colorTexture, alphaTexture);
                // Display the result
                PicBoxResult.Image = mergedTexture;

                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Files|*.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mergedTexture.Save(saveFileDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("Merged texture saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
             Bitmap MergeTextures(Bitmap colorTexture, Bitmap alphaTexture)
            {
                Bitmap mergedTexture = new Bitmap(colorTexture.Width, colorTexture.Height, PixelFormat.Format32bppArgb);

                for (int y = 0; y < colorTexture.Height; y++)
                {
                    for (int x = 0; x < colorTexture.Width; x++)
                    {
                        Color colorPixel = colorTexture.GetPixel(x, y);
                        Color alphaPixel = alphaTexture.GetPixel(x, y);
                        int alphaValue = alphaPixel.R; 

                        Color finalPixel = Color.FromArgb(alphaValue, colorPixel.R, colorPixel.G, colorPixel.B);
                        mergedTexture.SetPixel(x, y, finalPixel);
                    }
                }

                return mergedTexture;
            }
        }
    } }
