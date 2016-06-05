using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class LineSegmentDto : SegmentDto
    {
        [NotNull]
        public string RunDirection = string.Empty;
    }
}