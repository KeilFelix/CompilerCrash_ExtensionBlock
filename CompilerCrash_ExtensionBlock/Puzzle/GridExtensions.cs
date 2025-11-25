using CompilerCrash_ExtensionBlock.Grid;
using System.Runtime.CompilerServices;

namespace CompilerCrash_ExtensionBlock.Puzzle;

public static class GridExtensions
{
    extension(Grid<Marker>.Position position)
    {
        //This works as extension block
        public IEnumerable<Grid<Marker>.Position> GetNeighbors()
            => Directions.Orthogonal(2)
                .Select(direction => position.Move(new Move(direction, 1)))
                .Where(p => p.Objects.Any());

        //This method causes compiler crash
        public IEnumerable<Grid<Marker>.Position> GetWalkablePositionsCrash()
        {
            var currentGround = position.Objects.Single(o => o.Value is Ground);
            var height = ((Ground)currentGround.Value).Height;
            return Directions.Orthogonal(2)
                .Select(direction => position.Move(new Move(direction, 1)))
                .Where(neighbor => neighbor.Objects.Any(o => o.Value is Ground ground && (height == -1 || Math.Abs(ground.Height - height) <= 1)));
        }
    }

    //Clone without extension block that works fine
    public static IEnumerable<Grid<Marker>.Position> GetWalkablePositionsClone(this Grid<Marker>.Position position)
    {
        var currentGround = position.Objects.Single(o => o.Value is Ground);
        var height = ((Ground)currentGround.Value).Height;
        return Directions.Orthogonal(2)
            .Select(direction => position.Move(new Move(direction, 1)))
            .Where(neighbor => neighbor.Objects.Any(o => o.Value is Ground ground && (height == -1 || Math.Abs(ground.Height - height) <= 1)));
    }
}
