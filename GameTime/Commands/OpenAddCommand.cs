using GameTime.Managers;
using GameTime.ViewModels;
using GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace GameTime.Commands
{
     public class OpenAddCommand : ICommand
    {
         public OpenAddCommand()
        {
        }
 public bool CanExecute(object parameter)
        {
            return true;
        }

         public void Execute(object parameter)
        {
            Window newAddGameView = new AddGameView();
            WindowManager.AddGameWindow = newAddGameView;

            AddGameViewModel newAddGameViewModel = new AddGameViewModel();
            newAddGameView.DataContext = newAddGameViewModel;

            newAddGameView.ShowDialog();

            newAddGameView.DataContext = null;
            newAddGameViewModel.Dispose();
        }


        public event EventHandler CanExecuteChanged;

    }
}
