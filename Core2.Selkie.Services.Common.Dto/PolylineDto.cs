using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class PolylineDto
    {
        [NotNull]
        public SegmentDto[] Segments = new SegmentDto[0];
    }
}