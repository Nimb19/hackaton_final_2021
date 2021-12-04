using AccentureClient.Kernel.ImplementationModels;
using AccentureClient.Kernel.LogicModels;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace AccentureClient.Kernel
{
    public class ConfigurationOfBase
    {
        public string ServerAddress;
        public List<LoadingZone> LoadingZones = new List<LoadingZone>();

        public static ConfigurationOfBase TemplateInstance
            => CreateTemplateInstance(null);

        public static ConfigurationOfBase CreateTemplateInstance(string serverAddress)
        {
            var config = new ConfigurationOfBase();

            if (!string.IsNullOrWhiteSpace(serverAddress))
                config.ServerAddress = serverAddress;

            config.LoadingZones.AddRange(new[]
            {
                new LoadingZone()
                {
                    Cameras = new List<Camera>()
                    {
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagonNumer
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputTank
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                    }
                },
                new LoadingZone()
                {
                    Cameras = new List<Camera>()
                    {
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagonNumer
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputTank
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                    }
                },
                new LoadingZone()
                {
                    Cameras = new List<Camera>()
                    {
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagonNumer
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputTank
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                    }
                },
                new LoadingZone()
                {
                    Cameras = new List<Camera>()
                    {
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagonNumer
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputTank
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                    }
                },
                new LoadingZone()
                {
                    Cameras = new List<Camera>()
                    {
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagonNumer
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputTank
                        },
                        new Camera()
                        {
                            CameraType = CameraType.InputWagon
                        },
                        new Camera()
                        {
                            CameraType = CameraType.OutputWagon
                        },
                    }
                },
            });

            return config;
        }
    }

    public class LoadingZone
    {
        private static int _id = 1;

        public int Id = _id++;
        public List<Camera> Cameras;

        public override string ToString()
            => $"Зона приёма №{Id}";
    }

    public class Camera
    {
        public int AutoProcessingDelay = 5;
        public double MaxErrorRate = 10;
        public List<ImageInfo> ImageInfos = new List<ImageInfo>();
        public CameraType CameraType;

        public override string ToString()
            => $"{(int)CameraType}. {CameraType.ToFriendlyString()}";
    }

    public class ImageInfo
    {
        public Image Image;
        public DateTime DateTime;
        public double QulaityPercent;
        public IRawMaterial Material;
        public ResultStatus ResultStatus;
    }
}
