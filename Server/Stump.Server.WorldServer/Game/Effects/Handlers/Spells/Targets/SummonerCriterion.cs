﻿using Stump.Server.WorldServer.Game.Actors.Fight;

namespace Stump.Server.WorldServer.Game.Effects.Handlers.Spells.Targets
{
    public class SummonerCriterion : TargetCriterion
    {
        public SummonerCriterion(bool required)
        {
            Required = required;
        }

        public bool Required
        {
            get;
            set;
        }

        public override bool IsTargetValid(FightActor actor, SpellEffectHandler handler)
        {
            if (Required)
            {
                return (actor is SummonedFighter && ((SummonedFighter)actor).Summoner == handler.Caster) ||
                                (actor is SummonedBomb && ((SummonedBomb)actor).Summoner == handler.Caster);
            }

            return !(actor is SummonedFighter) || !(actor is SummonedBomb) ||
                   (actor is SummonedFighter && ((SummonedFighter)actor).Summoner != handler.Caster &&
                   actor is SummonedBomb && ((SummonedBomb)actor).Summoner != handler.Caster);
        }
    }
}