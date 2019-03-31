using System; 
using Exemplo_1.Logs;

namespace Exemplo_1
{
    /*
      Evita acoplar o remetente com seu receptor dando mais de um objeto para
        lidar com a requisição

        Quando usar:
        - mais de 1 objeto pode lidar com a requisição
        - voce quer deixar varios objetos disponiveis sem especificar qual 
            será realmente o receptor
     */
    class Program
    {
        static void Main(string[] args)
        {
            Log db = new DB();
            Log email = new Email();
            Log txt = new Txt();

            db.SetSucessor(txt);
            txt.SetSucessor(email);

            db.GerarLog(0);
            db.GerarLog(1);
            db.GerarLog(2);

            Console.ReadKey();
        }
    }
}
