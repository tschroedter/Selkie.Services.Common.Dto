using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    public class LineSegmentDto : SegmentDto
    {
        [NotNull]
        public string RunDirection = string.Empty;
    }
}