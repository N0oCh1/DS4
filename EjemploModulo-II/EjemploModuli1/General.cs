using System.Linq;

public static class MetodoGeneral
{
    public static void MultiplosDTres(int inicio, int fin, ref int total)
    {
        total = Enumerable.Range(inicio,fin-inicio+1).Where(x => x%3 == 0).Count();
    }
}