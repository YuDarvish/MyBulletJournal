using MyBulletJJournal.Coree.Contract;
using MyBulletJJournal.Coree.Dto;
using MyBulletJJournal.Coree.UseCases;
using MyBulletJournal.Services.Gateways;
using MyBulletJournal.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyBulletJournal.Views
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class DailyLog : Page
    {
        public DailyLogViewModel ViewModel;
        public IBulletRepository _bulletRepository;

        public DailyLog()
        {
            this.InitializeComponent();
            //ViewModel = new DailyLogViewModel(DateTime.Now);
            _bulletRepository = new BulletRepository();
            ViewModel = new DailyLogViewModel(_bulletRepository);
            
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            //ViewModel.GetBullets(DateTime.Now);
            ViewModel.LoadBullets();
        }

        private async void Button_ClickedAsync(object sender, RoutedEventArgs e)
        {
            var result = await contetDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                string textTitle = tbx_title.Text;
                int signifierCoode = cmb.SelectedIndex;
                DateTime date = ViewModel.Days.FirstOrDefault().Date;

                var requestMessage = new AddTaskRequestMessage(textTitle, signifierCoode, date);
                var addTaskUseCase = new AddTaskInteractor(_bulletRepository);
                var responseMessage = addTaskUseCase.Handle(requestMessage);

                ViewModel.LoadBullets();
                listView.ItemsSource = ViewModel.Days;
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }
        }

        private async void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var result = await contetDialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                AddNewBullet(tbx_title, cmb.SelectedIndex, );
                ViewModel.LoadBullets();
                listView.ItemsSource = ViewModel.Days;
            }
            else
            {
            }
        }

        private void AddNewBullet(string textTitle, int signifierCoode, DateTime date)
        {
            var requestMessage = new AddTaskRequestMessage(textTitle, signifierCoode, date);
            var addTaskUseCase = new AddTaskInteractor(_bulletRepository);
            var responseMessage = addTaskUseCase.Handle(requestMessage);

            ViewModel.LoadBullets();
            listView.ItemsSource = ViewModel.Days;
        }
    }
}
