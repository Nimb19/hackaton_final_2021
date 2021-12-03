using AccentureClient.Kernel;
using AccentureClient.Kernel.ImplementationModels;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ImageColorAnalizer.UI
{
    public partial class ClientForm : Form
    {
        private readonly string _login;
        private readonly string _serverAddress;

        public ClientForm(string login, string server, bool fullSize = true)
        {
            _login = login;
            _serverAddress = server;

            if (fullSize)
                this.WindowState = FormWindowState.Maximized;
            
            InitializeComponent();
        }

        private void ОбработатьВыбранноеИзображениеToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var bitmap = new Bitmap(openFileDialog.FileName);
            var material = BuckwheatMaterial.Instance;

            var errorRate = numericUpDownErrorRate.Value;
            var resultInfo = ProcessThePhoto(bitmap, material, (double)errorRate
                , out var percent, out var notSuccessColor, out var successColor);

            labelResultInfo.Text = resultInfo.ToFriendlyString();
            labelPercentQualityMaterial.Text = percent.ToString("0.02");
            labelMaterialType.Text = material.Name;

            if (bitmap.Width < bitmap.Height)
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
            
            pictureBoxLastPhoto.Image = bitmap;
        }

        private static ResultStatus ProcessThePhoto(Bitmap bitmap, IRawMaterial material, double errorRate
            , out double percent, out int notSuccessColor, out int successColor)
        {
            var colors = GeneratorImageColorPalette.GetImageColor(bitmap, material);
            percent = Analyzer.GetPercentOfNormalGrains(colors, material
                , out notSuccessColor, out successColor);
            return GetResultStatus(errorRate, percent);

        }

        private static ResultStatus GetResultStatus(double errorRate, double percent)
        {
            var factError = 100 - percent;
            if (factError > errorRate)
            {
                if (factError - errorRate > 5)
                    return ResultStatus.BadQuality;
                else
                    return ResultStatus.ControversialMoment;
            }
            else
                return ResultStatus.GoodQuality;
        }

        private void pictureBoxLastPhoto_Paint(object sender, PaintEventArgs e)
        {
            var senderPictureBox = sender as PictureBox;
            if (senderPictureBox == null || senderPictureBox.Image == null)
                return;

            pictureBoxPrephoto.Image = senderPictureBox.Image;
            if (pictureBoxPrephoto.Image.Width != senderPictureBox.Image.Width)
                pictureBoxPrephoto.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

            UpdateTime();
        }

        private void UpdateTime()
            => labelLastTimeUpdInfo.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    public enum ResultStatus
    {
        GoodQuality,
        ControversialMoment,
        BadQuality,
        NoInfo,
    }

    public static class ResultStatusExtensions
    {
        public static string ToFriendlyString(this ResultStatus me)
        {
            switch (me)
            {
                case ResultStatus.GoodQuality:
                    return "Хорошее качество";
                case ResultStatus.ControversialMoment:
                    return "Спорный момент";
                case ResultStatus.BadQuality:
                    return "Плохое качество";
                case ResultStatus.NoInfo:
                default:
                    return "Нет данных";
            }
        }
    }
}
