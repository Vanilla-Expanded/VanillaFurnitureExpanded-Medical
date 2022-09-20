using RimWorld;
using Verse;

namespace VanillaFurnitureEM
{
    [DefOf]
    public static class HediffDefOf
    {
        public static HediffDef Minor_CryptoSickness;

        static HediffDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
    }
}
