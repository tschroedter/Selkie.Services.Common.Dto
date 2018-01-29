using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class LineSegmentDto : SegmentDto
    {
        [NotNull]
        public string RunDirection = string.Empty;
    }
}