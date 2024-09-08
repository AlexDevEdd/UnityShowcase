namespace GamePlay
{
    // [UsedImplicitly]
    // public sealed class AudioSettingsSaveLoader : SaveLoader<AudioSettings, AudioSystem>
    // {
    //     public AudioSettingsSaveLoader(GameDataStorage gameDataStorage, AudioSystem audioSystem) 
    //         : base(gameDataStorage, audioSystem) { }
    //
    //     protected override AudioSettings ConvertToData(AudioSystem audioSystem)
    //     {
    //         return new AudioSettings( audioSystem.IsVolumeEnabled.Value);
    //     }
    //
    //     protected override void SetUpData(AudioSettings data, AudioSystem audioSystem)
    //     {
    //         audioSystem.SetVolume(data.IsVolumeEnabled);
    //     }
    // }
}