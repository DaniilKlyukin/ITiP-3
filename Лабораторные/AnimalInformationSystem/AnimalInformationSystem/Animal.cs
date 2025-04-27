using System.ComponentModel.DataAnnotations;

namespace AnimalInformationSystem;

public class Animal
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Имя обязательно")]
    [StringLength(100, ErrorMessage = "Имя не должно превышать 100 символов")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Вид обязателен")]
    [StringLength(100, ErrorMessage = "Вид не должен превышать 100 символов")]
    public string Species { get; set; } = string.Empty;

    [Required(ErrorMessage = "Возраст обязателен")]
    [Range(0, 100, ErrorMessage = "Возраст должен быть между 0 и 100")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Вес обязателен")]
    [Range(0.1, 1000, ErrorMessage = "Вес должен быть между 0.1 и 1000")]
    public double Weight { get; set; }

    [StringLength(500, ErrorMessage = "Описание не должно превышать 500 символов")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Дата поступления обязательна")]
    public DateTime AdmissionDate { get; set; } = DateTime.Now;
}