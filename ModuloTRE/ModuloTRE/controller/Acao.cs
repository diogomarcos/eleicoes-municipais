using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloTRE.controller
{
    class Acao
    {
        //mensagem para confirmar a saida do programa:
        public static DialogResult MsgSair()
        {
            return (MessageBox.Show("Deseja Realmente Sair!", "Sair", MessageBoxButtons.YesNo));
        }

        //mensagem para preenchar todos os campos:
        public static void MsgCampo()
        {
            MessageBox.Show("Preencha todos os campos!", "Atenção");
        }

        //mensagem para confirmar dados salvos
        public static void MsgSalvo()
        {
            MessageBox.Show("Dados salvos com sucesso","Confirmação");
        }

        //vetor com os estados:
        public static void Estado(ComboBox cb)
        { 
            string[] estado = {
                                  "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", 
                                  "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", 
                                  "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
                              };
            cb.Items.AddRange(estado);
        }
    }
}
