using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Cliente_Socket2
{
    class Cliente
    {
        //porta de comunicação do socket
        const int PORTA = 9999;
        //tamanho máximo da mensagem recebida do cliente
        const int TAMANHO_BUFFER = 65536;
        //socket do cliente        
        private TcpClient cliente;
        //mensagem que o cliente manda para o servidor
        private string mensagem;
        //mensagem que o servidor manda de volta ao cliente
        public string respostaServidor;

        public Cliente()
        {
            this.cliente = new TcpClient();
            this.cliente.Connect("127.0.0.1", PORTA);
        }

        public void EnviarMensagem(string mensagem)
        {
            this.mensagem = mensagem;
            NetworkStream servidorStream = this.cliente.GetStream();
            /* adiciona um caractere especial para melhorar a
              * impressão da mensagem no servidor console
             * e converte a mensagem em um array de bytes
             */
            byte[] saida = Encoding.ASCII.GetBytes(mensagem + "$");

            //envia a mensagem ao servidor
            servidorStream.Write(saida, 0, saida.Length);
            servidorStream.Flush();
            byte[] entrada = new byte[TAMANHO_BUFFER];
            //recebe uma mensagem do servidor
            servidorStream.Read(entrada, 0, (int)this.cliente.ReceiveBufferSize);
            //converte a mensagem do servidor em uma string
            this.respostaServidor = Encoding.ASCII.GetString(entrada);
        }
    }
}
