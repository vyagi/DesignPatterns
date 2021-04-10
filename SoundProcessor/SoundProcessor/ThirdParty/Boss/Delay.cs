namespace SoundProcessor.ThirdParty.Boss
{
    public class Delay
    {
        private bool _initialized;

        public void Initialize() => _initialized = true;

        public void AddDelay(Soundtrack track)
        {
            if (_initialized) 
                track.Sound += " Adding delay as in Run Like Hell";
        }
    }
}
