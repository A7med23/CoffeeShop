using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media.Effects;

namespace WPF_CoffeeShop
{
    /// <summary>
    /// Interaction logic for PG_MainDishes.xaml
    /// </summary>
    public partial class PG_MainDishes : Page
    {
        public PG_MainDishes()
        {
            InitializeComponent();
        }

        // Declare variable 
        bool allow = false;
        double y;
        double max;
        Color clr_orange = Color.FromRgb(255, 165, 0);
        public static int i;

        #region Order Duplicate Numbers
        int I_cheese = 1;
        #endregion

        //Add & Delete Variables
        String btn_name;
        String btn_content;
        String btn_ID;
        String price;

        // Form load event
        private void form_loaded(object sender, RoutedEventArgs e)
        {
            max = -255;
        }

        //dragging Grid
        #region drag
        // Mouse down event for panel
        private void panel_mouseDown(object sender, MouseButtonEventArgs e)
        {
            allow = true;
            y = Mouse.GetPosition(null).Y - slider.Margin.Top;
        }


        // Mouse leave event for panel
        private void panel_mouseLeave(object sender, MouseEventArgs e)
        {
            allow = false;
        }

        // Panel mouse move event
        private void panel_mouseMove(object sender, MouseEventArgs e)
        {
            if (allow == true)
            {
                slider.Margin = new Thickness(slider.Margin.Left, Mouse.GetPosition(null).Y - y, 0, 0);
                if (slider.Margin.Top > 0)
                {
                    slider.Margin = new Thickness(slider.Margin.Left, 0, 0, 0);
                }
                else if (slider.Margin.Top < max)
                {
                    slider.Margin = new Thickness(0, -255, 0, 0);
                }
            }
        }

        private void panel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            allow = false;
        }
    #endregion

        void Add()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    var mainWindow = window as MainWindow;

                    foreach (Button btn_tst in (mainWindow.SP_plates).Children)
                    {
                        if ((btn_tst as Button).Name == btn_name)
                        {
                            //Increasing the Quantity
                            I_cheese++;
                            String count = I_cheese.ToString();
                            String str;
                            //Button Content
                            str = btn_ID + " :  " + count;
                            //Button Status
                            btn_tst.Content = str;
                            btn_tst.Visibility = Visibility.Visible;
                            btn_tst.IsEnabled = true;

                        }

                    }

                    i++;
                    if (i < 2)
                    {

                        //Creating the Button
                        Setter setter = new Setter();
                        setter.Property = Button.BackgroundProperty;
                        setter.Value = Brushes.White;

                        Trigger trigger = new Trigger();
                        trigger.Property = UIElement.IsMouseOverProperty;
                        trigger.Value = true;
                        trigger.Setters.Add(setter);

                        Style style = new Style();
                        style.TargetType = typeof(Button);
                        style.Triggers.Clear();
                        style.Triggers.Add(trigger);

                        Button btn = new Button();
                        btn.Name = btn_name;
                        btn.Height = 30;
                        btn.Content = btn_content;
                        btn.FontSize = 15;
                        btn.FontWeight = FontWeights.Bold;
                        btn.Foreground = Brushes.DarkOrange;
                        btn.BorderBrush = Brushes.Orange;
                        btn.BorderThickness = new Thickness(1);
                        btn.Margin = new Thickness(12, 3, 12, 0);
                        btn.Background = Brushes.White;
                        btn.Style = style;
                        btn.Click += CB_del_Click;

                        mainWindow.SP_plates.Children.Add(btn);
                    }

                }
            }
        }

        void Remove()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    var mainWindow = window as MainWindow;

                    foreach (Button btn_tst in (mainWindow.SP_plates).Children)
                    {

                        if ((btn_tst as Button).Name == btn_name)
                        {
                            if (I_cheese == 1)
                            {
                                //Deactivate Button
                                I_cheese = 0;
                                btn_tst.Visibility = Visibility.Collapsed;
                                btn_tst.IsEnabled = false;
                            }

                            if (I_cheese != 0)
                            {
                                //Decrease Quanitity
                                I_cheese = I_cheese - 1;
                                String count = I_cheese.ToString();
                                String str;
                                str = btn_ID + " :  " + count;
                                btn_tst.Content = str;
                            }
                        }

                    }

                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var parent = sender as Button;
            //Setting the Variables
            #region Declaring;

            if(parent.Name == "CheeseBurger")
            {
                price = "$7.5";
                btn_ID = "CheeseBurger" + "  " + price;
                btn_content = "CheeseBurger" + "  " + price + ":  1";
                btn_name = "btn_cheeseburger";
            }



            #endregion; 

            Add();
        }

        private void CB_del_Click(object sender, RoutedEventArgs e)
        {
            var parent = sender as Button;
            if (parent.Name == "CheeseBurger")
            {
                price = "$7.5";
                btn_ID = "CheeseBurger" + "  " + price;
                btn_content = "CheeseBurger" + "  " + price + ":  1";
                btn_name = "btn_cheeseburger";
            }
            Remove();           
        }

    }
}
