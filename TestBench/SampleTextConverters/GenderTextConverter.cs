
namespace TestBench.SampleTextConverters
{
    using System;
    using Guiuiui.Tools.TextConverter;
    using TestBench.SampleModels;

    public class GenderTextConverter : ITextConverter<Gender>
    {
        public string GetText(Gender value)
        {
            switch(value)
            {
                case Gender.Male:
                    return Text.GenderMale;
                case Gender.Female:
                    return Text.GenderFemale;
                default:
                    return Text.GenderUndefined;
            }
        }
    }
}
