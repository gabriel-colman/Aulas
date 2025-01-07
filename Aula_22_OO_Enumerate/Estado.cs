namespace Aula_22_OO_Enumerate
{
    public enum Estado
    {
        SP,
        RJ,
        MG,
        Ba,
    }
    public class EstecaoEstado {
        public static string GetDescricao(Estado estado) {
            switch (estado) {
                case Estado.SP:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerais";
                case Estado.Ba:
                    return "Bahia";
                default:
                    return "Estado não encontrado";
            }
        }
    }

    public class Regiao
    {
        public string[] Regioes = new string[] { "Sul", 
        "Sudeste", "Centro-Oeste", "Norte", "Nordeste" };

        public string GetRegiao(Estado estado)
        {
            return estado switch 
            {
                // É possivel fazer um switch dentro return porque o switch é uma expressão
                Estado.SP => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.Ba => Regioes[4],
                _ => "Região não encontrada",
            };
        }
    }
}