namespace AccentureClient.Kernel.LogicModels
{
    public enum CameraType
    {
        OutputWagon,
        OutputWagonNumer,
        InputTank,
        InputWagon,
        InputWagonNumer,
    }

    public static class CameraTypesExtensions
    {
        public static string ToFriendlyString(this CameraType me)
        {
            switch (me)
            {
                case CameraType.OutputWagon:
                    return "Содержимое разгрузочного вагона";
                case CameraType.OutputWagonNumer:
                    return "Номер разгрузочного вагона";
                case CameraType.InputTank:
                    return "Содержимое бункера";
                case CameraType.InputWagon:
                    return "Содержимое загрузочного вагона";
                case CameraType.InputWagonNumer:
                    return "Номер загрузочного вагона";
                default:
                    return "Нет данных";
            }
        }
    }
}
