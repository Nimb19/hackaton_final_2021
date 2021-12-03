using ImageColorAnalizer.UI.Adapter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ImageColorAnalizer.UI
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            SetDeserializedData();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text.Trim();
            var server = addressBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(login)
                && !string.IsNullOrWhiteSpace(server))
                SerializeEntryData();

            this.Hide();
            var clientForm = new ClientForm(login, server);
            clientForm.ShowDialog();

            Environment.Exit(Environment.ExitCode);
        }

        private void SetDeserializedData()
        {
            List<EntryData> entryDataCollection = GetSerializedData();
            if (entryDataCollection.Count == 0)
                return;

            loginBox.Items.AddRange(entryDataCollection.GroupBy(x => x.Name).Select(x => x.Key).ToArray());
            addressBox.Items.AddRange(entryDataCollection.GroupBy(x => x.ServerAddress).Select(x => x.Key).ToArray());
        }

        private static List<EntryData> GetSerializedData()
        {
            var jsonData = FilesAdapter.ReadFile(EntryData.DefaultFileName);
            if (string.IsNullOrWhiteSpace(jsonData))
                return new List<EntryData>();

            return JsonConvert.DeserializeObject<List<EntryData>>(jsonData);
        }

        private void SerializeEntryData()
        {
            List<EntryData> entryDataCollection = GetSerializedData();
            entryDataCollection.Add(new EntryData()
            {
                Name = loginBox.Text.Trim(),
                ServerAddress = addressBox.Text.Trim(),
            });

            var jsonText = JsonConvert.SerializeObject(entryDataCollection, Formatting.Indented);
            FilesAdapter.WriteToFile(EntryData.DefaultFileName, jsonText);
        }
    }
}
