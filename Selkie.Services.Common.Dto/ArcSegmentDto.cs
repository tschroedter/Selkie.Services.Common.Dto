using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
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