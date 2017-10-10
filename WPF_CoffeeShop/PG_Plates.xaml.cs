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
using WPF_CoffeeShop.Items;
using System.Diagnostics;

namespace WPF_CoffeeShop
{
    /// <summary>
    /// Interaction logic for PG_MainDishes.xaml
    /// </summary>
    public partial class PG_Plates : Page
    {

        int ChickenF_I;
        int Steak_I;
        int Salmon_I;
        int Kebab_I ;
        int ChickenM_I;
        int FajitaS_I;
        int Shrimp_I ;
        int ChickenCS_I;
        int GreekS_I ;
        int TunaS_I;

        // Declare variable 
        bool allow = false;
        double y;
        double max;
        Color clr_orange = Color.FromRgb(255, 165, 0);
        public static int i;
        String Name_btn = "", ID_btn = "", Price_btn = "";
        //Setting the DataContext
        #region Setting The DataContext

        Plates DC_chickenfillet = new Plates()
        {
            ID = "btn_chickenfillet",
            Name = "Chicken Fillet",
            Price = "$15"
        };

        Plates DC_steak = new Plates()
        {
            ID = "btn_steak",
            Name = "Steak",
            Price = "$18"
        };

        Plates DC_salmonfillet = new Plates()
        {
            ID = "btn_salmonfillet",
            Name = "Salmon Fillet",
            Price = "$12"
        };

        Plates DC_kebab = new Plates()
        {
            ID = "btn_kebab",
            Name = "Kebab",
            Price = "$10.5"
        };

        Plates DC_chickenM = new Plates()
        {
            ID = "btn_chickenM",
            Name = "Chicken Marinara",
            Price = "$13"
        };

        Plates DC_fajitaS = new Plates()
        {
            ID = "btn_fajitaS",
            Name = "Fajita Sampler",
            Price = "$20"
        };

        Plates DC_shrimpsteak = new Plates()
        {
            ID = "btn_shrimpsteak",
            Name = "Steak & Shrimp",
            Price = "$19"
        };

        Plates DC_chickenCS = new Plates()
        {
            ID = "btn_chickenCS",
            Name = "Chicken Caeser Salad",
            Price = "$7.5"
        };

        Plates DC_greeksalad = new Plates()
        {
            ID = "btn_greeksalad",
            Name = "Greek Salad",
            Price = "$5"
        };

        Plates DC_tunasalad = new Plates()
        {
            ID = "btn_tunasalad",
            Name = "Tuna Salad",
            Price = "$6"
        };

        #endregion


        public PG_Plates()
        {
            InitializeComponent();                      
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Stack_1.Children.Clear();
            Stack_2.Children.Clear();
            Stack_3.Children.Clear(); 
            
            StartButtons();
        }

