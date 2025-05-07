using Newtonsoft.Json;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Заполняем ComboBox типами кораблей
        comboBoxType.Items.AddRange(new[] { "Пассажирский", "Грузовой" });
        comboBoxType.SelectedIndex = 0;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var ship = new Ship(
            textBoxName.Text,
            comboBoxType.SelectedItem.ToString(),
            (double)numericUpDownDisplacement.Value,
            (double)numericUpDownMaxSpeed.Value,
            checkBoxIsMilitary.Checked);

        string json = JsonSerializer.Serialize(ship);

        var sfd = new SaveFileDialog
        {
            DefaultExt = ".json",
            Filter = "JSON | *.json"
        };

        if (sfd.ShowDialog() != DialogResult.OK)
            return;

        File.WriteAllText(sfd.FileName, json);
        MessageBox.Show($"Данные сохранены в {sfd.FileName}");
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        var ofd = new OpenFileDialog
        {
            DefaultExt = ".json",
            Filter = "JSON | *.json"
        };

        if (ofd.ShowDialog() != DialogResult.OK)
            return;

        if (!File.Exists(ofd.FileName))
            MessageBox.Show($"Файл {ofd.FileName} не найден!");

        string json = File.ReadAllText(ofd.FileName);
        Ship ship = JsonConvert.DeserializeObject<Ship>(json);

        textBoxName.Text = ship.Name;
        comboBoxType.SelectedItem = ship.Type;
        numericUpDownDisplacement.Value = (decimal)ship.DisplacementTons;
        numericUpDownMaxSpeed.Value = (decimal)ship.MaxSpeedKnots;
        checkBoxIsMilitary.Checked = ship.IsMilitary;
    }
}
