namespace Assets.Code.Scripts.Runtime.Save_System
{
    public interface ISaveLoadService
    {
        bool IsLoaded { get; }
        void Load();
        void Save();
    }
}