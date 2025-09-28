using System;


namespace Q1
{
    class Produto
    {
        private string nome;
        private double preco;


        public Produto(string nome, double preco)
        {
            this.preco = preco;
            this.nome = nome;
        }


        public void exibirDetalhes()
        {
            Console.WriteLine("Nome produto: " + this.nome + " Preço: " + preco);
        }


        public String getNome()
        {
            return this.nome;
        }


        public void setPreco(double preco)
        {
            if (preco < 0)
            {
                this.preco = 0;
                Console.WriteLine("Não é possivel atribuir preço menor que 0 ao produto. Foi atribuido o preço de 0");
            }
            else
            {
                this.preco = preco;
            }
        }
    }

}
