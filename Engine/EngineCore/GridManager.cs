using Engine.ConsoleEngine;

namespace Engine.EngineCore;

public static class GridManager
{
    private static GridCell[,]? _gridCells;
    public static void UpdateGrid(Frame frame)
    {
        _gridCells = frame.Bitmap;
    }

    public static string GetCellTagAtPosition(Vector2 position)
    {
        return _gridCells![position.X, position.Y].Cell.tag;
    }
}