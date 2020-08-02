using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhileStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void openFileClick(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            fp.ViewMode = PickerViewMode.List;
            fp.FileTypeFilter.Add("*");

            StorageFile file = await fp.PickSingleFileAsync();
            //represents a file
            if (file != null)
            {
                fileName.Text = file.Path;

                var fileStream = await file.OpenAsync(FileAccessMode.Read);
                var inputStream = fileStream.GetInputStreamAt(0);
                TextReader reader = new StreamReader(inputStream.AsStreamForRead());
                //Reads a line of characters from the text reader and returns the data as a string.
                displayData(reader);
            }
        }

        private void displayData(TextReader reader)
        {
            // TODO: add while loop here
            //calls the readline method from the reader object and assigns it to the line of type string
            //Reads a line of characters from the text reader and returns the data as a string.
            //if there are no more characters to read it return null
            //a line is a sequence of characters
            //this is a priming read (string line = reader.ReadLine();
            //while (line != null) the inside of the parenthesis is a boolean expression as long as line does not equal null
            //source.Text initializes the variable
            //string line = reader.ReadLine() test iteration variable
            //source.Text += line + '\n' updates iteration variable
            //reader.Dispose() it calls the dipsose method of the reader object 
            source.Text = "";
            string line = reader.ReadLine();
            while (line != null)
            {
                source.Text += line + '\n';
                line = reader.ReadLine();
            }
            reader.Dispose();
        }
    }
}
