// Decompiled with JetBrains decompiler
// Type: AOMoreMedical.Building_CryptoBed
// Assembly: AOMoreMedical, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B0F05AA-5836-4497-AC19-28FED9FA74F8
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\VanillaFurnitureExpanded-Medical\1.4\Assemblies\AOMoreMedical.dll

using RimWorld;
using Verse;

namespace AOMoreMedical
{
  public class Building_CryptoBed : Building_Bed
  {
    public override void Tick()
    {
      if (this.GetCurOccupant(0) != null)
      {
        Pawn curOccupant = this.GetCurOccupant(0);
        if (curOccupant.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Minor_CryptoSickness) == null && curOccupant.GetPosture() == PawnPosture.LayingOnGroundFaceUp)
        {
          Hediff hediff = HediffMaker.MakeHediff(HediffDefOf.Minor_CryptoSickness, curOccupant);
          hediff.Severity = 1f;
          curOccupant.health.AddHediff(hediff);
        }
      }
      base.Tick();
    }
  }
}
