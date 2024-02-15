using MauiMarvelHeroes.ViewModels;

namespace MauiMarvelHeroes.Pages
{
    public partial class StartPage : ContentPage
    {
        public StartPage(StartViewModel viewModel)
        {
            this.BindingContext = viewModel;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (this.AnimationIsRunning("TransitionAnimation"))
                return;

            var parentAnimation = new Animation();

            //Heroes Animation
            parentAnimation.Add(0.3, 0.5, new Animation(v => imgCaptain.Opacity = v, 0, 1, Easing.CubicIn));
            parentAnimation.Add(0.05, 0.4, new Animation(v => imgHulk.Opacity = v, 0, 1, Easing.CubicIn));
            parentAnimation.Add(0.25, 0.5, new Animation(v => imgLobezno.Opacity = v, 0, 1, Easing.CubicIn));
            parentAnimation.Add(0.30, 0.5, new Animation(v => imgThor.Opacity = v, 0, 1, Easing.CubicIn));

            parentAnimation.Add(0.35, 0.4, new Animation(x => imgCaptain.Scale = x, 1, 1.3, Easing.CubicIn));
            parentAnimation.Add(0.2, 0.45, new Animation(x => imgHulk.Scale = x, 1, 1.2, Easing.CubicIn));
            parentAnimation.Add(0.4, 0.55, new Animation(x => imgLobezno.Scale = x, 1, 1.2, Easing.CubicIn));

            parentAnimation.Add(0.6, 0.65, new Animation(v => imgSpiderman.Opacity = v, 0, 1, Easing.CubicIn));
            parentAnimation.Add(0.65, 0.7, new Animation(x => imgSpiderman.Scale = x, 1, 2, Easing.CubicIn));
            
            parentAnimation.Add(0.45, 0.5, new Animation(v => imgIronman.Opacity = v, 0, 1, Easing.CubicIn));
            parentAnimation.Add(0.45, 0.5, new Animation(x => imgIronman.Scale = x, 1, 1.2, Easing.CubicIn));
            parentAnimation.Add(0.45, 0.55, new Animation(d => imgIronman.TranslationY = d, 
                imgIronman.TranslationY, 
                imgIronman.TranslationY - 400, Easing.BounceIn));

            //Intro Box Animation
            parentAnimation.Add(0.7, 1, new Animation(v => stackIntro.Opacity = v, 0, 0.85, Easing.CubicIn));

            //Commit the animation
            parentAnimation.Commit(this, "TransitionAnimation", 16, 5000, null, null);

            var buttonAnimation = new Animation();
            buttonAnimation.Add(0, 0.2, new Animation(x => enterButton.Scale = x, 1, 1.2, Easing.BounceIn));
            buttonAnimation.Add(0.3, 0.8, new Animation(x => enterButton.Scale = x, 1.2, 1, Easing.BounceOut));
            buttonAnimation.Commit(this, "ButtonAnimation", 16, 2000, null, null, () => true);


        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (this.AnimationIsRunning("TransitionAnimation"))
                return;

            var parentAnimation = new Animation();

            //Heroes Animation
            parentAnimation.Add(0.0, 0.1, new Animation(v => stackIntro.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.1, 0.2, new Animation(v => imgCaptain.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.2, 0.3, new Animation(v => imgHulk.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.3, 0.4, new Animation(v => imgIronman.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.4, 0.5, new Animation(v => imgLobezno.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.5, 0.6, new Animation(v => imgThor.Opacity = v, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.6, 0.7, new Animation(v => imgSpiderman.Opacity = v, 1, 0, Easing.CubicIn));

            //Commit the animation
            parentAnimation.Commit(this, "TransitionAnimation", 16, 2000, null, null);

        }
    }

}
