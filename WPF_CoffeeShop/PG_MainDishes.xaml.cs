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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
           

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    foreach(Button btn_tst in ((window as MainWindow).SP_plates).Children)
                    {
                        if((btn_tst as Button).Name == "btn_cheeseburger")
                        {
                            I_cheese++;
                            String count = I_cheese.ToString();
                            String str;
                            str = "CheeseBurger  $7.5  : "+ " " + count;
                            Char[] TrimChar = { '(', ')', ',', '.', '.'};
                            String Name = str.Trim(TrimChar);
                            String Name2 = Name.TrimEnd(TrimChar);
                            btn_tst.Content = Name2;

                        }

                    }

                    i++;
                    if(i < 2)
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
                        btn.Name = "btn_cheeseburger";
                        btn.Height = 30;
                        btn.Content = "CheeseBurger  $7.5  : " + " " + "1";
                        btn.FontSize = 15;
                        btn.FontWeight = FontWeights.Bold;
                        btn.Foreground = Brushes.DarkOrange;
                        btn.BorderBrush = Brushes.Orange;
                        btn.BorderThickness = new Thickness(1);
                        btn.Margin = new Thickness(12, 3, 12, 0);
                        btn.Background = Brushes.White;
                        btn.Style = style;
                        btn.Click += CB_del_Click;

                        (window as MainWindow).SP_plates.Children.Add(btn);
                    }
                    
                }
            }
                       
        }

        void Del_Loop(object sender)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    try
                    {
                        foreach (Button btn_tst in ((window as MainWindow).SP_plates).Children)
                        {

                            if (btn_tst == null)
                            {
                                String str = "1";
                            }

                            if ((btn_tst as Button).Name == "btn_cheeseburger")
                                                            
                                if (I_cheese == 1)
                                {
                                    (window as MainWindow).SP_plates.Children.Remove((Button)sender);
                                    continue;

                                }

                                if (I_cheese != 0)
                                {
                                    I_cheese = I_cheese - 1;
                                    String count = I_cheese.ToString();
                                    String str;
                                    str = "CheeseBurger  $7.5  : " + " " + count;
                                    Char[] TrimChar = { '(', ')', ',', '.', '.' };
                                    String Name = str.Trim(TrimChar);
                                    String Name2 = Name.TrimEnd(TrimChar);
                                    btn_tst.Content = Name2;
                                }

                            }

                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("test");
                        throw new InvalidOperationException();
                    }

                }
            }
        }
    

        private void CB_del_Click(object sender, RoutedEventArgs e)
        {
            Del_Loop(sender);
        }

    }
}
