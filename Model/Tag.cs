using System.ComponentModel;

namespace Model
{
    public enum Tag
    {
        [Description("Todos")]
        Todos = 1,
        [Description("Planejamento financeiro")]
        PlanejamentoFinanceiro = 2,
        [Description("Crianças e adolescentes")]
        CriancasAdolecentes = 3,
        [Description("Investimento")]
        Investimento = 4,
        [Description("Seguros e previdência")]
        SegurosPrevidencia = 5,
        [Description("Crédito e empréstimos")]
        CreditoEmprestimos = 6,
        [Description("Quitação de dívidas")]
        QuitacaoDividas = 7
    }
}
