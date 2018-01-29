using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class RacetracksDto
    {
        [NotNull]
        public PathDto[][] ForwardToForward = new PathDto[0][];

        [NotNull]
        public PathDto[][] ForwardToReverse = new PathDto[0][];

        public bool IsUnknown;

        [NotNull]
        public PathDto[][] ReverseToForward = new PathDto[0][];

        [NotNull]
        public PathDto[][] ReverseToReverse = new PathDto[0][];
    }
}