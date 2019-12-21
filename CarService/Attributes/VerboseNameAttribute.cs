using System;

namespace CarService.Attributes
{
    public class VerboseNameAttribute : Attribute
    {
        public string Text { get; set; }

        public VerboseNameAttribute(string text)
        {
            Text = text;
        }
    }
}
