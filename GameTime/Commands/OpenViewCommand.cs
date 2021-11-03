using GameTime.Managers;
using GameTime.ViewModels;
using GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameTime.Commands
{
  
    public class OpenViewCommand : ICommand
    {
        
        public OpenViewCommand()
        {
        }

       
        public bool CanExecute(object parameter)
        {
            return true;
        }

      public void Execute(object parameter)
        {
            Window newViewGameView = new UpdateorDeleteView();
            WindowManager.ViewGameWindow = newViewGameView;


            UpdateOrDeleteViewModel newUpdateOrDeleteViewModel = new UpdateOrDeleteViewModel();
            newViewGameView.DataContext = newUpdateOrDeleteViewModel;

            newViewGameView.ShowDialog();

            newViewGameView.DataContext = null;
            newUpdateOrDeleteViewModel.Dispose();
        }

        public event EventHandler CanExecuteChanged;

    }
}
