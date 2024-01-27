namespace aula21
{
    internal class Program
    {
        static void Main() 
        {
            string senha = "123";
            string senhauser;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhauser= Console.ReadLine();
                tentativas++;
            } while(senhauser != senha);

            Console.Clear(); 
            Console.WriteLine("Senha correta, tentativas:{0}", tentativas);
        }
    }
}