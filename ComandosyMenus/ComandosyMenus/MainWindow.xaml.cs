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

namespace ComandosyMenus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock itemListBox = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Añadir ----------------------------------------------------------------------------------------------------------------------
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBlock item = new TextBlock();
                item.Text = "Item añadido a las " + horaTextBlock.Text;

            itemsListBox.Items.Add(item);
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (itemsListBox.Items.Count < 10)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }


        //Copiar ----------------------------------------------------------------------------------------------------------------------
        private void CopyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            itemListBox = (TextBlock)itemsListBox.SelectedItem;
        }

        private void CopyCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (itemsListBox.SelectedItem != null && itemsListBox.Items.Count > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }


        //Cortar ----------------------------------------------------------------------------------------------------------------------
        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            itemListBox = (TextBlock)itemsListBox.SelectedItem;
            itemsListBox.Items.Remove(itemsListBox.SelectedItem);
        }

        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (itemsListBox.SelectedItem != null)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }


        //Pegar ----------------------------------------------------------------------------------------------------------------------
        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            itemsListBox.Items.Add(itemListBox);
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (itemListBox != null)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }


        //Salida  ----------------------------------------------------------------------------------------------------------------------
        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void ExitCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


        //Eliminar Copia ----------------------------------------------------------------------------------------------------------------------
        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            itemListBox = null;
        }

        private void DeleteCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (itemListBox != null)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

    }
}
