using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Extensions
{
    public static class ImageButtonExtensions
    {
        public static void AnimateOnClick(this ImageButton button)
        {
            if (button.AnimationIsRunning("ClickHeroesAnimation"))
                return;

            var parentAnimation = new Animation();
            parentAnimation.Add(0, 1, new Animation(x => button.Scale = x, 1, 10, Easing.CubicIn));
            parentAnimation.Add(0, 1, new Animation(x => button.Opacity = x, 1, 0, Easing.CubicIn));
            parentAnimation.Add(0.9, 1, new Animation(x => button.Scale = x, 4, 1, Easing.CubicIn));
            parentAnimation.Add(0.9, 1, new Animation(x => button.Opacity = x, 0, 1, Easing.CubicIn));
            parentAnimation.Commit(button, "ClickHeroesAnimation", 16, 200, null, null);
        }
    }
}
