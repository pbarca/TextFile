using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TextFile
{
    class TextFile
    {
        private string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private string _texto;

        public string Abrir
        {
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
        }

        public string Eliminar()
        {
            _texto = "";
            return _texto;
        }
        public void Gravar(string valor)
        {
            _texto = valor;
            File.WriteAllText(_path, _texto);
        }
        public string Maiusculas(string valor)
        {
            _texto = valor.ToUpper();
            return _texto;
        }
        public string Minusculas(string valor)
        {
            _texto = valor.ToLower();
            return _texto;
        }

        public string Iniciais(string valor)
        {
            valor = valor.ToLower();
            _texto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(valor);
            return _texto;
        }

    }
}
