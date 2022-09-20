using RimWorld;
using Verse;

namespace VanillaFurnitureEM
{
    public class Building_CryptoBed : Building_Bed
    {
        public override void Tick()
        {
            if (GetCurOccupant(0) is Pawn occupant && occupant != null)
            {
                if (occupant.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Minor_CryptoSickness) == null && occupant.GetPosture() == PawnPosture.LayingOnGroundFaceUp)
                {
                    Hediff hediff = HediffMaker.MakeHediff(HediffDefOf.Minor_CryptoSickness, occupant);
                    hediff.Severity = 1f;
                    occupant.health.AddHediff(hediff);
                }
            }
            base.Tick();
        }
    }
}
