using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Cineplay.Extensions
{
    public static class ControlExtensions
    {
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
            where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                {
                    action(source);

                }
                else
                {
                    source.Invoke(new Action(() => action(source)));
                }
                //Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                Debug.Write("Error on 'InvokeIfRequired': {0}", ex.Message);
            }
            return source;
        }

    //    public static T updatePosition<T>(this T source, String )
    //where T : Control
    //    {
    //        source.Invoke(new Action(() => action(source)));
    //        return source;
    //    }

    }
}