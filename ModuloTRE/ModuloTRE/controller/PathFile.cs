using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTRE.controller
{
    class PathFile
    {
        //private string local = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\EleicoesMunicipais\Arquivos\";
        private string local = @"D:\EleicoesMunicipais\Arquivos\"; //atributo com o local para salvar os arquivos
        

        //propriedade para acessar/retornar o local dos arquivos:
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}