        void StartButtons()
        {
            for (int i = 0; i < 11; i++)
            {
                if(i == 1)
                {
                    Name_btn = DC_chickenfillet.Name;
                    ID_btn = DC_chickenfillet.ID;
                    Price_btn = DC_chickenfillet.Price;
                }

                if (i == 2)
                {
                    Name_btn = DC_steak.Name;
                    ID_btn = DC_steak.ID;
                    Price_btn = DC_steak.Price;
                }

                if (i == 3)
                {
                    Name_btn = DC_salmonfillet.Name;
                    ID_btn = DC_salmonfillet.ID;
                    Price_btn = DC_salmonfillet.Price;
                }

                if (i == 4)
                {
                    Name_btn = DC_kebab.Name;
                    ID_btn = DC_kebab.ID;
                    Price_btn = DC_kebab.Price;
                }

                if (i == 5)
                {
                    Name_btn = DC_chickenM.Name;
                    ID_btn = DC_chickenM.ID;
                    Price_btn = DC_chickenM.Price;
                }

                if (i == 6)
                {
                    Name_btn = DC_fajitaS.Name;
                    ID_btn = DC_fajitaS.ID;
                    Price_btn = DC_fajitaS.Price;
                }

                if (i == 7)
                {
                    Name_btn = DC_shrimpsteak.Name;
                    ID_btn = DC_shrimpsteak.ID;
                    Price_btn = DC_shrimpsteak.Price;
                }

                if (i == 8)
                {
                    Name_btn = DC_chickenCS.Name;
                    ID_btn = DC_chickenCS.ID;
                    Price_btn = DC_chickenCS.Price;
                }

                if (i == 9)
                {
                    Name_btn = DC_greeksalad.Name;
                    ID_btn = DC_greeksalad.ID;
                    Price_btn = DC_greeksalad.Price;
                }

                if (i == 10)
                {
                    Name_btn = DC_tunasalad.Name;
                    ID_btn = DC_tunasalad.ID;
                    Price_btn = DC_tunasalad.Price;
                }
                                           
                TextBlock txt_name = new TextBlock();
                txt_name.Foreground = Brushes.Orange;
                txt_name.Text = Name_btn;
                txt_name.FontSize = 14;
                txt_name.FontWeight = FontWeights.SemiBold;
                txt_name.HorizontalAlignment = HorizontalAlignment.Center;
                txt_name.VerticalAlignment = VerticalAlignment.Center;
                Grid.SetRow(txt_name, 0);

                TextBlock txt_price = new TextBlock();
                txt_price.Text = Price_btn;
                txt_price.Foreground = Brushes.Orange;                
                txt_price.FontSize = 14;
                txt_price.FontWeight = FontWeights.SemiBold;
                txt_price.HorizontalAlignment = HorizontalAlignment.Center;
                txt_price.VerticalAlignment = VerticalAlignment.Top;
                Grid.SetRow(txt_price, 1);

                RowDefinition row1 = new RowDefinition(), row2 = new RowDefinition();
                GridLength length = new GridLength(70);
                row1.Height = length;                
                row2.Height = length;

                Grid Bgrid = new Grid();
                Bgrid.Height = 140;
                Bgrid.Width = 106;
                Bgrid.RowDefinitions.Add(row1);
                Bgrid.RowDefinitions.Add(row2);
                Bgrid.Children.Add(txt_name);
                Bgrid.Children.Add(txt_price);

                Button button = new Button();
                button.Name = ID_btn;
                button.Content = Bgrid;
                button.Background = Brushes.WhiteSmoke;
                button.BorderBrush = Brushes.LightGray;
                button.BorderThickness = new Thickness(1);
                button.Margin = new Thickness(10);
                button.Height = 150;
                button.Click += Add_Click;
                
                if (i == 1 || i == 4 || i == 7|| i == 10)
                {
                    Stack_1.Children.Add(button);
                }

                if (i == 2 || i == 5 || i == 8 )
                {
                    Stack_2.Children.Add(button);
                }

                if (i == 3 || i == 6 || i == 9)
                {
                    Stack_3.Children.Add(button);
                }

            }
        }
        
        //Duplicate Numbers
        #region Order Duplicate Numbers
        int I_ChickenF = 1;
        int I_Steak = 1;
        int I_Salmon = 1;
        int I_Kebab = 1;
        int I_ChickenM = 1;
        int I_FajitaS = 1;
        int I_ShrimpSteak = 1;
        int I_ChickenCS = 1;
        int I_GreekS = 1;
        int I_TunaS = 1;
        #endregion

        //Add & Delete Variables
        String btn_name;
        String btn_content;
        String btn_ID;
        String price;

