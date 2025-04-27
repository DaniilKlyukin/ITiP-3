namespace AnimalInformationSystem;

public partial class EditAnimalForm : Form
{
    public Animal Animal { get; }

    public EditAnimalForm(Animal? animal = null)
    {
        InitializeComponent();
        Animal = animal ?? new Animal();
        SetupDataBindings();
    }

    private void SetupDataBindings()
    {
        txtName.DataBindings.Add("Text", Animal, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        txtSpecies.DataBindings.Add("Text", Animal, "Species", false, DataSourceUpdateMode.OnPropertyChanged);
        numAge.DataBindings.Add("Value", Animal, "Age", false, DataSourceUpdateMode.OnPropertyChanged);
        numWeight.DataBindings.Add("Value", Animal, "Weight", false, DataSourceUpdateMode.OnPropertyChanged);
        txtDescription.DataBindings.Add("Text", Animal, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
        dtpAdmissionDate.DataBindings.Add("Value", Animal, "AdmissionDate", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (ValidateChildren())
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            errorProvider.SetError(txtName, "Имя обязательно");
            e.Cancel = true;
        }
        else
        {
            errorProvider.SetError(txtName, "");
        }
    }

    private void txtSpecies_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSpecies.Text))
        {
            errorProvider.SetError(txtSpecies, "Вид обязателен");
            e.Cancel = true;
        }
        else
        {
            errorProvider.SetError(txtSpecies, "");
        }
    }
}