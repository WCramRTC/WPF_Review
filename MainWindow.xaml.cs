using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Observable Collection
        ObservableCollection<string> _names;
        List<string> _professors = new List<string>
        {
            "Anne",
            "Josh",
            "Will"
        };

        public MainWindow()
        {
            InitializeComponent();
            Preload();

            // This is how you add an obeservable collection
            cbListName.ItemsSource = _names;
            lbListName.ItemsSource = _professors;

            _names.Add("Jonathan");
            _professors.Add("Dan");

            runText.Text = "Hi everyone";
        } // MainWindow()


        public void Preload()
        {
            _names = new ObservableCollection<string>
            {
                "Henry",
                "Kai",
                "Ronda",
                "Meili",
                "Cirella",
                "EdnaLynn"
            };

            //foreach (string item in _names)
            //{
            //    cbListName.Items.Add(item);
            //}

            

            // This is how you add to a listbox
            //lbListName.Items.Add("Henry");

            //// Combo Box
            //cbListName.Items.Add("Kai");

        }


        private void btnListInfo_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbListName.SelectedIndex;
            int selectedCombo = cbListName.SelectedIndex;

            MessageBox.Show($"List Box: {selectedIndex} - Combo Box: {selectedCombo} ");

            if(selectedIndex == -1)
            {
                MessageBox.Show("You have not selected an item");
            }

            lbListName.Items.Clear();
        }


        private void btnDisplayInformation_Click(object sender, RoutedEventArgs e)
        {   

           //bool buttonOne = rbOne.IsChecked.Value;
            string buttonSelected = "";

            if(rbOne.IsChecked.Value)
            {
                buttonSelected = "One";
            }
            else if (rbTwo.IsChecked.Value)
            {
                buttonSelected = "Two";

            }
            else if(rbThree.IsChecked.Value)
            {
                buttonSelected = "Three";

            }
            else if(rbFour.IsChecked.Value)
            {
                buttonSelected = "Four";
            }
            else
            {
                buttonSelected = "None";
            }

            bool isChecked = chkBox.IsChecked.Value;

            MessageBox.Show(
                "Button Selected: " + buttonSelected + "\n"
                + $"Check Box Is Checked: {isChecked}"
                );
        }

    } // class

} // namespace
