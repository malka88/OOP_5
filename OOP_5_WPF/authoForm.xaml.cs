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

namespace OOP_5_WPF
{
    /// <summary>
    /// Логика взаимодействия для authoForm.xaml
    /// </summary>
    public partial class authoForm : UserControl
    {
        //Name

        public static readonly DependencyProperty mageNameProperty = DependencyProperty.Register(
                 "mageName", // имя параметра в разметке
                 typeof(string), // тип данных параметра
                 typeof(authoForm), // тип данных элемента управления
                 new PropertyMetadata(string.Empty, mageNameChanged));

        public string mName
        {
            get { return (string)GetValue(mageNameProperty); }
            set { SetValue(mageNameProperty, value); }
        }

        private static void mageNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var mageNameForm = obj as authoForm;
            mageNameForm.mageName.Content = mageNameForm.mName;
        }

        //company

        public static readonly DependencyProperty companyNameProperty = DependencyProperty.Register(
                 "companyName", // имя параметра в разметке
                 typeof(string), // тип данных параметра
                 typeof(authoForm), // тип данных элемента управления
                 new PropertyMetadata(string.Empty, companyNameChanged));

        public string cName
        {
            get { return (string)GetValue(companyNameProperty); }
            set { SetValue(companyNameProperty, value); }
        }

        private static void companyNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var companyNameForm = obj as authoForm;
            companyNameForm.companyName.Content = companyNameForm.cName;
        }

        //status

        public static readonly DependencyProperty statusNameProperty = DependencyProperty.Register(
                 "statusName", // имя параметра в разметке
                 typeof(string), // тип данных параметра
                 typeof(authoForm), // тип данных элемента управления
                 new PropertyMetadata(string.Empty, statusNameChanged));

        public string sName
        {
            get { return (string)GetValue(statusNameProperty); }
            set { SetValue(statusNameProperty, value); }
        }

        private static void statusNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var statusNameForm = obj as authoForm;
            statusNameForm.statusName.Content = statusNameForm.sName;
        }

        //Image

        public static readonly DependencyProperty imageNameProperty = DependencyProperty.Register(
             "imageName", // имя параметра в разметке
             typeof(string), // тип данных параметра
             typeof(authoForm), // тип данных элемента управления
             new PropertyMetadata(string.Empty, imageNameChanged));

        public string iName
        {
            get { return (string)GetValue(imageNameProperty); }
            set { SetValue(imageNameProperty, value); }
        }

        private static void imageNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var imageNameForm = obj as authoForm;
            imageNameForm.imageName.Source = new BitmapImage(new Uri($"pack://application:,,,/{imageNameForm.iName}"));
        }

        public authoForm()
        {
            InitializeComponent();

            //this.iName.Source;
        }
    }
}
