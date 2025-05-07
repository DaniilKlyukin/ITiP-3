using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.ColorPatterns;

namespace WinFormsApp2
{

    public class Properties
    {
        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Рисование")]
        [Description("")]
        [DisplayName("Максимальный радиус")]
        [DataMember(Name = "Максимальный радиус")]
        public double MaxRadius { get; set; } = 2;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Рисование")]
        [Description("")]
        [DisplayName("Максимальное количество итераций")]
        [DataMember(Name = "Максимальное количество итераций")]
        public int MaxIterations { get; set; } = 500;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Рисование")]
        [Description("")]
        [DisplayName("Цвета")]
        [DataMember(Name = "Цвета")]
        public List<Color> Colors { get; set; } = new();

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Рисование")]
        [Description("")]
        [DisplayName("Способ задания цвета")]
        [DataMember(Name = "Способ задания цвета")]
        public ColorPatternType ColorPatternType { get; set; } = ColorPatternType.GrayScale;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Область")]
        [Description("")]
        [DisplayName("Левая граница")]
        [DataMember(Name = "Левая граница")]
        public double Left { get; set; } = -2;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Область")]
        [Description("")]
        [DisplayName("Правая граница")]
        [DataMember(Name = "Правая граница")]
        public double Right { get; set; } = 2;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Область")]
        [Description("")]
        [DisplayName("Нижняя граница")]
        [DataMember(Name = "Нижняя граница")]
        public double Bottom { get; set; } = -2;

        [ReadOnly(false)]
        [Browsable(true)]
        [Category("Область")]
        [Description("")]
        [DisplayName("Верхняя граница")]
        [DataMember(Name = "Верхняя граница")]
        public double Top { get; set; } = 2;

        [ReadOnly(true)]
        [Browsable(true)]
        [Category("Размер области")]
        [Description("")]
        [DisplayName("Ширина области")]
        [DataMember(Name = "Ширина области")]
        public double Width => Right - Left;

        [ReadOnly(true)]
        [Browsable(true)]
        [Category("Размер области")]
        [Description("")]
        [DisplayName("Высота области")]
        [DataMember(Name = "Высота области")]
        public double Height => Top - Bottom;
    }
}
