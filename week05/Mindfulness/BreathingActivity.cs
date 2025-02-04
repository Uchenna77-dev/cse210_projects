public class BreathingActivity : Activity
{
   public BreathingActivity(int duration)
            : base("Breathing", "This activity will guide you through a breathing exercise to help you relax, clear your mind and focus on your breathing", duration)
        {
        }

        protected override void PerformActivity()
    {
        int breathDuration = _duration / 3;
        for (int i = 0; i < breathDuration; i++)
        {

            Console.Write("Breathe in   \n");
            Thread.Sleep(1000);
            ShowCountDown(5);
            DisplaySpinner(_duration);

            Console.Write("Breathe out  \n");
            ShowCountDown(6);
            Thread.Sleep(1000);
            DisplaySpinner(_duration);
        }
    }
    
}
