using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using HEEEEEEEEEEEEEEEEEEEEEEEEEEEELP.UIElement;
using Xamarin.Essentials;

namespace HEEEEEEEEEEEEEEEEEEEEEEEEEEEELP
{
    public class MainPage : TabbedPage
    {

        Button button = new Button();
        //IconLabel text = new IconLabel();
        List<PriceNode> list = new List<PriceNode>();
        //public static decimal sum = 0;

        UILabel text1 = new UILabel("Total: ");
        //UIButton buttonNext = new UIButton("Click to show all info");
        public string fiscalNumber="", fiscalDocument = "", fiscalSign = "", n = "", data = "", price = "";
        public DateTime data1;
        List<PriceCheck> list1 = new List<PriceCheck>();
        //public PriceCheck check;
        //protected internal ObservableCollection<PriceCheck> Checks { get; set; }
        Image image = new Image { Source = "Copy_40923.png" };

        public MainPage()
        { 
            button.Clicked += Scan;
            this.ItemsSource = new PriceCheck(price.ToString(), fiscalNumber, fiscalDocument, fiscalSign, n, data1.ToString());
           
            TapGestureRecognizer imageTap = new TapGestureRecognizer();
            imageTap.Tapped += Tol;

            image.GestureRecognizers.Add(imageTap);

            Update();
        }


        void Update()
        {
            StackLayout sl = new StackLayout();
           
            sl.Children.Add(button);

            sl.Children.Add(image);

            foreach (var n in list)
                sl.Children.Add(n);

            //sl.Children.Add(button1);
            sl.Children.Add(text1);
            //sl.Children.Add(buttonNext);

            //sl.Children.Add(text);
            //buttonNext.IsVisible = true;
            //button1.IsVisible = true;
            text1.IsVisible = true;



            //ScrollView scrollView = new ScrollView();
            //scrollView.Content = sl;
            //this.Content = scrollView;
            //Content = scrollView;
        }
        //private async void ToCommonPage(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Scan());
        //}
        double sum = 0;
        private async void Tol(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(fiscalDocument);
        }

        async void Scan(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQrScanningService>();
            var result = await scanner.ScanAsync();
            int id = list.Count + 1;
            price = result.Split('=')[2].Split('&')[0];
            list.Add(new PriceNode(id, price));
            string[] result1 = result.Split('&');
            fiscalNumber = result1[2].Remove(0, 3);
            fiscalDocument = result1[3].Remove(0, 2);
            fiscalSign = result1[4].Remove(0, 3);
            n = result1[5].Remove(0, 2);


            string[] test1 = result1[0].Remove(0, 2).Split('T');
            string date = result1[0].Remove(0, 2);
            data = date.Substring(0, 4) + "-" + date.Substring(4, 2) + "-" + date.Substring(7, 2) + test1[1].Substring(0, 2) + ":" + test1[1].Substring(2, 2) + ":" + test1[1].Substring(2, 2);
            data1 = DateTime.Parse(data);
            //list1.Add(new PriceCheck(price.ToString(), fiscalNumber, fiscalDocument, fiscalSign, n, data1.ToString()));


            string str = price.Replace('.', ',');
            sum += double.Parse(str);

            text1.Text = sum.ToString();

            Update();
        }
    }
}