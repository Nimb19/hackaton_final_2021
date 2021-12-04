using AccentureClient.Kernel;
using AccentureClient.Kernel.ImplementationModels;
using AccentureClient.Kernel.LogicModels;
using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccentureClient
{
    public partial class ClientForm : Form
    {
        //private readonly string _login;
        private readonly string _serverAddress;
        private readonly ConfigurationOfBase _configurationOfBase;

        public ClientForm(string login, string server, bool fullSize = true)
        {
            //_login = login;
            _serverAddress = server;

            if (fullSize)
                this.WindowState = FormWindowState.Maximized;

            _configurationOfBase = ConfigurationOfBase.TemplateInstance;
            _configurationOfBase.ServerAddress = _serverAddress;

            InitializeComponent();

            StartViewing(CancellationToken.None
                , @"C:\Users\asus\source\repos\hackaton_final_2021\AccentureClient\bin\Debug\data\outputwagon.gif"
                , @"C:\Users\asus\source\repos\hackaton_final_2021\AccentureClient\bin\Debug\screenshots\fullinputtank.png"); // TODO: CancelationToken
        }

        private async void StartViewing(CancellationToken cancellationToken, string urlToCamera, string urlToscreen)
        {
            await Task.Run(() =>
            {
                cancellationToken.ThrowIfCancellationRequested();

                //var camera = new Bitmap(urlToCamera);

                //if (camera.Width < camera.Height)
                //    camera.RotateFlip(RotateFlipType.Rotate90FlipX);

                //Animate(pictureBoxCamera, true);
                //pictureBoxCamera.Image = camera;

                //ImageAnimator.Animate(camera, new EventHandler(this.OnFrameChanged));
                
                Task.Delay(5000).Wait();
            });

            ProcessThePhoto(urlToscreen);

            void Animate(PictureBox box, bool enable)
            {
                var anim = box.GetType().GetMethod("Animate",
                    BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(bool) }, null);
                anim.Invoke(box, new object[] { enable });
            }

            //var currentThread = Thread.CurrentThread;
            //var task = Task.Run(() => StartWork(currentThread, urlToCamera, urlToscreen));

            //void StartWork(Thread mainThread, string urll, string urlToscreen)
            //{
            //    while (true)
            //    {

            //    }
            //}
        }

        private void ОбработатьВыбранноеИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ProcessThePhoto(openFileDialog.FileName);
        }

        private void ProcessThePhoto(string fileName)
        {
            var bitmap = new Bitmap(fileName);
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
            pictureBoxPrephoto.Image = bitmap;
            UpdateTime();

            if (resultInfo == ResultStatus.BadQuality)
                MessageBox.Show("Плохая оценка качества на зоне погрузки №1, камере №1." +
                    "\r\n\r\nСкриншот с шаблоном отчёта успешно сохранены", "Внимание"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void UpdateTime()
            => labelLastTimeUpdInfo.Text = DateTime.Now.ToString("HH:mm:ss");
    }
}
