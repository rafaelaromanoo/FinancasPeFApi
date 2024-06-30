using System.ComponentModel;

namespace Model
{
    public enum Tag
    {
        [Description("Todos")]
        Todos,
        [Description("Planejamento financeiro")]
        PlanejamentoFinanceiro,
        [Description("Crianças e adolescentes")]
        CriancasAdolecentes,
        [Description("Investimento")]
        Investimento,
        [Description("Seguros e previdência")]
        SegurosPrevidencia,
        [Description("Crédito e empréstimos")]
        CreditoEmprestimos,
        [Description("Quitação de dívidas")]
        QuitacaoDividas
    }
}
