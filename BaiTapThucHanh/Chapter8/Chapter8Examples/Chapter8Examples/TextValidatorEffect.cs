using Xamarin.Forms;

namespace Chapter8Examples
{
    public class TextValidatorEffect : RoutingEffect
    {
        public int MaxLength { get; set; } = 5;
        public TextValidatorEffect() : base("Chapter8Examples.TextValidatorEffect") { }
    }
}