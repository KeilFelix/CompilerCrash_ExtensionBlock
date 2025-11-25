using CompilerCrash_ExtensionBlock.Grid;

namespace CompilerCrash_ExtensionBlock.Puzzle
{
    public record Marker() { }
    public record Start() : Ground(-1) { } 
    public record End() : Ground(-1) { } 
    public record Ground(int Height) : Marker { }
    public record Path(List<Grid<Marker>.Position> Positions) : Marker { }
    public record Walker(Path Path) { }
}
