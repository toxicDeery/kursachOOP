using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace kursachOOP
{
    public delegate void Display();
    public class DelegateC : IDisposable
    {
        private System.ComponentModel.Component components = new System.ComponentModel.Component();
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    components.Dispose();
                }
                disposed = true;
            }
        }

        string testdelegat;

        Display display;

        public void ElementAdded()
        {

            testdelegat = ("Помещение добавлено (демонстрация делегата)");
        }
        public string Displayed(Object obj)
        {
            string dele = obj.GetType().ToString();
            switch (dele)
            {
                case "kursachOOP.Placement":
                    display += ElementAdded;
                    break;

            }
            display();
            return testdelegat;
        }
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();
    }
}
