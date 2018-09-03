using ITSpecialProject.Commons.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace ITSpecialProject.Components.Classes
{
    public class Gradient<TControl> where TControl : Control
    {
        public Gradient(TControl sender, Color colorA, Color colorB, Color colorC, ColorCombination colorCombination, int gradientAngle = 45)
        {
            Sender = sender;
            ColorA = colorA;
            ColorB = colorB;
            ColorC = colorC;
            ColorCombination = colorCombination;
            GradientAngle = gradientAngle;
        }

        public TControl Sender { get; }
        public Color ColorA { get; }
        public Color ColorB { get; }
        public Color ColorC { get; }
        public ColorCombination ColorCombination { get; }
        public int GradientAngle { get; }
    }
}