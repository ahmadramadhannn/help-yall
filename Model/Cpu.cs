
namespace HelpYAll.Model.Cpu;

public class Cpu
{
    public int Id { get; set; }
    public int Tdp { get; set; }
    public int Cores { get; set; }
    public int Threads { get; set; }
    public int Socket { get; set; }
    public string CodeName { get; set; } = null!;
    public decimal BaseClock { get; set; }
    public decimal BoostClock { get; set; }
}