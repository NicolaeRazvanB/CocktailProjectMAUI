namespace TMWProjectCocktail.Views;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
            return;

        var parentAnimation = new Animation();

        //Intro Box Animation
        parentAnimation.Add(0.7, 1, new Animation(v => frmIntro.Opacity = v, 0, 1, Easing.CubicIn));

        //Commit the animation
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }
}