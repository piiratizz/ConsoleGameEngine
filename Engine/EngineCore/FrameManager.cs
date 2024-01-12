using System.Collections.Generic;
using Engine.EngineCore;
using Engine.ConsoleEngine;

namespace Engine.EngineCore
{
    public static class FrameManager
    {
        private static readonly FrameRenderer _frameRenderer = new FrameRenderer();
        private static readonly FrameCreator _frameCreator = new FrameCreator();
        private static readonly List<IRenderer> _renderers = new List<IRenderer>();

        public static void RegisterRenderer(IRenderer renderer) => _renderers.Add(renderer);

        public static void Build(int width, int height)
        {
            Frame frame = _frameCreator.Create(_renderers, width, height);
            CollisionDetector.UpdateFrame(frame);
            GridManager.UpdateGrid(frame);
            _frameRenderer.Render(frame);
        }
    }
}