class Programa
{
    static void Main(string[] args)
    {
        HistoricoNavegador historico = new HistoricoNavegador();

        // Adiciona algumas páginas ao histórico
        historico.AdicionarPagina("https://www.google.com");
        historico.AdicionarPagina("https://www.youtube.com");
        historico.AdicionarPagina("https://www.facebook.com");

        // Imprime o histórico
        historico.Imprimir();

        // Volta para a página anterior
        string paginaAnterior = historico.Voltar();
        Console.WriteLine("Página anterior: {0}", paginaAnterior);

        // Imprime o histórico novamente
        historico.Imprimir();

        // Avança para a página seguinte
        string paginaSeguinte = historico.Avancar();
        Console.WriteLine("Página seguinte: {0}", paginaSeguinte);

        // Imprime o histórico novamente
        historico.Imprimir();
    }
}

public class Pilha
{
    private List<string> _paginas;

    public Pilha()
    {
        _paginas = new List<string>();
    }

    public void Empilhar(string pagina)
    {
        _paginas.Add(pagina);
    }

    public string Desempilhar()
    {
        if (_paginas.Count == 0)
        {
            return null;
        }

        return _paginas.RemoveAt(_paginas.Count - 1);
    }

    public bool Vazia()
    {
        return _paginas.Count == 0;
    }

    public void Imprimir()
    {
        foreach (string pagina in _paginas)
        {
            Console.WriteLine(pagina);
        }
    }
}


public class HistoricoNavegador
{
    private Pilha _pilha;

    public HistoricoNavegador()
    {
        _pilha = new Pilha();
    }

    public void AdicionarPagina(string pagina)
    {
        _pilha.Empilhar(pagina);
    }

    public string Voltar()
    {
        return _pilha.Desempilhar();
    }

    public string Avancar()
    {
        if (_pilha.Vazia())
        {
            return null;
        }

        return _pilha.Top();
    }

    public void Imprimir()
    {
        _pilha.Imprimir();
    }
}
