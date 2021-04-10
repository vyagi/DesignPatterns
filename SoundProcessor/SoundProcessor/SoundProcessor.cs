using System.Collections.Generic;

namespace SoundProcessor
{
    public class Processor
    {
        public SoundTrack Track { get; }

        private readonly IList<ISoundEffect> _effects = new List<ISoundEffect>();

        public Processor(SoundTrack track) => 
            Track = track;

        public void AddEffect(ISoundEffect effect) => _effects.Add(effect);

        public void Process()
        {
            foreach (var soundEffect in _effects) 
                soundEffect.Apply(Track);
        }
    }
}
