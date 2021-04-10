using System;
using System.Threading;
using SoundProcessor;
using SoundProcessor.ThirdParty.Boss;
using SoundProcessor.ThirdParty.Ibanez;

namespace DeleteMe
{
    public class IbanezEchoizerAdapter : ISoundEffect
    {
        private readonly Echoizer _echoizer;

        public IbanezEchoizerAdapter(Echoizer echoizer) => _echoizer = echoizer;

        public void Apply(SoundTrack soundTrack) => _echoizer.Echoize(soundTrack);
    }

    public class BossDelayAdapter : ISoundEffect
    {
        private readonly Delay _delay;

        public BossDelayAdapter(Delay delay)
        {
            _delay = delay;
            _delay.Initialize();
        }
        public void Apply(SoundTrack soundTrack) => _delay.AddDelay(soundTrack);
    }

    class Program
    {
        
        
        static void Main(string[] args)
        {
            var processor = new Processor(new SoundTrack("La la la"));
            processor.AddEffect(new Distortion());
            processor.AddEffect(new IbanezEchoizerAdapter(new Echoizer(5)));
            processor.AddEffect(new BossDelayAdapter(new Delay()));
            processor.Process();
            Console.WriteLine(processor.Track.Sound);

        }
    }
}
