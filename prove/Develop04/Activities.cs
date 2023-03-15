public class Activities
{
    private int TimeForActivity;

    private string prompt;

    private string ListingPrompt;

    public void DoBreathingActivity()
    {
        BreathingActivity TakingABreath = new BreathingActivity();
        TimeForActivity = TakingABreath.BreathingTime();
        TakingABreath.Breathing(TimeForActivity);
    }

    public void DoReflectionActivity()
    {
        ReflectionAcivity ReflectWithMe = new ReflectionAcivity();
        prompt = ReflectWithMe.randomPrompt();
        ReflectWithMe.reflect(prompt);
    }

    public void DoListingActivity()
    {
        ListingActivity ListWithMe = new ListingActivity();
        ListingPrompt = ListWithMe.randomListingPrompts();
        ListWithMe.listing(ListingPrompt);

    }
}