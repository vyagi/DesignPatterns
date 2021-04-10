using System.Linq;

namespace SoundProcessor.ThirdParty.Ibanez
{
    public class Echoizer
    {
        private readonly int _echoLevel;

        public Echoizer(int echoLevel) => _echoLevel = echoLevel;

        public void Echoize(SoundTrack track) => track.Sound += $" Adding {string.Concat(Enumerable.Repeat("echo ", _echoLevel))}";
    }
}
