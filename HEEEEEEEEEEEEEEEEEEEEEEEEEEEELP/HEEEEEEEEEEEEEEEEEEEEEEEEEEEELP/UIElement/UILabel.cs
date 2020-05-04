using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HEEEEEEEEEEEEEEEEEEEEEEEEEEEELP.UIElement
{

    public class UILabel : Label
    {
        public UILabel(string text)
        {
            Text = text;
            FontSize = 18;
            FontAttributes = FontAttributes.Bold;
            TextColor = Color.Green;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }
    }
}

