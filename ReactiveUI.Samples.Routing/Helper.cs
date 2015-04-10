using System;

namespace ReactiveUI.Samples.Routing
{
    using System.Windows;

    public static class Helper
    {
        public static void Log(this object obj, bool isDestroy)
        {
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.BeginInvoke(
                    new Action(
                    () =>
                    {
                        var str = string.Format("[{0}] {1}", obj.GetHashCode(), obj.GetType().Name);

                        if (isDestroy)
                        {
                            MainWindow.ListMsgDestroy.Add(str);
                        }
                        else
                        {
                            MainWindow.ListMsgCreate.Add(str);
                        }
                    }));
            }
        }
    }
}
