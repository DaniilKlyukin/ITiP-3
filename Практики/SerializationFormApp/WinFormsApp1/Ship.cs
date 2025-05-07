using System.Runtime.Serialization;

namespace WinFormsApp1;

public class Ship
{
    public Ship(
        string name, 
        string type,
        double displacementTons,
        double maxSpeedKnots,
        bool isMilitary)
    {
        Name = name;
        Type = type;
        DisplacementTons = displacementTons;
        MaxSpeedKnots = maxSpeedKnots;
        IsMilitary = isMilitary;
    }

    [DataMember(Name = "Название")]
    public string Name { get; set; }

    [DataMember(Name = "Тип")]
    public string Type { get; set; } // "Пассажирский" или "Грузовой"

    [DataMember(Name = "Водоизмещение, тонн")]
    public double DisplacementTons { get; set; }

    [DataMember(Name = "Макс. скорость, узлов")]
    public double MaxSpeedKnots { get; set; }

    [DataMember(Name = "Военный?")]
    public bool IsMilitary { get; set; }
}


