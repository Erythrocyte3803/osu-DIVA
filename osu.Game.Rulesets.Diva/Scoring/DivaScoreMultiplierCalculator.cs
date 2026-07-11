// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Diva.Mods;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Scoring;
using osu.Game.Scoring;

namespace osu.Game.Rulesets.Diva.Scoring
{
    public class DivaScoreMultiplierCalculator : ScoreMultiplierCalculator
    {
        public DivaScoreMultiplierCalculator(ScoreMultiplierContext context)
            : base(context)
        {
            Single<DivaModNoDoubles>(hasMultiplier: 0.667);
        }
    }
}
