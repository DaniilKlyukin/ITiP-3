namespace AnimalInformationSystem;

public partial class MainForm : Form
{
    private readonly AnimalContext _db = new();

    public MainForm()
    {
        InitializeComponent();
        _db.Database.EnsureCreated();
        LoadAnimals();
    }

    private void LoadAnimals(string filter = "")
    {
        var query = _db.Animals.AsQueryable();

        if (!string.IsNullOrEmpty(filter))
        {
            query = query.Where(a => a.Name.Contains(filter) ||
                                 a.Species.Contains(filter));
        }

        dgvAnimals.DataSource = query.ToList();
        dgvAnimals.Columns["Id"].Visible = false;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var form = new EditAnimalForm();

        if (form.ShowDialog() == DialogResult.OK)
        {
            _db.Animals.Add(form.Animal);
            _db.SaveChanges();
            LoadAnimals();
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvAnimals.SelectedRows.Count == 0) return;

        var id = (int)dgvAnimals.SelectedRows[0].Cells["Id"].Value;
        var animal = _db.Animals.Find(id);

        if (animal == null) return;

        using var form = new EditAnimalForm(animal);
        if (form.ShowDialog() == DialogResult.OK)
        {
            _db.SaveChanges();
            LoadAnimals();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvAnimals.SelectedRows.Count == 0) return;

        var id = (int)dgvAnimals.SelectedRows[0].Cells["Id"].Value;
        var animal = _db.Animals.Find(id);

        if (animal == null) return;

        if (MessageBox.Show("Удалить запись?", "Подтверждение",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            _db.Animals.Remove(animal);
            _db.SaveChanges();
            LoadAnimals();
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadAnimals(txtSearch.Text);
    }
}