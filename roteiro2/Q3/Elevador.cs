using System;

class Elevador
{
    private int totalAndares;
    private int andarAtual;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
    }

    public void subir()
    {
        if (this.andarAtual == this.totalAndares)
        {
            return;
        }
        else
        {
            this.andarAtual += 1;
        }
    }

    public void descer()
    {
        if (this.andarAtual == 0)
        {
            return;
        }
        else
        {
            this.andarAtual -= 1;
        }
    }

    public int getAndarAtual()
    {
        return this.andarAtual;
    }
}
