namespace GameLibraryRemastered.Model
{
    public interface IGameObject2D : IUpdateable, IRenderable
    {
        Vector2 Position { get; set; }
    }
}