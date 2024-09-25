namespace GameLibraryRemastered.Model
{
    public interface IGameObject3D : IUpdateable, IRenderable
    {
        Vector3 Position { get; set; }
    }
}