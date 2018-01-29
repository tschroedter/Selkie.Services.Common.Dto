using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class ArcSegmentDto : SegmentDto
    {
        [NotNull]
        public CircleDto Circle = new CircleDto();

        [NotNull]
        public string TurnDirection = string.Empty;
    }
}