using System;
using System.Windows.Forms;

namespace Avicola.Common.Win
{
    public interface IFormFactory
    {
        T Create<T>() where T : Form;
        T Create<T>(int id) where T : Form;
        T Create<T>(Guid id) where T : Form;
    }
}
