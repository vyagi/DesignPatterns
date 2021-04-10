namespace SoundProcessor
{
    public class Distortion : ISoundEffect
    {
        public void Apply(Soundtrack soundtrack) => soundtrack.Sound += " Adding distortion as in Master of Puppets";
    }
}