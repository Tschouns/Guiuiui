//-----------------------------------------------------------------------
// <copyright file="BlowMeInTheShoes.cs" company="Jonas Aklin">
//     Copyright (c) Jonas Aklin. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace TestBench.SampleTextConverters
{
    using Guiuiui.Tools.TextConverter;
    using TestBench.SampleModels;

    public class AddressTextConverter : ITextConverter<Address>
    {
        public string GetText(Address value)
        {
            if (value == null)
            {
                return "-";
            }

            return value.Street + ", " + value.PostalCode + " " + value.City;
        }
    }
}
