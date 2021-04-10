namespace SoundProcessor
{
    public class Distortion : ISoundEffect
    {
        public void Apply(SoundTrack soundTrack) => soundTrack.Sound += " Adding distortion as in Master of Puppets";
    }
}