        // Form load event
        private void form_loaded(object sender, RoutedEventArgs e)
        {
            max = -270;
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
                    slider.Margin = new Thickness(0, -280, 0, 0);
                }
            }
        }

        private void panel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            allow = false;
        }
        #endregion

        //Adding and Removing Order Details
        #region Adding & removing Order Details

        void Btn_Add()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if(window.GetType() == typeof(MainWindow))
                {
                    var mainWindow = window as MainWindow;

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

        void Add()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    var mainWindow = window as MainWindow;

                    foreach (Button Orderbtn in (mainWindow.SP_plates).Children)
                    {
                        if(Orderbtn.Name == btn_name)
                        {
                            if (Orderbtn.Name == DC_chickenfillet.ID)
                            {
                                if (ChickenF_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_ChickenF++;
                                    String count = I_ChickenF.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }

                            }

                            if (Orderbtn.Name == DC_steak.ID)
                            {
                                if (Steak_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_Steak++;
                                    String count = I_Steak.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_salmonfillet.ID)
                            {
                                if (Salmon_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_Salmon++;
                                    String count = I_Salmon.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_kebab.ID)
                            {
                                if (Kebab_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_Kebab++;
                                    String count = I_Kebab.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_chickenM.ID)
                            {
                                if (ChickenM_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_ChickenM++;
                                    String count = I_ChickenM.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_fajitaS.ID)
                            {
                                if (FajitaS_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_FajitaS++;
                                    String count = I_FajitaS.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_shrimpsteak.ID)
                            {
                                if (Shrimp_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_ShrimpSteak++;
                                    String count = I_ShrimpSteak.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_chickenCS.ID)
                            {
                                if (ChickenCS_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_ChickenCS++;
                                    String count = I_ChickenCS.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }

                            }

                            if (Orderbtn.Name == DC_greeksalad.ID)
                            {
                                if (GreekS_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_GreekS++;
                                    String count = I_GreekS.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }

                            if (Orderbtn.Name == DC_tunasalad.ID)
                            {
                                if (TunaS_I != 1)
                                {
                                    //Increasing the Quantity
                                    I_TunaS++;
                                    String count = I_TunaS.ToString();
                                    String str;
                                    //Button Content
                                    str = btn_ID + " " + " :  " + count;
                                    //Button Status
                                    Orderbtn.Content = str;
                                    Orderbtn.Visibility = Visibility.Visible;
                                    Orderbtn.IsEnabled = true;
                                }
                            }
                        }                                                                    
                        
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

                    foreach (Button Orderbtn in (mainWindow.SP_plates).Children)
                    {
                        if (Orderbtn.Name == DC_chickenfillet.ID)
                        {
                            if (I_ChickenF == 1)
                            {
                                //Deactivate Button
                                I_ChickenF = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_ChickenF != 0)
                            {
                                //Decrease Quanitity
                                I_ChickenF = I_ChickenF - 1;
                                String count = I_ChickenF.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_steak.ID)
                        {
                            if (I_Steak == 1)
                            {
                                //Deactivate Button
                                I_Steak = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_Steak != 0)
                            {
                                //Decrease Quanitity
                                I_Steak = I_Steak - 1;
                                String count = I_Steak.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_salmonfillet.ID)
                        {
                            if (I_Salmon == 1)
                            {
                                //Deactivate Button
                                I_Salmon = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_Salmon != 0)
                            {
                                //Decrease Quanitity
                                I_Salmon = I_Salmon - 1;
                                String count = I_Salmon.ToString();
                                String str;
                                str = btn_ID + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_kebab.ID)
                        {
                            if (I_Kebab == 1)
                            {
                                //Deactivate Button
                                I_Kebab = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_Kebab != 0)
                            {
                                //Decrease Quanitity
                                I_Kebab = I_Kebab - 1;
                                String count = I_Kebab.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_chickenM.ID)
                        {
                            if (I_ChickenM == 1)
                            {
                                //Deactivate Button
                                I_ChickenM = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_ChickenM != 0)
                            {
                                //Decrease Quanitity
                                I_ChickenM = I_ChickenM - 1;
                                String count = I_ChickenM.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_fajitaS.ID)
                        {
                            if (I_FajitaS == 1)
                            {
                                //Deactivate Button
                                I_FajitaS = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_FajitaS != 0)
                            {
                                //Decrease Quanitity
                                I_FajitaS = I_FajitaS - 1;
                                String count = I_FajitaS.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_shrimpsteak.ID)
                        {
                            if (I_ShrimpSteak == 1)
                            {
                                //Deactivate Button
                                I_ShrimpSteak = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_ShrimpSteak != 0)
                            {
                                //Decrease Quanitity
                                I_ShrimpSteak = I_ShrimpSteak - 1;
                                String count = I_ShrimpSteak.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_chickenCS.ID)
                        {
                            if (I_ChickenCS == 1)
                            {
                                //Deactivate Button
                                I_ChickenCS = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_ChickenCS != 0)
                            {
                                //Decrease Quanitity
                                I_ChickenCS = I_ChickenCS - 1;
                                String count = I_ChickenCS.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_greeksalad.ID)
                        {
                            if (I_GreekS == 1)
                            {
                                //Deactivate Button
                                I_GreekS = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_GreekS != 0)
                            {
                                //Decrease Quanitity
                                I_GreekS = I_GreekS - 1;
                                String count = I_GreekS.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                        if (Orderbtn.Name == DC_tunasalad.ID)
                        {
                            if (I_TunaS == 1)
                            {
                                //Deactivate Button
                                I_TunaS = 0;
                                Orderbtn.Visibility = Visibility.Collapsed;
                                Orderbtn.IsEnabled = false;
                            }

                            if (I_TunaS != 0)
                            {
                                //Decrease Quanitity
                                I_TunaS = I_TunaS - 1;
                                String count = I_TunaS.ToString();
                                String str;
                                str = btn_ID + " " + " :  " + count;
                                Orderbtn.Content = str;
                            }
                        }

                    }

                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var parent = sender as Button;
            //Declaring
            #region delcaring
            if (parent.Name == DC_chickenfillet.ID)
            {
                price = DC_chickenfillet.Price;
                btn_ID = DC_chickenfillet.Name + " " + price;
                btn_content = DC_chickenfillet.Name + " " + price + ":  1";
                btn_name = DC_chickenfillet.ID;

                ChickenF_I++;
                if (ChickenF_I < 2)
                {
                    Btn_Add();
                }

            }

            if (parent.Name == DC_steak.ID)
            {
                price = DC_steak.Price;
                btn_ID = DC_steak.Name + " " + price;
                btn_content = DC_steak.Name + " " + price + ":  1";
                btn_name = DC_steak.ID;

                Steak_I++;
                if (Steak_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_salmonfillet.ID)
            {
                price = DC_salmonfillet.Price;
                btn_ID = DC_salmonfillet.Name + " " + price;
                btn_content = DC_salmonfillet.Name + " " + price + ":  1";
                btn_name = DC_salmonfillet.ID;

                Salmon_I++;
                if (Salmon_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_kebab.ID)
            {
                price = DC_kebab.Price;
                btn_ID = DC_kebab.Name + " " + price;
                btn_content = DC_kebab.Name + " " + price + ":  1";
                btn_name = DC_kebab.ID;

                Kebab_I++;
                if (Kebab_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_chickenM.ID)
            {
                price = DC_chickenM.Price;
                btn_ID = DC_chickenM.Name + " " + price;
                btn_content = DC_chickenM.Name + " " + price + ":  1";
                btn_name = DC_chickenM.ID;

                ChickenM_I++;
                if (ChickenM_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_fajitaS.ID)
            {
                price = DC_fajitaS.Price;
                btn_ID = DC_fajitaS.Name + " " + price;
                btn_content = DC_fajitaS.Name + " " + " " + price + ":  1";
                btn_name = DC_fajitaS.ID;

                FajitaS_I++;
                if (FajitaS_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_shrimpsteak.ID)
            {
                price = DC_shrimpsteak.Price;
                btn_ID = DC_shrimpsteak.Name + " " + price;
                btn_content = DC_shrimpsteak.Name + " " + price + ":  1";
                btn_name = DC_shrimpsteak.ID;

                Shrimp_I++;
                if (Shrimp_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_chickenCS.ID)
            {
                price = DC_chickenCS.Price;
                btn_ID = DC_chickenCS.Name + " " + price;
                btn_content = DC_chickenCS.Name + " " + price + ":  1";
                btn_name = DC_chickenCS.ID;

                ChickenCS_I++;
                if (ChickenCS_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_greeksalad.ID)
            {
                price = DC_greeksalad.Price;
                btn_ID = DC_greeksalad.Name + " " + price;
                btn_content = DC_greeksalad.Name + " " + price + ":  1";
                btn_name = DC_greeksalad.ID;

                GreekS_I++;
                if (GreekS_I < 2)
                {
                    Btn_Add();
                }
            }

            if (parent.Name == DC_tunasalad.ID)
            {
                price = DC_tunasalad.Price;
                btn_ID = DC_tunasalad.Name + " " + price;
                btn_content = DC_tunasalad.Name + " " + price + ":  1";
                btn_name = DC_tunasalad.ID;

                TunaS_I++;
                if (TunaS_I < 2)
                {
                    Btn_Add();
                }

            }
            #endregion

            Add();
        }

        private void CB_del_Click(object sender, RoutedEventArgs e)
        {
            //Declaring
            #region Declaring
            var parent = sender as Button;
            if (parent.Name == DC_chickenfillet.ID)
            {
                price = DC_chickenfillet.Price;
                btn_ID = DC_chickenfillet.Name + " " + price;
                btn_content = DC_chickenfillet + " " + price + ":  1";
                btn_name = DC_chickenfillet.ID; 
            }

            if (parent.Name == DC_steak.ID)
            {
                price = DC_steak.Price;
                btn_ID = DC_steak.Name + " " + price;
                btn_content = DC_steak + " " + price + ":  1";
                btn_name = DC_steak.ID; 
            }

            if (parent.Name == DC_salmonfillet.ID)
            {
                price = DC_salmonfillet.Price;
                btn_ID = DC_salmonfillet.Name + " " + price;
                btn_content = DC_salmonfillet + " " + price + ":  1";
                btn_name = DC_salmonfillet.ID; 
            }

            if (parent.Name == DC_kebab.ID)
            {
                price = DC_kebab.Price;
                btn_ID = DC_kebab.Name + " " + price;
                btn_content = DC_kebab + " " + price + ":  1";
                btn_name = DC_kebab.ID; 
            }

            if (parent.Name == DC_chickenM.ID)
            {
                price = DC_chickenM.Price;
                btn_ID = DC_chickenM.Name + " " + price;
                btn_content = DC_chickenM + " " + price + ":  1";
                btn_name = DC_chickenM.ID; 
            }

            if (parent.Name == DC_fajitaS.ID)
            {
                price = DC_fajitaS.Price;
                btn_ID = DC_fajitaS.Name + " " + price;
                btn_content = DC_fajitaS + " " + price + ":  1";
                btn_name = DC_fajitaS.ID; 
            }

            if (parent.Name == DC_shrimpsteak.ID)
            {
                price = DC_shrimpsteak.Price;
                btn_ID = DC_shrimpsteak.Name + " " + price;
                btn_content = DC_shrimpsteak + " " + price + ":  1";
                btn_name = DC_shrimpsteak.ID; 
            }

            if (parent.Name == DC_chickenCS.ID)
            {
                price = DC_chickenCS.Price;
                btn_ID = DC_chickenCS.Name + " " + price;
                btn_content = DC_chickenCS + " " + price + ":  1";
                btn_name = DC_chickenCS.ID;
            }

            if (parent.Name == DC_greeksalad.ID)
            {
                price = DC_greeksalad.Price;
                btn_ID = DC_greeksalad.Name + " " + price;
                btn_content = DC_greeksalad + " " + price + ":  1";
                btn_name = DC_greeksalad.ID;
            }

            if (parent.Name == DC_tunasalad.ID)
            {
                price = DC_tunasalad.Price;
                btn_ID = DC_tunasalad.Name + " " + price;
                btn_content = DC_tunasalad + " " + price + ":  1";
                btn_name = DC_tunasalad.ID;
            }
            #endregion

            Remove();           
        }
        #endregion
    }
}
