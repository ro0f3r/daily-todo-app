using System.Xml.Schema;
using DailyToDo.ViewModel;
using GalaSoft.MvvmLight.Ioc;

namespace DailyToDo
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<TodoListViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
        }

        public TodoListViewModel TodoListViewModel
        {
            get
            {
                if (!SimpleIoc.Default.IsRegistered<TodoListViewModel>())
                {
                    SimpleIoc.Default.Register<TodoListViewModel>();
                }

                return SimpleIoc.Default.GetInstance<TodoListViewModel>();
            }
        }

        public SettingsViewModel SettingsViewModel
        {
            get
            {
                if (!SimpleIoc.Default.IsRegistered<SettingsViewModel>())
                {
                    SimpleIoc.Default.Register<SettingsViewModel>();
                }

                return SimpleIoc.Default.GetInstance<SettingsViewModel>();
            }
        }
    }
}