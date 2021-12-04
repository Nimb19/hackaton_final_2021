namespace AccentureClient
{
    public class EntryData
    {
        public const string DefaultFileName = "EntryData.json";

        public string Name { get; set; }
        public string ServerAddress { get; set; }

        public bool Compare(EntryData entryData)
        {
            if (Name == entryData.Name && ServerAddress == entryData.ServerAddress)
                return true;
            else
                return false;
        }
    }
}
