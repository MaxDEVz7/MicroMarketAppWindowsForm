using System;


class Carro
{
    private string modelo;
    private int velocidadeAtual;


    public Carro(string modelo)
    {
        this.modelo = modelo;
    }


    public void acelerar(int aceleracao)
    {
        this.velocidadeAtual += aceleracao;
    }


    public void frear(int desacelerar)
    {
        if (desacelerar > this.velocidadeAtual)
        {
            this.velocidadeAtual = 0;
        }
        else
        {
            this.velocidadeAtual -= desacelerar;
        }
    }


    public String getModelo()
    {
        return this.modelo;
    }


    public int getVelocidadeAtual()
    {
        return this.velocidadeAtual;
    }


    public void setVelocidadeAtual(int velocidade)
    {
        if (velocidade < 0)
        {
            this.velocidadeAtual = 0;
            Console.WriteLine("Não é possivel atribuir velocidade menor que 0 ao Carro. Foi atribuido a velocidade de 0");
        }
        else
        {
            this.velocidadeAtual = velocidade;
        }
    }
}
