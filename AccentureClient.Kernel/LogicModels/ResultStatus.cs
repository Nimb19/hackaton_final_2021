namespace AccentureClient.Kernel.LogicModels
{
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
