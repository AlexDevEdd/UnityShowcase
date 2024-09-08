using System;

namespace GamePlay
{
    [Serializable]
    public readonly struct AudioSettings
    {
        public readonly bool IsVolumeEnabled;
        public AudioSettings(bool isVolumeEnabled)
        {
            IsVolumeEnabled = isVolumeEnabled;
        }
    }
}