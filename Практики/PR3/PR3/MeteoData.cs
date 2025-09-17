using System.ComponentModel;
using System.Runtime.Serialization;

namespace PR3;

public class MeteoData
{
    [DisplayName("Высота, м")]
    public double Height { get; set; }

    [DisplayName("Давление, Па")]
    public double Pressure { get; set; }
}
